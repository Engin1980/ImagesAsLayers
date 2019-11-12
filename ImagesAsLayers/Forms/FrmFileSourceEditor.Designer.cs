namespace ImagesAsLayers.Forms
{
  partial class FrmFileSourceEditor
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "File:";
      // 
      // txtFile
      // 
      this.txtFile.Location = new System.Drawing.Point(56, 6);
      this.txtFile.Name = "txtFile";
      this.txtFile.Size = new System.Drawing.Size(821, 23);
      this.txtFile.TabIndex = 1;
      this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(883, 6);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(75, 23);
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // FrmFileSourceEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 41);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtFile);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FrmFileSourceEditor";
      this.Text = "FrmFileSourceEditor";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Button btnBrowse;
  }
}