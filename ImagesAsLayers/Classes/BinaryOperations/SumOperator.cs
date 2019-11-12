using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesAsLayers.Classes.BinaryOperations
{
  public class SumOperator : AbstractBinaryOperator
  {
    public override string Title => $"Sum {base.IndicesShifts}";
    public bool Clip { get; set; }

    public override Bitmap Merge(Bitmap a, Bitmap b)
    {
      Bitmap ret = base.Apply(a, b, (x, y) => x + y);
      return ret;
    }
  }
}
