using System;
using System.Drawing;

namespace ImagesAsLayers.Classes.BinaryOperations
{
  class OverlayOperator : AbstractBinaryOperator
  {
    private double _Level = .5;
    public double Level
    {
      get => _Level; set
      {
        if (value < 0)
          _Level = 0;
        else if (value > 1)
          _Level = 1;
        else
          _Level = value;
      }
    }

    public override string Title => "Overlay";

    public override Bitmap Merge(Bitmap a, Bitmap b)
    {
      double rest = 1 - _Level;
      return base.Apply(a, b, (x, y) => (int) ((rest * x + _Level * y) / 2d));
    }
  }
}
