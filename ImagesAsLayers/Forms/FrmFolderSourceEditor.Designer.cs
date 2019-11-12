namespace ImagesAsLayers.Forms
{
  partial class FrmFolderSourceEditor
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
      this.btnBrowse = new System.Windows.Forms.Button();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(888, 12);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(75, 23);
      this.btnBrowse.TabIndex = 5;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // txtFile
      // 
      this.txtFile.Location = new System.Drawing.Point(61, 12);
      this.txtFile.Name = "txtFile";
      this.txtFile.Size = new System.Drawing.Size(821, 23);
      this.txtFile.TabIndex = 4;
      this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 15);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "File:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 16);
      this.label2.TabIndex = 6;
      this.label2.Text = "Pattern";
      // 
      // txtPattern
      // 
      this.txtPattern.Location = new System.Drawing.Point(135, 41);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Size = new System.Drawing.Size(219, 23);
      this.txtPattern.TabIndex = 7;
      this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
      // 
      // FrmFolderSourceEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(981, 76);
      this.Controls.Add(this.txtPattern);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtFile);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FrmFolderSourceEditor";
      this.Text = "FrmFolderSourceEditor";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPattern;
  }
}