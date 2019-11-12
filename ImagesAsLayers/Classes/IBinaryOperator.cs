using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesAsLayers.Classes
{
  public interface IBinaryOperator
  {    
    Bitmap Merge(Bitmap a, Bitmap b);
    string Title { get; }
  }
}
