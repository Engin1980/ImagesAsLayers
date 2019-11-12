using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesAsLayers.Classes
{
  public class FolderSource : ISource
  {
    public string FolderName { get; set; }
    public string Pattern { get; set; } = "*.jpg";

    public string Title => $"{{folder}} {this.FolderName}\\{this.Pattern}";

    public Bitmap GetImage(int index)
    {
      var files = System.IO.Directory.GetFiles(this.FolderName, this.Pattern);
      var file = files[index];

      var img = Image.FromFile(file);
      var ret = new Bitmap(img);
      return ret;
    }
  }
}
