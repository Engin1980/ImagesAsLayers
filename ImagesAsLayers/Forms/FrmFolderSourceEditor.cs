using ImagesAsLayers.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesAsLayers.Forms
{
  public partial class FrmFolderSourceEditor : Form
  {
    private FolderSource _FolderSource;
    public FolderSource FolderSource
    {
      get => _FolderSource; set
      {
        _FolderSource = value;
        txtFile.Text = _FolderSource.FolderName;
        txtPattern.Text = _FolderSource.Pattern;
      }
    }


    public FrmFolderSourceEditor()
    {
      InitializeComponent();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      fbd.SelectedPath = FolderSource.FolderName;
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        txtFile.Text = fbd.SelectedPath;
      }
    }

    private void txtFile_TextChanged(object sender, EventArgs e)
    {
      FolderSource.FolderName = txtFile.Text;
    }

    private void txtPattern_TextChanged(object sender, EventArgs e)
    {
      FolderSource.Pattern = txtPattern.Text;
    }
  }
}
