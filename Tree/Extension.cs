using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public static class Extension
    {
        public static void LastIndex(this TreeNode treeNode, ref int mostIndexLastNode)
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
        public static void MyLastNode(this TreeNode treeNode, ref TreeNode lastNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                lastNode = treeNode;
            }
            foreach (TreeNode i in treeNode.Nodes)
            {
                lastNode = i;
                MyLastNode(i, ref lastNode);
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
        public static void IndexNode(this TreeNode treeNode,out int currentIndex)
        {
            bool result = int.TryParse(treeNode.Text.Replace("Node", ""), out currentIndex);
            if (result == false)
            {
                throw new Exception("Один из узлов не содержит идентификатора(номера узла).");
            }
        }
        public static TreeNode FindNodeOnText(this TreeNode treeNode,TreeNode findNode)
        {
            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(treeNode);

            while (staging.Count > 0)
            {
                treeNode = staging.Dequeue();

                if (findNode.Text == treeNode.Text)
                {
                    return treeNode;
                }

                foreach (TreeNode node in treeNode.Nodes)
                {
                    staging.Enqueue(node);
                }
            }
            return null;
        }
    }
}
