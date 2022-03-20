using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public class DBTreeView : IComparable
    {
        public readonly MyTreeView MyTreeViewDBTree;
        public DBTreeView(MyTreeView dBTree)
        {
            MyTreeViewDBTree = dBTree;
            SetDefaultTree(MyTreeViewDBTree);
        }
        public void LoadElementToCached(MyTreeView cachedTreeView)
        {
            TreeNode CurrentNode = MyTreeViewDBTree.SelectedNode;

            if (CurrentNode == null)
            {
                throw new Exception("Не был выбран узел для переноса из Database в Cache.");
            }

            //Check if the node has already been added
            foreach (TreeNode tempNode in cachedTreeView.Nodes)
            {
                TreeNode FoundNodeInDatabase = tempNode.FindNodeOnText(CurrentNode);
                if (FoundNodeInDatabase != null)
                {
                    return;
                }
            }

            //First element in list - node(initial). Second element in list - node(copy). Third - parent node
            List<TreeNode> listTreeNode = ListTreeNodeAndParent.AddWithCopy(CurrentNode);
            cachedTreeView.Nodes.Add(listTreeNode[1]);

            cachedTreeView.CheckHierarchi(cachedTreeView);

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

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
