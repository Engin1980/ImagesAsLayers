namespace ImagesAsLayers.Controls
{
  partial class MergeOperation
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.cmbOperation = new System.Windows.Forms.ComboBox();
      this.btnChange = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cmbOperation
      // 
      this.cmbOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOperation.FormattingEnabled = true;
      this.cmbOperation.Location = new System.Drawing.Point(4, 4);
      this.cmbOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cmbOperation.Name = "cmbOperation";
      this.cmbOperation.Size = new System.Drawing.Size(935, 24);
      this.cmbOperation.TabIndex = 0;
      // 
      // btnChange
      // 
      this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnChange.Location = new System.Drawing.Point(946, 3);
      this.btnChange.Name = "btnChange";
      this.btnChange.Size = new System.Drawing.Size(147, 25);
      this.btnChange.TabIndex = 1;
      this.btnChange.Text = "(change)";
      this.btnChange.UseVisualStyleBackColor = true;
      this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
      // 
      // MergeOperation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnChange);
      this.Controls.Add(this.cmbOperation);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "MergeOperation";
      this.Size = new System.Drawing.Size(1096, 32);
      this.Load += new System.EventHandler(this.MergeOperation_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbOperation;
    private System.Windows.Forms.Button btnChange;
  }
}
