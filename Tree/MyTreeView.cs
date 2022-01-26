using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public class MyTreeView : TreeView
    {
        public int LastIndexInTreeView(int mostIndexLastNode = 1)
        {
            foreach (TreeNode i in this.Nodes)
            {
                i.LastIndex(ref mostIndexLastNode);
            }
            return mostIndexLastNode;
        }
        public List<TreeNode> GetListAllParents()
        {
            List<TreeNode> List = new List<TreeNode>();
            foreach (TreeNode i in this.Nodes)
            {
                List.Add(i);
            }
            return List;
        }
        public TreeNode FindNodeOnTextNode(TreeNode compareNode)
        {
            TreeNode FindNode = null;
            foreach (TreeNode i in this.Nodes)
            {
                RecursiveFindNodeOnTextNode(i, ref FindNode, compareNode);
            }

            if (FindNode == null)
            {
                throw new Exception("Равные узлы не найдены");
            }
            return FindNode;
        }
        private void RecursiveFindNodeOnTextNode(TreeNode currentTreeNode, ref TreeNode findNode, TreeNode compareNode)
        {
            if (currentTreeNode.Text == compareNode.Text)
            {
                findNode = currentTreeNode;
            }
            foreach (TreeNode i in currentTreeNode.Nodes)
            {
                if (i.Text == compareNode.Text)
                {
                    findNode = i;
                }
                RecursiveFindNodeOnTextNode(i, ref findNode, compareNode);
            }
        }
    }
}
