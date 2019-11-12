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
    private IGetImage a;
    private IGetImage b;
    public IBinaryOperator Operator { get; set; }

    int FirstRelativeIndexShift { get; set; } = -2;
    int SecondRelativeIndexShift { get; set; } = -1;

    public string Title => Operator.Title;

    public MergeSource(IBinaryOperator binaryOperator)
    {
      this.Operator = binaryOperator;
    }

    public void UpdateMapping(List<IGetImage> lst)
    {
      int myIndex = lst.IndexOf(this);
      this.a = lst[myIndex + FirstRelativeIndexShift];
      this.b = lst[myIndex + SecondRelativeIndexShift];
    }

    public Bitmap GetImage(int index)
    {
      Bitmap bmpA = this.a.GetImage(index);
      Bitmap bmpB = this.b.GetImage(index);
      Bitmap res = this.Operator.Merge(bmpA, bmpB);
      return res;
    }
  }
}
