using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesAsLayers.Classes
{
  public class MergeSource : IGetImage
  {
    public IGetImage A { get; set; }
    public IGetImage B { get; set; }
    public IBinaryOperator Operator { get; set; }

    public string Title => Operator.Title;

    public Bitmap GetImage(int index)
    {
      Bitmap bmpA = this.A.GetImage(index);
      Bitmap bmpB = this.B.GetImage(index);
      Bitmap res = this.Operator.Merge(bmpA, bmpB);
      return res;
    }
  }
}
