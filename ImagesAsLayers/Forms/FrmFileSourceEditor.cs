using ImagesAsLayers.Classes;
using System;
using System.Windows.Forms;

namespace ImagesAsLayers.Forms
{
  public partial class FrmFileSourceEditor : Form
  {

    private FileSource _FileSource;
    public FileSource FileSource
    {
      get => _FileSource; set
      {
        _FileSource = value;
        txtFile.Text = _FileSource.FileName;
      }
    }

    public FrmFileSourceEditor()
    {
      InitializeComponent();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.FileName = FileSource.FileName;
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        txtFile.Text = ofd.FileName;

      }
    }

    private void txtFile_TextChanged(object sender, EventArgs e)
    {
      FileSource.FileName = txtFile.Text;
    }
  }
}
