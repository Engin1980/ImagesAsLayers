using ImagesAsLayers.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImagesAsLayers
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void RedrawImage()
    {
      this.Cursor = Cursors.WaitCursor;
      Image ret = GetResultImage((int) nudIndex.Value);
      if (ret != null)
        picImg.Image = ret;
      this.Cursor = Cursors.Default;
    }

    private Bitmap GetResultImage(int index)
    {
      Bitmap a = srcA.TryGetImage(index);
      Bitmap b = srcB.TryGetImage(index);
      Bitmap c = srcC.TryGetImage(index);
      IBinaryOperator operAB = mergeAB.TryGetOperator();
      IBinaryOperator operBC = mergeBC.TryGetOperator();
      Bitmap ret = null;

      if (a == null) return ret;

      ret = a;
      if (b == null) return ret;
      if (operAB == null) return ret;
      ret = operAB.Merge(ret, b);

      if (c == null) return ret;
      if (operBC == null) return ret;
      ret = operBC.Merge(ret, c);

      return ret;
    }

    private void btnRedraw_Click(object sender, EventArgs e)
    {
      RedrawImage();
    }

    private void nudIndex_ValueChanged(object sender, EventArgs e)
    {
      RedrawImage();
    }
  }
}
