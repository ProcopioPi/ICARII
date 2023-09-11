using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MasterHound
{
    public class MyHandlers
    {
        delegate void ShowControlHandler(Control ctrl);
        public static void ShowControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new ShowControlHandler(ShowControl), ctrl);
                return;
            }
            else
                ctrl.Show();
        }

        delegate void HideControlHandler(Control ctrl);
        public static void HideControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new HideControlHandler(HideControl), ctrl);
                return;
            }
            else
                ctrl.Hide();
        }

        delegate void SetProgressHandler(ProgressBar ctrl, double value);
        public static void SetProgress(ProgressBar ctrl, double value)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SetProgressHandler(SetProgress), ctrl, value);
                return;
            }
            else
                ctrl.Value = (int)(value * 100);
        }

        delegate void AddTreeNodeHandler(TreeView ctrl, TreeNode node);
        public static void AddTreeNode(TreeView ctrl, TreeNode node)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new AddTreeNodeHandler(AddTreeNode), ctrl, node);
                return;
            }

            try
            {
                ctrl.Nodes.Add(node);
            }
            catch (Exception)
            {
                //Console.WriteLine(ex);
            }
        }

        delegate void SelectFirstTreeNodeHandler(TreeView ctrl);
        public static void SelectFirstNode(TreeView ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SelectFirstTreeNodeHandler(SelectFirstNode), ctrl);
                return;
            }

            try
            {
                ctrl.SelectedNode = ctrl.Nodes[0];
                ctrl.Focus();
            }
            catch (Exception)
            {
                //Console.WriteLine(ex);
            }
        }

        delegate void ClearTreeNodesHandler(TreeView ctrl);
        public static void ClearTreeNodes(TreeView ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new ClearTreeNodesHandler(ClearTreeNodes), ctrl);
                return;
            }

            try
            {
                ctrl.Nodes.Clear();
            }
            catch (Exception )
            {
            }
        }

        delegate void CTRLRefreshHandler(Control ctrl);
        public static void ControlRefresh(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new CTRLRefreshHandler(ControlRefresh), ctrl);
                return;
            }
            else
            {
                ctrl.Refresh();
            }
            try
            {
                ctrl.Refresh();
            }
            catch (Exception) { }
        }

        delegate void SetPCTHandler(PictureBox ctrl, Bitmap value);
        public static void SetPCTValue(PictureBox ctrl, Bitmap value)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SetPCTHandler(SetPCTValue), ctrl, value);
                return;
            }

            try
            {
                ctrl.Image = new Bitmap(value);
            }
            catch (Exception) { }
        }

        delegate void SetCTRLHandler(Control ctrl, bool value);
        public static void SetCTREnableValue(Control ctrl, bool value)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SetCTRLHandler(SetCTREnableValue), ctrl, value);
                return;
            }

            try
            {
                ctrl.Enabled = value;
            }
            catch (Exception) { }
        }

        delegate string GetCTRLTextHandler(Control ctrl);
        public static string GetCTRText(Control ctrl)
        {
            string str;

            str = string.Empty;
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new GetCTRLTextHandler(GetCTRText), ctrl);           
            }
            try
            {
                str = ctrl.Text;
            }
            catch (Exception) { }
            return str;
        }

        delegate void SetCTRLTextHandler(Control ctrl, object value);
        public static void SetCTRText(Control ctrl, object value)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new SetCTRLTextHandler(SetCTRText), ctrl, value);
                return;
            }
            try
            {
                ctrl.Text = value.ToString();
            }
            catch (Exception) { }
        }

        delegate void RefreshHandler(Control ctrl);
        public static void RefreshControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new RefreshHandler(RefreshControl), ctrl);
                return;
            }
            try
            {
                ctrl.Refresh();
            }
            catch (Exception) { }
        }

        delegate void AddCTRLTextHandler(Control ctrl, string value);
        public static void AddCTRText(Control ctrl, string value)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new AddCTRLTextHandler(AddCTRText), ctrl, value);
                return;
            }
            try
            {
                ctrl.Text += value;
            }
            catch (Exception) { }
        }

        delegate void AddLstHandler(ListBox ctrl, object[] values);
        public static void AddLst(ListBox ctrl, object[] values)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(new AddLstHandler(AddLst), ctrl, values);
                return;
            }
            try
            {
                ctrl.Items.AddRange(values);
            }
            catch (Exception) { }
        }

    }
}
