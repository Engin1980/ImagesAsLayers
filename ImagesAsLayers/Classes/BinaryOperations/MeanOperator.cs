using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesAsLayers.Classes.BinaryOperations
{
  class MeanOperator : AbstractBinaryOperator
  {
    public override string Title => "Mean";

    public override Bitmap Merge(Bitmap a, Bitmap b)
    {
      Bitmap ret = base.Apply(a, b, (x, y) => (x + y) / 2);
      return ret;
    }
  }
}
