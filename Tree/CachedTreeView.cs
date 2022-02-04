using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tree
{
    public class CachedTreeView
    {
        private readonly MyTreeView MyTreeViewCachedTree;
        public CachedTreeView(MyTreeView cachedTree)
        {
            MyTreeViewCachedTree = cachedTree;
        }
        public void ChangeValue()
        {
            TreeNode currentNode = MyTreeViewCachedTree.SelectedNode;

            if (currentNode == null)
            {
                throw new Exception("Не был выбран узел для изменения значения в Cache.");
            }
            if (currentNode.Tag != null)
            {
                throw new Exception("Был выбран удаленный элемент. Редактирование невозможно.");
            }

            if (currentNode != null)
            {
                Form form2 = new Form
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Size = new System.Drawing.Size(300, 135)
                };

                RichTextBox richTextBoxValue = new RichTextBox();
                form2.Controls.Add(richTextBoxValue);
                richTextBoxValue.Size = new System.Drawing.Size(100, 50);
                richTextBoxValue.Location = new System.Drawing.Point(100, 15);
                richTextBoxValue.Text = currentNode.Name;

                Label label = new Label();
                form2.Controls.Add(label);
                label.Text = "Value:";
                label.Location = new System.Drawing.Point(125, 1);

                Button buttonSave = new Button();
                form2.Controls.Add(buttonSave);
                buttonSave.Location = new System.Drawing.Point(100,70);
                buttonSave.Text = "Save";
                buttonSave.DialogResult = DialogResult.OK;

                Button buttonCancel = new Button();
                form2.Controls.Add(buttonCancel);
                buttonCancel.Location = new System.Drawing.Point(175, 70);
                buttonCancel.Text = "Cancel";
                buttonCancel.DialogResult = DialogResult.Cancel;

                form2.ShowDialog();
                if (form2.DialogResult == DialogResult.OK)
                {
                    currentNode.Name = richTextBoxValue.Text;
                }
            }
        }
        public void AddChildNode()
        {
            int mostIndexLastNode = MyTreeViewCachedTree.LastIndexInTreeView();

            //find which node is selected
            TreeNode currentNode = MyTreeViewCachedTree.SelectedNode;
            if (currentNode == null)
            {
                throw new Exception("Не был выбран узел для добавления нового дочернего элемента в Cache");
            }
            if (currentNode.Tag != null)
            {
                throw new Exception("Был выбран удаленный элемент. Редактирование невозможно");
            }
            ListTreeNodeAndParent.Add(currentNode);
            currentNode.Nodes.Add("value", "Node" + (mostIndexLastNode + 1));
            MyTreeViewCachedTree.CheckHierarchi(MyTreeViewCachedTree);
            ExpandAllNodes();
        }
        public void RemoveNode()
        {
            TreeNode currentNode = MyTreeViewCachedTree.SelectedNode;
            if (currentNode == null)
            {
                throw new Exception("Не был выбран узел для удаления элемента в Cache.");
            }
            if (currentNode.Tag != null)
            {
                throw new Exception("Был выбран удаленный элемент. Редактирование невозможно.");
            }

            ListTreeNodeAndParent.Remove(currentNode);

            //Run for all childs elements for current node

            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(currentNode);

            while (staging.Count > 0)
            {
                currentNode = staging.Dequeue();

                currentNode.BackColor = System.Drawing.Color.Red;
                currentNode.Tag = "No change";

                foreach (TreeNode node in currentNode.Nodes)
                {
                    staging.Enqueue(node);
                }
            }

            MyTreeViewCachedTree.CheckHierarchi(MyTreeViewCachedTree);
        }
        public void ResetTree()
        {
            MyTreeViewCachedTree.Nodes.Clear();
            ListTreeNodeAndParent.ListWithTreeNodeAndParent = new List<List<TreeNode>>();
        }
        public void MoveElementFromCacheToDatabase(DBTreeView dBTree)
        {
            List<TreeNode> ListAllParents = MyTreeViewCachedTree.GetListAllParents();

            //CachedTreeView is empty
            if (ListAllParents.Count==0)
            {
                return;
            }

            foreach (var i in ListAllParents)
            {
                TreeNode SelectedNodeInDBTree = dBTree.MyTreeViewDBTree.FindNodeOnTextNode(i);
                TreeNode temp = SelectedNodeInDBTree.Parent;

                TreeNode LastNodeInCachee = i;
                if (i.LastNode != null)
                {
                    i.MyLastNode(ref LastNodeInCachee);
                }
                TreeNode FixTreeNodeCachee = CheckChildrenNodeForCorrelations(SelectedNodeInDBTree, LastNodeInCachee, i);

                SelectedNodeInDBTree.Remove();

                if (temp != null)
                {
                    temp.Nodes.Add((TreeNode)FixTreeNodeCachee.Clone());
                }

                //SelectedNodeInDBTree already parent
                if (temp == null)
                {
                    dBTree.MyTreeViewDBTree.Nodes.Add((TreeNode)FixTreeNodeCachee.Clone());
                }
            }
            ResetTree();
            dBTree.ExpandAllNodes();
        }
        //Validates and completes Cached child nodes to migrate to DbTree
        private TreeNode CheckChildrenNodeForCorrelations(TreeNode TreeNodeDBTree, TreeNode lastNodeInCachee, TreeNode treeNodeCachee)
        {
            //flag that matched the last element of the cache - dBTree
            bool flag = false;

            //flag to mark subsequent elements removed
            bool flagDelete = false; 

            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(TreeNodeDBTree);
            
            while (staging.Count > 0)
            {
                TreeNodeDBTree = staging.Dequeue();

                if (flag)
                {
                    TreeNode temp = (TreeNode)TreeNodeDBTree.Clone();
                    temp.Nodes.Clear();
                    if (flagDelete)
                    {
                        temp.BackColor = System.Drawing.Color.Red;
                        temp.Tag = "No change";
                    }
                    if (treeNodeCachee.LastNode != null)
                    {
                        TreeNode myLastNode = new TreeNode();
                        treeNodeCachee.MyLastNode(ref myLastNode);
                        myLastNode.Nodes.Add(temp);
                    }
                    else
                    {
                        treeNodeCachee.Nodes.Add(temp);
                    }
                }

                if (lastNodeInCachee.Text == TreeNodeDBTree.Text)
                {
                    flag = true;
                    if (lastNodeInCachee.BackColor == System.Drawing.Color.Red)
                    {
                        flagDelete = true;
                    }
                }

                foreach (TreeNode node in TreeNodeDBTree.Nodes)
                {
                    staging.Enqueue(node);
                }
            }

            return treeNodeCachee;
        }
        public void ExpandAllNodes()
        {
            MyTreeViewCachedTree.ExpandAll();
        }
    }
}
