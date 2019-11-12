using System.Drawing;
using System.Windows.Forms;

namespace ImagesAsLayers.Controls
{
  public partial class FolderSource : UserControl
  {
    public string Path { get => txtPath.Text; }
    public string Pattern { get => txtPattern.Text; }

    public FolderSource()
    {
      InitializeComponent();
    }

    private void btnBrowse_Click(object sender, System.EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      fbd.SelectedPath = txtPath.Text;
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        txtPath.Text = fbd.SelectedPath;
      }
    }

    internal Bitmap TryGetImage(int index)
    {
      if (txtPath.Text.Trim().Length == 0)
        return null;

      var files = System.IO.Directory.GetFiles(txtPath.Text, txtPattern.Text);
      if (index < 0 || index >= files.Length)
      {
        Program.Log($"No file at index {index} for path {txtPath.Text}\\{txtPattern.Text}.");
        return null;
      }

      string file = files[index];
      Image img = Image.FromFile(file);
      Bitmap ret = new Bitmap(img);
      return ret;
    }
  }
}
