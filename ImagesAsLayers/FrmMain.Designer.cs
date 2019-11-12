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
      this.btnRedraw = new System.Windows.Forms.Button();
      this.nudIndex = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.srcC = new ImagesAsLayers.Controls.FolderSource();
      this.mergeBC = new ImagesAsLayers.Controls.MergeOperation();
      this.srcB = new ImagesAsLayers.Controls.FolderSource();
      this.mergeAB = new ImagesAsLayers.Controls.MergeOperation();
      this.srcA = new ImagesAsLayers.Controls.FolderSource();
      this.pnlBottom = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.picImg = new System.Windows.Forms.PictureBox();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnRedraw);
      this.pnlTop.Controls.Add(this.nudIndex);
      this.pnlTop.Controls.Add(this.label1);
      this.pnlTop.Controls.Add(this.srcC);
      this.pnlTop.Controls.Add(this.mergeBC);
      this.pnlTop.Controls.Add(this.srcB);
      this.pnlTop.Controls.Add(this.mergeAB);
      this.pnlTop.Controls.Add(this.srcA);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1227, 214);
      this.pnlTop.TabIndex = 0;
      // 
      // btnRedraw
      // 
      this.btnRedraw.Location = new System.Drawing.Point(216, 179);
      this.btnRedraw.Name = "btnRedraw";
      this.btnRedraw.Size = new System.Drawing.Size(95, 23);
      this.btnRedraw.TabIndex = 9;
      this.btnRedraw.Text = "Redraw";
      this.btnRedraw.UseVisualStyleBackColor = true;
      this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
      // 
      // nudIndex
      // 
      this.nudIndex.Location = new System.Drawing.Point(90, 180);
      this.nudIndex.Name = "nudIndex";
      this.nudIndex.Size = new System.Drawing.Size(120, 23);
      this.nudIndex.TabIndex = 8;
      this.nudIndex.ValueChanged += new System.EventHandler(this.nudIndex_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 182);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 16);
      this.label1.TabIndex = 7;
      this.label1.Text = "Index:";
      // 
      // srcC
      // 
      this.srcC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.srcC.Location = new System.Drawing.Point(13, 147);
      this.srcC.Margin = new System.Windows.Forms.Padding(4);
      this.srcC.Name = "srcC";
      this.srcC.Size = new System.Drawing.Size(1201, 31);
      this.srcC.TabIndex = 6;
      // 
      // mergeBC
      // 
      this.mergeBC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.mergeBC.Location = new System.Drawing.Point(160, 107);
      this.mergeBC.Margin = new System.Windows.Forms.Padding(4);
      this.mergeBC.Name = "mergeBC";
      this.mergeBC.Size = new System.Drawing.Size(1054, 32);
      this.mergeBC.TabIndex = 5;
      // 
      // srcB
      // 
      this.srcB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.srcB.Location = new System.Drawing.Point(13, 77);
      this.srcB.Margin = new System.Windows.Forms.Padding(4);
      this.srcB.Name = "srcB";
      this.srcB.Size = new System.Drawing.Size(1201, 31);
      this.srcB.TabIndex = 4;
      // 
      // mergeAB
      // 
      this.mergeAB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.mergeAB.Location = new System.Drawing.Point(160, 41);
      this.mergeAB.Margin = new System.Windows.Forms.Padding(4);
      this.mergeAB.Name = "mergeAB";
      this.mergeAB.Size = new System.Drawing.Size(1054, 32);
      this.mergeAB.TabIndex = 3;
      // 
      // srcA
      // 
      this.srcA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.srcA.Location = new System.Drawing.Point(13, 13);
      this.srcA.Margin = new System.Windows.Forms.Padding(4);
      this.srcA.Name = "srcA";
      this.srcA.Size = new System.Drawing.Size(1201, 31);
      this.srcA.TabIndex = 2;
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
      this.splitContainer1.Location = new System.Drawing.Point(0, 214);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.picImg);
      this.splitContainer1.Size = new System.Drawing.Size(1227, 355);
      this.splitContainer1.SplitterDistance = 25;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 1;
      // 
      // picImg
      // 
      this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picImg.Location = new System.Drawing.Point(0, 0);
      this.picImg.Margin = new System.Windows.Forms.Padding(4);
      this.picImg.Name = "picImg";
      this.picImg.Size = new System.Drawing.Size(1197, 355);
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
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
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
    private System.Windows.Forms.PictureBox picImg;
    private Controls.FolderSource srcA;
    private Controls.FolderSource srcC;
    private Controls.MergeOperation mergeBC;
    private Controls.FolderSource srcB;
    private Controls.MergeOperation mergeAB;
    private System.Windows.Forms.Button btnRedraw;
    private System.Windows.Forms.NumericUpDown nudIndex;
    private System.Windows.Forms.Label label1;
  }
}

