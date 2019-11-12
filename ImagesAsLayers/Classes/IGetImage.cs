using System.Drawing;

namespace ImagesAsLayers.Classes
{
  public interface IGetImage
  {
    Bitmap GetImage(int index);

    string Title { get; }
  }
}
