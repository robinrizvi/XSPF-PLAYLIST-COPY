using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace XSPF_COPY
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        private void xspfbrowse_Click(object sender, EventArgs e)
        {
            if (filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) xspfname.Text = filedialog.FileName;
            else xspfname.Text = "";
        }

        private void folderbrowse_Click(object sender, EventArgs e)
        {
            if (folderdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) foldername.Text = folderdialog.SelectedPath;
            else foldername.Text = "";
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            if (xspfname.Text != "" && foldername.Text != "")
            {
                copybtn.Enabled = false;
                xspfbrowse.Enabled = false;
                folderbrowse.Enabled = false;
                copybtn.Text = "COPYING...";
                String[] playlist_destination = {xspfname.Text,foldername.Text};
                copyfilesworker.RunWorkerAsync(playlist_destination);
            }
            else MessageBox.Show("Please select the xspf file and destination folder");
        }

        private void copyfilesworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String[] playlist_destination = (String[]) e.Argument;
                XmlDocument doc = new XmlDocument();
                doc.Load(playlist_destination[0]);
                XmlNamespaceManager namespacesmanager = new XmlNamespaceManager(doc.NameTable);
                namespacesmanager.AddNamespace("playlist", "http://xspf.org/ns/0/");
                XmlNodeList nodes = doc.SelectNodes("//playlist:track", namespacesmanager);
                Int64 count = 0;
                foreach (XmlNode node in nodes)
                {
                    String tracklocation = node["location"].InnerText;
                    Uri uri = new Uri(tracklocation);
                    String sourcefile = uri.LocalPath;
                    String destfile = playlist_destination[1] + '\\' + Path.GetFileName(sourcefile);
                    String statustext = "(" + (++count) + "/" + nodes.Count + ") - " + sourcefile;
                    copyfilesworker.ReportProgress(100, statustext);
                    File.Copy(sourcefile, destfile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void copyfilesworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statuslbl.Text = e.UserState.ToString();
        }

        private void copyfilesworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Playlist copy process completed");
            copybtn.Enabled = true;
            xspfbrowse.Enabled = true;
            folderbrowse.Enabled = true;
            copybtn.Text = "COPY FILES";
            statuslbl.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.softlogicui.com");
                System.Diagnostics.Process.Start("http://www.robinrizvi.info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
