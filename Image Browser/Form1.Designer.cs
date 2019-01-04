namespace Image_Browser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.TBWebsite = new System.Windows.Forms.TextBox();
            this.GBFrom = new System.Windows.Forms.GroupBox();
            this.papapanel = new System.Windows.Forms.Panel();
            this.TVTo = new System.Windows.Forms.TreeView();
            this.ButtonTo = new System.Windows.Forms.Button();
            this.ButtonSetNewPath = new System.Windows.Forms.Button();
            this.TVFrom = new System.Windows.Forms.TreeView();
            this.PBCurrent = new System.Windows.Forms.PictureBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FBDNewTreePath = new System.Windows.Forms.FolderBrowserDialog();
            this.FBDNewTreePathTo = new System.Windows.Forms.FolderBrowserDialog();
            this.DUDLower = new System.Windows.Forms.DomainUpDown();
            this.DUDUpper = new System.Windows.Forms.DomainUpDown();
            this.DUDMargin = new System.Windows.Forms.DomainUpDown();
            this.TBAdress1 = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.TBAdress2 = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrent)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1484, 958);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonSave);
            this.tabPage1.Controls.Add(this.LabelFileName);
            this.tabPage1.Controls.Add(this.ButtonGo);
            this.tabPage1.Controls.Add(this.TBWebsite);
            this.tabPage1.Controls.Add(this.GBFrom);
            this.tabPage1.Controls.Add(this.PBCurrent);
            this.tabPage1.Controls.Add(this.ButtonNext);
            this.tabPage1.Controls.Add(this.ButtonPrev);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1476, 932);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preview Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(787, 263);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(67, 75);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFileName.Location = new System.Drawing.Point(8, 31);
            this.LabelFileName.MaximumSize = new System.Drawing.Size(750, 0);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 25);
            this.LabelFileName.TabIndex = 13;
            // 
            // ButtonGo
            // 
            this.ButtonGo.Location = new System.Drawing.Point(739, 6);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(75, 23);
            this.ButtonGo.TabIndex = 10;
            this.ButtonGo.Text = "Fetch!";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // TBWebsite
            // 
            this.TBWebsite.Location = new System.Drawing.Point(9, 8);
            this.TBWebsite.Name = "TBWebsite";
            this.TBWebsite.Size = new System.Drawing.Size(724, 20);
            this.TBWebsite.TabIndex = 9;
            // 
            // GBFrom
            // 
            this.GBFrom.Controls.Add(this.papapanel);
            this.GBFrom.Controls.Add(this.TVTo);
            this.GBFrom.Controls.Add(this.ButtonTo);
            this.GBFrom.Controls.Add(this.ButtonSetNewPath);
            this.GBFrom.Controls.Add(this.TVFrom);
            this.GBFrom.Location = new System.Drawing.Point(860, 33);
            this.GBFrom.Name = "GBFrom";
            this.GBFrom.Size = new System.Drawing.Size(605, 698);
            this.GBFrom.TabIndex = 7;
            this.GBFrom.TabStop = false;
            this.GBFrom.Text = "From";
            // 
            // papapanel
            // 
            this.papapanel.AutoScroll = true;
            this.papapanel.BackColor = System.Drawing.Color.Transparent;
            this.papapanel.Location = new System.Drawing.Point(191, 12);
            this.papapanel.Name = "papapanel";
            this.papapanel.Size = new System.Drawing.Size(405, 679);
            this.papapanel.TabIndex = 0;
            // 
            // TVTo
            // 
            this.TVTo.HideSelection = false;
            this.TVTo.Location = new System.Drawing.Point(6, 397);
            this.TVTo.Name = "TVTo";
            this.TVTo.Size = new System.Drawing.Size(179, 294);
            this.TVTo.TabIndex = 5;
            // 
            // ButtonTo
            // 
            this.ButtonTo.Location = new System.Drawing.Point(6, 368);
            this.ButtonTo.Name = "ButtonTo";
            this.ButtonTo.Size = new System.Drawing.Size(75, 23);
            this.ButtonTo.TabIndex = 7;
            this.ButtonTo.Text = "To...";
            this.ButtonTo.UseVisualStyleBackColor = true;
            this.ButtonTo.Click += new System.EventHandler(this.ButtonTo_Click);
            // 
            // ButtonSetNewPath
            // 
            this.ButtonSetNewPath.Location = new System.Drawing.Point(6, 19);
            this.ButtonSetNewPath.Name = "ButtonSetNewPath";
            this.ButtonSetNewPath.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetNewPath.TabIndex = 12;
            this.ButtonSetNewPath.Text = "Go to...";
            this.ButtonSetNewPath.UseVisualStyleBackColor = true;
            this.ButtonSetNewPath.Click += new System.EventHandler(this.ButtonSetNewPath_Click);
            // 
            // TVFrom
            // 
            this.TVFrom.Location = new System.Drawing.Point(6, 48);
            this.TVFrom.Name = "TVFrom";
            this.TVFrom.Size = new System.Drawing.Size(179, 291);
            this.TVFrom.TabIndex = 3;
            // 
            // PBCurrent
            // 
            this.PBCurrent.Location = new System.Drawing.Point(8, 59);
            this.PBCurrent.Name = "PBCurrent";
            this.PBCurrent.Size = new System.Drawing.Size(773, 867);
            this.PBCurrent.TabIndex = 2;
            this.PBCurrent.TabStop = false;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(787, 59);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(67, 75);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = ">>";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(787, 159);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(67, 75);
            this.ButtonPrev.TabIndex = 0;
            this.ButtonPrev.Text = "<<";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonStart);
            this.tabPage2.Controls.Add(this.TBAdress2);
            this.tabPage2.Controls.Add(this.L1);
            this.tabPage2.Controls.Add(this.TBAdress1);
            this.tabPage2.Controls.Add(this.DUDMargin);
            this.tabPage2.Controls.Add(this.DUDUpper);
            this.tabPage2.Controls.Add(this.DUDLower);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1476, 932);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get Images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DUDLower
            // 
            this.DUDLower.Location = new System.Drawing.Point(56, 77);
            this.DUDLower.Name = "DUDLower";
            this.DUDLower.Size = new System.Drawing.Size(120, 20);
            this.DUDLower.TabIndex = 0;
            this.DUDLower.Text = "Lower limit";
            // 
            // DUDUpper
            // 
            this.DUDUpper.Location = new System.Drawing.Point(194, 77);
            this.DUDUpper.Name = "DUDUpper";
            this.DUDUpper.Size = new System.Drawing.Size(120, 20);
            this.DUDUpper.TabIndex = 1;
            this.DUDUpper.Text = "Upper limit";
            // 
            // DUDMargin
            // 
            this.DUDMargin.Location = new System.Drawing.Point(334, 77);
            this.DUDMargin.Name = "DUDMargin";
            this.DUDMargin.Size = new System.Drawing.Size(120, 20);
            this.DUDMargin.TabIndex = 2;
            this.DUDMargin.Text = "Margin";
            // 
            // TBAdress1
            // 
            this.TBAdress1.Location = new System.Drawing.Point(56, 160);
            this.TBAdress1.Name = "TBAdress1";
            this.TBAdress1.Size = new System.Drawing.Size(398, 20);
            this.TBAdress1.TabIndex = 3;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(460, 163);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(39, 13);
            this.L1.TabIndex = 4;
            this.L1.Text = "Margin";
            // 
            // TBAdress2
            // 
            this.TBAdress2.Location = new System.Drawing.Point(496, 160);
            this.TBAdress2.Name = "TBAdress2";
            this.TBAdress2.Size = new System.Drawing.Size(133, 20);
            this.TBAdress2.TabIndex = 5;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(239, 230);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBFrom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox PBCurrent;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView TVFrom;
        private System.Windows.Forms.GroupBox GBFrom;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.TextBox TBWebsite;
        private System.Windows.Forms.Button ButtonSetNewPath;
        private System.Windows.Forms.FolderBrowserDialog FBDNewTreePath;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonTo;
        private System.Windows.Forms.FolderBrowserDialog FBDNewTreePathTo;
        private System.Windows.Forms.TreeView TVTo;
        public System.Windows.Forms.Panel papapanel;
        private System.Windows.Forms.DomainUpDown DUDMargin;
        private System.Windows.Forms.DomainUpDown DUDUpper;
        private System.Windows.Forms.DomainUpDown DUDLower;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TBAdress2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox TBAdress1;
    }
}

