using System;
using System.Drawing;

namespace ImagesAsLayers.Classes.BinaryOperations
{
  public abstract class AbstractBinaryOperator : IBinaryOperator
  {
    public int FirstRelativeIndexShift { get; set; } = -2;
    public int SecondRelativeIndexShift { get; set; } = -1;

    public string IndicesShifts { get => $"(of {FirstRelativeIndexShift},{SecondRelativeIndexShift}"; }

    public abstract string Title { get; }

    public abstract Bitmap Merge(Bitmap a, Bitmap b);

    protected Bitmap Apply(Bitmap imgA, Bitmap imgB, Func<int, int, int> operation)
    {
      Color colorOperation(Color p, Color q)
      {
        int r = operation(p.R, q.R);
        int g = operation(p.G, q.G);
        int b = operation(p.B, q.B);

        Color c = Color.FromArgb(r, g, b);
        return c;
      }

      Bitmap ret = Apply(imgA, imgB, colorOperation);
      return ret;
    }

    protected Bitmap Apply(Bitmap a, Bitmap b, Func<Color, Color, Color> operation)
    {
      Bitmap ret = new Bitmap(a);
      for (int i = 0; i < a.Width; i++)
      {
        for (int j = 0; j < a.Height; j++)
        {
          Color p = a.GetPixel(i, j);
          Color q = b.GetPixel(i, j);
          Color r = operation(p, q);

          ret.SetPixel(i, j, r);
        }
      }
      return ret;
    }
  }
}
