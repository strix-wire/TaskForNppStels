using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public static class ListTreeNodeAndParent
    {
        //This class is used because a node cannot exist in 2 treeviews at the same time.
        //And the parent property for the node does not have a set.
        //Cloning a node does not preserve the parent property.

        //First element in list - node(initial). Second element in list - node(copy). Third - parent node
        public static List<List<TreeNode>> ListWithTreeNodeAndParent { get; set; } = new List<List<TreeNode>>();

        public static List<TreeNode> AddWithCopy(TreeNode treeNode)
        {
            TreeNode treeNodeCopy = (TreeNode)treeNode.Clone();
            treeNodeCopy.Nodes.Clear();
            List<TreeNode> listTreeNode = new List<TreeNode>
            {
                treeNode,
                treeNodeCopy,
                treeNode.Parent,
            };
            ListWithTreeNodeAndParent.Add(listTreeNode);

            return listTreeNode;
        }
        public static void Add(TreeNode treeNode)
        {
            TreeNode treeNodeParent = treeNode.Parent;
            List<TreeNode> list = new List<TreeNode>
            {
                treeNode,
                treeNode,
                treeNodeParent,
            };
            ListWithTreeNodeAndParent.Add(list);
        }
        public static TreeNode FindParentTreeNodeForCurrentTreeNode(TreeNode currentTreeNode)
        {
            foreach (var i in ListWithTreeNodeAndParent)
            {
                if (i[0] == currentTreeNode)
                {
                    return i[1];
                }
            }

            return null;
        }
        public static void Remove(TreeNode currentTreeNode)
        {
            int counter = 0;
            foreach (var i in ListWithTreeNodeAndParent)
            {
                if (i[1] == currentTreeNode)
                {
                    ListWithTreeNodeAndParent.Remove(ListWithTreeNodeAndParent[counter]);
                    break;
                }
                counter++;
            }
        }
    }
}
