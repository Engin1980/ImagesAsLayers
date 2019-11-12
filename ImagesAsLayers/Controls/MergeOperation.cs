using ImagesAsLayers.Classes;
using ImagesAsLayers.Classes.BinaryOperations;
using ImagesAsLayers.Forms;
using System;
using System.Windows.Forms;

namespace ImagesAsLayers.Controls
{
  public partial class MergeOperation : UserControl
  {
    public class ComboBoxItem
    {
      public ComboBoxItem(IBinaryOperator oper)
      {
        Operator = oper;
      }
      public IBinaryOperator Operator { get; }
      public override string ToString()
      {
        return Operator.Title;
      }
    }

    public MergeOperation()
    {
      InitializeComponent();
    }

    private void btnChange_Click(object sender, EventArgs e)
    {
      ComboBoxItem cbi = cmbOperation.SelectedItem as ComboBoxItem;
      FrmProperties frm = new FrmProperties();
      frm.Source = cbi.Operator;
      frm.ShowDialog();
    }

    internal IBinaryOperator TryGetOperator()
    {
      if (cmbOperation.SelectedIndex < 0) return null;
      else return (cmbOperation.SelectedItem as ComboBoxItem).Operator;
    }

    private void MergeOperation_Load(object sender, EventArgs e)
    {
      cmbOperation.Items.Clear();
      cmbOperation.Items.Add(
        new ComboBoxItem(new SumOperator()));
      cmbOperation.Items.Add(
        new ComboBoxItem(new MeanOperator()));
      cmbOperation.Items.Add(
        new ComboBoxItem(new OverlayOperator()));
    }
  }
}
