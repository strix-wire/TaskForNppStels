using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public class DBTreeView
    {
        public readonly MyTreeView MyTreeViewDBTree;
        public DBTreeView(MyTreeView dBTree)
        {
            MyTreeViewDBTree = dBTree;
            SetDefaultTree(MyTreeViewDBTree);
        }
        public void LoadElementToCached(MyTreeView cachedTreeView)
        {
            TreeNode temp = MyTreeViewDBTree.SelectedNode;

            if (temp == null)
            {
                throw new Exception("Не был выбран узел для переноса из Database в Cache.");
            }
            if (temp != null)
            {
                cachedTreeView.Nodes.Add((TreeNode)temp.Clone());
            }
            cachedTreeView.ExpandAll();
        }
        public void SetDefaultTree(MyTreeView MyTreeViewDBTree)
        {
            MyTreeViewDBTree.Nodes.Clear();
            MyTreeViewDBTree.Nodes.Add("value", "Node" + 1);
            MyTreeViewDBTree.Nodes[0].Nodes.Add("value", "Node" + 2);
            MyTreeViewDBTree.Nodes[0].Nodes[0].Nodes.Add("value", "Node" + 3);
            MyTreeViewDBTree.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("value", "Node" + 4);
            MyTreeViewDBTree.Nodes.Add("value", "Node" + 5);
            MyTreeViewDBTree.Nodes[1].Nodes.Add("value", "Node" + 6);
            ExpandAllNodes();
        }
        public void ExpandAllNodes()
        {
            MyTreeViewDBTree.ExpandAll();
        }
    }
}
