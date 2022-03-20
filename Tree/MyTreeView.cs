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
                RecursiveFindNodeOnTextNode(i, ref FindNode, compareNode.Text);
            }

            return FindNode;
        }
        public TreeNode FindNodeOnTextNode(string compareNode)
        {
            TreeNode FindNode = null;
            foreach (TreeNode i in this.Nodes)
            {
                RecursiveFindNodeOnTextNode(i, ref FindNode, compareNode);
            }

            return FindNode;
        }
        private void RecursiveFindNodeOnTextNode(TreeNode currentTreeNode, ref TreeNode findNode, string compareNode)
        {
            if (currentTreeNode.Text == compareNode)
            {
                findNode = currentTreeNode;
            }
            foreach (TreeNode i in currentTreeNode.Nodes)
            {
                if (i.Text == compareNode)
                {
                    findNode = i;
                }
                RecursiveFindNodeOnTextNode(i, ref findNode, compareNode);
            }
        }
        //Check right hierarchy
        public void CheckHierarchi(MyTreeView myTreeView)
        {
            List<List<TreeNode>> listList = ListTreeNodeAndParent.ListWithTreeNodeAndParent;

            foreach (var Main in listList)
            {
                foreach (var Slave in listList)
                {
                    if (Main[1] == Slave[1])
                    {
                        continue;
                    }
                    if (Slave[2] == Main[0] & Slave[2] != null)
                    {
                        myTreeView.Nodes.Remove(Slave[1]);
                        Main[1].Nodes.Add(Slave[1]);
                    }
                }
            }
            
        }
    }
}
