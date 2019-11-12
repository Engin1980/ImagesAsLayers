using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesAsLayers.Forms
{
  public partial class FrmProperties : Form
  {
    private object _Source;
    public object Source { get => _Source; set
      {
        this._Source = value;
        this.grd.SelectedObject = value;
      }
    }

    public FrmProperties()
    {
      InitializeComponent();
    }
  }
}
