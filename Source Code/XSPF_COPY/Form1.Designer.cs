namespace XSPF_COPY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filedialog = new System.Windows.Forms.OpenFileDialog();
            this.folderdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.xspfbrowse = new System.Windows.Forms.Button();
            this.xspfname = new System.Windows.Forms.Label();
            this.folderbrowse = new System.Windows.Forms.Button();
            this.foldername = new System.Windows.Forms.Label();
            this.copybtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.copyfilesworker = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // filedialog
            // 
            this.filedialog.Filter = "xspf files|*.xspf|all|*.*";
            // 
            // xspfbrowse
            // 
            this.xspfbrowse.BackColor = System.Drawing.Color.LightSlateGray;
            this.xspfbrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.xspfbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xspfbrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xspfbrowse.Location = new System.Drawing.Point(0, 0);
            this.xspfbrowse.Name = "xspfbrowse";
            this.xspfbrowse.Size = new System.Drawing.Size(284, 23);
            this.xspfbrowse.TabIndex = 1;
            this.xspfbrowse.Text = "Select XSPF File";
            this.xspfbrowse.UseVisualStyleBackColor = false;
            this.xspfbrowse.Click += new System.EventHandler(this.xspfbrowse_Click);
            // 
            // xspfname
            // 
            this.xspfname.AutoSize = true;
            this.xspfname.Dock = System.Windows.Forms.DockStyle.Top;
            this.xspfname.Location = new System.Drawing.Point(0, 23);
            this.xspfname.Name = "xspfname";
            this.xspfname.Size = new System.Drawing.Size(0, 13);
            this.xspfname.TabIndex = 2;
            // 
            // folderbrowse
            // 
            this.folderbrowse.BackColor = System.Drawing.Color.LightSlateGray;
            this.folderbrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.folderbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderbrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.folderbrowse.Location = new System.Drawing.Point(0, 36);
            this.folderbrowse.Name = "folderbrowse";
            this.folderbrowse.Size = new System.Drawing.Size(284, 23);
            this.folderbrowse.TabIndex = 3;
            this.folderbrowse.Text = "Select Destination Directory";
            this.folderbrowse.UseVisualStyleBackColor = false;
            this.folderbrowse.Click += new System.EventHandler(this.folderbrowse_Click);
            // 
            // foldername
            // 
            this.foldername.AutoSize = true;
            this.foldername.Dock = System.Windows.Forms.DockStyle.Top;
            this.foldername.Location = new System.Drawing.Point(0, 59);
            this.foldername.Name = "foldername";
            this.foldername.Size = new System.Drawing.Size(0, 13);
            this.foldername.TabIndex = 4;
            // 
            // copybtn
            // 
            this.copybtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.copybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.copybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copybtn.ForeColor = System.Drawing.Color.White;
            this.copybtn.Location = new System.Drawing.Point(0, 72);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(284, 23);
            this.copybtn.TabIndex = 5;
            this.copybtn.Text = "COPY FILES";
            this.copybtn.UseVisualStyleBackColor = false;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.statuslbl.Location = new System.Drawing.Point(0, 95);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 13);
            this.statuslbl.TabIndex = 6;
            // 
            // copyfilesworker
            // 
            this.copyfilesworker.WorkerReportsProgress = true;
            this.copyfilesworker.WorkerSupportsCancellation = true;
            this.copyfilesworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.copyfilesworker_DoWork);
            this.copyfilesworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.copyfilesworker_ProgressChanged);
            this.copyfilesworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.copyfilesworker_RunWorkerCompleted);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(4, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(280, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by Robin (A FREE UTILITY BY SOFTLOGIC)";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.foldername);
            this.Controls.Add(this.folderbrowse);
            this.Controls.Add(this.xspfname);
            this.Controls.Add(this.xspfbrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XSPF PLAYLIST COPY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedialog;
        private System.Windows.Forms.FolderBrowserDialog folderdialog;
        private System.Windows.Forms.Button xspfbrowse;
        private System.Windows.Forms.Label xspfname;
        private System.Windows.Forms.Button folderbrowse;
        private System.Windows.Forms.Label foldername;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Label statuslbl;
        private System.ComponentModel.BackgroundWorker copyfilesworker;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

