namespace ImagesAsLayers
{
  partial class FrmMain
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
      this.pnlTop = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuQueueAddFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuQueueAddFolder = new System.Windows.Forms.ToolStripMenuItem();
      this.binaryOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuQueueAddBinarySum = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlBottom = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.lstItems = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.picImg = new System.Windows.Forms.PictureBox();
      this.pnlTop.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.menuStrip1);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1227, 66);
      this.pnlTop.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queueToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1227, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // queueToolStripMenuItem
      // 
      this.queueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
      this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
      this.queueToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.queueToolStripMenuItem.Text = "&Queue";
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQueueAddFile,
            this.mnuQueueAddFolder,
            this.binaryOperationToolStripMenuItem});
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.addToolStripMenuItem.Text = "Add";
      // 
      // mnuQueueAddFile
      // 
      this.mnuQueueAddFile.Name = "mnuQueueAddFile";
      this.mnuQueueAddFile.Size = new System.Drawing.Size(180, 22);
      this.mnuQueueAddFile.Text = "File";
      this.mnuQueueAddFile.Click += new System.EventHandler(this.mnuQueueAddFile_Click);
      // 
      // mnuQueueAddFolder
      // 
      this.mnuQueueAddFolder.Name = "mnuQueueAddFolder";
      this.mnuQueueAddFolder.Size = new System.Drawing.Size(180, 22);
      this.mnuQueueAddFolder.Text = "Folder";
      this.mnuQueueAddFolder.Click += new System.EventHandler(this.mnuQueueAddFolder_Click);
      // 
      // binaryOperationToolStripMenuItem
      // 
      this.binaryOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQueueAddBinarySum});
      this.binaryOperationToolStripMenuItem.Name = "binaryOperationToolStripMenuItem";
      this.binaryOperationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.binaryOperationToolStripMenuItem.Text = "Binary operation";
      // 
      // mnuQueueAddBinarySum
      // 
      this.mnuQueueAddBinarySum.Name = "mnuQueueAddBinarySum";
      this.mnuQueueAddBinarySum.Size = new System.Drawing.Size(180, 22);
      this.mnuQueueAddBinarySum.Text = "Sum";
      this.mnuQueueAddBinarySum.Click += new System.EventHandler(this.mnuQueueAddBinarySum_Click);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlBottom.Location = new System.Drawing.Point(0, 569);
      this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
      this.pnlBottom.Name = "pnlBottom";
      this.pnlBottom.Size = new System.Drawing.Size(1227, 50);
      this.pnlBottom.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 66);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.lstItems);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.picImg);
      this.splitContainer1.Size = new System.Drawing.Size(1227, 503);
      this.splitContainer1.SplitterDistance = 222;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 1;
      // 
      // lstItems
      // 
      this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstItems.FormattingEnabled = true;
      this.lstItems.ItemHeight = 16;
      this.lstItems.Location = new System.Drawing.Point(0, 36);
      this.lstItems.Name = "lstItems";
      this.lstItems.Size = new System.Drawing.Size(222, 467);
      this.lstItems.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(222, 36);
      this.panel1.TabIndex = 0;
      // 
      // picImg
      // 
      this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picImg.Location = new System.Drawing.Point(0, 0);
      this.picImg.Margin = new System.Windows.Forms.Padding(4);
      this.picImg.Name = "picImg";
      this.picImg.Size = new System.Drawing.Size(1000, 503);
      this.picImg.TabIndex = 0;
      this.picImg.TabStop = false;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1227, 619);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.pnlBottom);
      this.Controls.Add(this.pnlTop);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox picImg;
    private System.Windows.Forms.ListBox lstItems;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuQueueAddFile;
    private System.Windows.Forms.ToolStripMenuItem mnuQueueAddFolder;
    private System.Windows.Forms.ToolStripMenuItem binaryOperationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuQueueAddBinarySum;
  }
}

