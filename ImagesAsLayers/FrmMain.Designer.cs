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
      this.pnlBottom = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.lstItems = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAddBinaryOperator = new System.Windows.Forms.Button();
      this.btnAddFolder = new System.Windows.Forms.Button();
      this.btnAddFile = new System.Windows.Forms.Button();
      this.picImg = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1227, 50);
      this.pnlTop.TabIndex = 0;
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
      this.splitContainer1.Location = new System.Drawing.Point(0, 50);
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
      this.splitContainer1.Size = new System.Drawing.Size(1227, 519);
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
      this.lstItems.Size = new System.Drawing.Size(222, 483);
      this.lstItems.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnAddBinaryOperator);
      this.panel1.Controls.Add(this.btnAddFolder);
      this.panel1.Controls.Add(this.btnAddFile);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(222, 36);
      this.panel1.TabIndex = 0;
      // 
      // btnAddBinaryOperator
      // 
      this.btnAddBinaryOperator.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnAddBinaryOperator.Location = new System.Drawing.Point(98, 0);
      this.btnAddBinaryOperator.Margin = new System.Windows.Forms.Padding(4);
      this.btnAddBinaryOperator.Name = "btnAddBinaryOperator";
      this.btnAddBinaryOperator.Size = new System.Drawing.Size(49, 36);
      this.btnAddBinaryOperator.TabIndex = 2;
      this.btnAddBinaryOperator.Text = "Oper";
      this.btnAddBinaryOperator.UseVisualStyleBackColor = true;
      // 
      // btnAddFolder
      // 
      this.btnAddFolder.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnAddFolder.Location = new System.Drawing.Point(49, 0);
      this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
      this.btnAddFolder.Name = "btnAddFolder";
      this.btnAddFolder.Size = new System.Drawing.Size(49, 36);
      this.btnAddFolder.TabIndex = 1;
      this.btnAddFolder.Text = "Fldr";
      this.btnAddFolder.UseVisualStyleBackColor = true;
      this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
      // 
      // btnAddFile
      // 
      this.btnAddFile.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnAddFile.Location = new System.Drawing.Point(0, 0);
      this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
      this.btnAddFile.Name = "btnAddFile";
      this.btnAddFile.Size = new System.Drawing.Size(49, 36);
      this.btnAddFile.TabIndex = 0;
      this.btnAddFile.Text = "File";
      this.btnAddFile.UseVisualStyleBackColor = true;
      this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
      // 
      // picImg
      // 
      this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picImg.Location = new System.Drawing.Point(0, 0);
      this.picImg.Margin = new System.Windows.Forms.Padding(4);
      this.picImg.Name = "picImg";
      this.picImg.Size = new System.Drawing.Size(1000, 519);
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
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox picImg;
    private System.Windows.Forms.Button btnAddFile;
    private System.Windows.Forms.Button btnAddBinaryOperator;
    private System.Windows.Forms.Button btnAddFolder;
    private System.Windows.Forms.ListBox lstItems;
  }
}

