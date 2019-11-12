using System;
using System.Drawing;

namespace ImagesAsLayers.Classes
{
  public class FileSource : ISource
  {
    public string FileName { get; set; }

    public string Title => "{file} " + this.FileName;

    public Bitmap GetImage(int index)
    {
      Image img = Image.FromFile(this.FileName);
      Bitmap ret = new Bitmap(img);
      return ret;
    }
  }
}
