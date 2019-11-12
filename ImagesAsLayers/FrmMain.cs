using ImagesAsLayers.Classes;
using ImagesAsLayers.Classes.BinaryOperations;
using System;
using System.Windows.Forms;

namespace ImagesAsLayers
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void RebuildList()
    {
      var q = Program.QueueList;

      lstItems.Items.Clear();
      foreach (var item in q)
      {
        string s = item.Title;
        lstItems.Items.Add(s);
      }
    }

    private void OpenEditorBy(IGetImage item)
    {
      Form frm;
      if (item is FileSource)
      {
        var tmp = new Forms.FrmFileSourceEditor
        {
          FileSource = item as FileSource
        };
        frm = tmp;
      }
      else if (item is FolderSource)
      {
        var tmp = new Forms.FrmFolderSourceEditor
        {
          FolderSource = item as FolderSource
        };
        frm = tmp;
      }
      else
      {
        throw new Exception("Unknown IGetImage implementation.");
      }

      frm.ShowDialog();
    }

    private void mnuQueueAddFile_Click(object sender, EventArgs e)
    {
      var q = new FileSource();
      Program.QueueList.Add(q);
      OpenEditorBy(q);
      RebuildList();
    }

    private void mnuQueueAddFolder_Click(object sender, EventArgs e)
    {
      var q = new FolderSource();
      Program.QueueList.Add(q);
      OpenEditorBy(q);
      RebuildList();
    }

    private void mnuQueueAddBinarySum_Click(object sender, EventArgs e)
    {
      var o = new SumOperator();
      var q = new MergeSource(o);
      Program.QueueList.Add(q);
      OpenEditorBy(q);
      RebuildList();
    }
  }
}
