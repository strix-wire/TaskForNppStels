using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public static class TreeNodeExtension
    {
        public static void LastIndex(this TreeNode treeNode,ref int mostIndexLastNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                CheckIndexMoreOrLess(ref mostIndexLastNode, treeNode);
            }
            foreach (TreeNode i in treeNode.Nodes)
            {
                CheckIndexMoreOrLess(ref mostIndexLastNode, i);
                LastIndex(i, ref mostIndexLastNode);
            }
        }
        private static void CheckIndexMoreOrLess(ref int mostIndexLastNode, TreeNode myTreeNode)
        {
            IndexNode(myTreeNode, out int currentIndex);
            if (currentIndex > mostIndexLastNode)
            {
                mostIndexLastNode = currentIndex;
            }
        }
        public static void IndexNode(this TreeNode myTreeNode, out int currentIndex)
        {
            bool result = int.TryParse(myTreeNode.Text.Replace("Node", ""), out currentIndex);
            if (result == false)
            {
                throw new Exception("Один из узлов не содержит идентификатора(номера узла).");
            }
        }
    }
}
