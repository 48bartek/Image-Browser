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
            this.ButtonSetNewPath = new System.Windows.Forms.Button();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.TBWebsite = new System.Windows.Forms.TextBox();
            this.GBTo = new System.Windows.Forms.GroupBox();
            this.PBPreviewTo = new System.Windows.Forms.PictureBox();
            this.TVTo = new System.Windows.Forms.TreeView();
            this.GBFrom = new System.Windows.Forms.GroupBox();
            this.TVFrom = new System.Windows.Forms.TreeView();
            this.PBPreviewFrom = new System.Windows.Forms.PictureBox();
            this.PBCurrent = new System.Windows.Forms.PictureBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FBDNewTreePath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreviewTo)).BeginInit();
            this.GBFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPreviewFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrent)).BeginInit();
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
            this.tabPage1.Controls.Add(this.ButtonSetNewPath);
            this.tabPage1.Controls.Add(this.ButtonGo);
            this.tabPage1.Controls.Add(this.TBWebsite);
            this.tabPage1.Controls.Add(this.GBTo);
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
            this.ButtonSave.Location = new System.Drawing.Point(820, 309);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 75);
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
            this.LabelFileName.MaximumSize = new System.Drawing.Size(867, 0);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(0, 25);
            this.LabelFileName.TabIndex = 13;
            // 
            // ButtonSetNewPath
            // 
            this.ButtonSetNewPath.Location = new System.Drawing.Point(820, 6);
            this.ButtonSetNewPath.Name = "ButtonSetNewPath";
            this.ButtonSetNewPath.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetNewPath.TabIndex = 12;
            this.ButtonSetNewPath.Text = "Go to...";
            this.ButtonSetNewPath.UseVisualStyleBackColor = true;
            this.ButtonSetNewPath.Click += new System.EventHandler(this.ButtonSetNewPath_Click);
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
            // GBTo
            // 
            this.GBTo.Controls.Add(this.PBPreviewTo);
            this.GBTo.Controls.Add(this.TVTo);
            this.GBTo.Location = new System.Drawing.Point(901, 334);
            this.GBTo.Name = "GBTo";
            this.GBTo.Size = new System.Drawing.Size(567, 320);
            this.GBTo.TabIndex = 8;
            this.GBTo.TabStop = false;
            this.GBTo.Text = "To";
            // 
            // PBPreviewTo
            // 
            this.PBPreviewTo.Location = new System.Drawing.Point(242, 19);
            this.PBPreviewTo.Name = "PBPreviewTo";
            this.PBPreviewTo.Size = new System.Drawing.Size(317, 294);
            this.PBPreviewTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPreviewTo.TabIndex = 6;
            this.PBPreviewTo.TabStop = false;
            // 
            // TVTo
            // 
            this.TVTo.HideSelection = false;
            this.TVTo.Location = new System.Drawing.Point(6, 19);
            this.TVTo.Name = "TVTo";
            this.TVTo.Size = new System.Drawing.Size(233, 294);
            this.TVTo.TabIndex = 5;
            // 
            // GBFrom
            // 
            this.GBFrom.Controls.Add(this.TVFrom);
            this.GBFrom.Controls.Add(this.PBPreviewFrom);
            this.GBFrom.Location = new System.Drawing.Point(901, 8);
            this.GBFrom.Name = "GBFrom";
            this.GBFrom.Size = new System.Drawing.Size(567, 320);
            this.GBFrom.TabIndex = 7;
            this.GBFrom.TabStop = false;
            this.GBFrom.Text = "From";
            // 
            // TVFrom
            // 
            this.TVFrom.Location = new System.Drawing.Point(6, 19);
            this.TVFrom.Name = "TVFrom";
            this.TVFrom.Size = new System.Drawing.Size(233, 291);
            this.TVFrom.TabIndex = 3;
            // 
            // PBPreviewFrom
            // 
            this.PBPreviewFrom.Location = new System.Drawing.Point(242, 16);
            this.PBPreviewFrom.Margin = new System.Windows.Forms.Padding(0);
            this.PBPreviewFrom.MaximumSize = new System.Drawing.Size(500, 500);
            this.PBPreviewFrom.Name = "PBPreviewFrom";
            this.PBPreviewFrom.Size = new System.Drawing.Size(317, 294);
            this.PBPreviewFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPreviewFrom.TabIndex = 4;
            this.PBPreviewFrom.TabStop = false;
            // 
            // PBCurrent
            // 
            this.PBCurrent.Location = new System.Drawing.Point(8, 59);
            this.PBCurrent.Name = "PBCurrent";
            this.PBCurrent.Size = new System.Drawing.Size(806, 867);
            this.PBCurrent.TabIndex = 2;
            this.PBCurrent.TabStop = false;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(820, 105);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 75);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = ">>";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(820, 205);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(75, 75);
            this.ButtonPrev.TabIndex = 0;
            this.ButtonPrev.Text = "<<";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1476, 932);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get Images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBTo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPreviewTo)).EndInit();
            this.GBFrom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBPreviewFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrent)).EndInit();
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
        private System.Windows.Forms.PictureBox PBPreviewFrom;
        private System.Windows.Forms.TreeView TVTo;
        private System.Windows.Forms.GroupBox GBFrom;
        private System.Windows.Forms.GroupBox GBTo;
        private System.Windows.Forms.PictureBox PBPreviewTo;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.TextBox TBWebsite;
        private System.Windows.Forms.Button ButtonSetNewPath;
        private System.Windows.Forms.FolderBrowserDialog FBDNewTreePath;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Button ButtonSave;
    }
}

