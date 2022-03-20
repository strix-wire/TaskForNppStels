using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddChildNode(DBTreeView dBTreeView)
        {
            //calculate the largest index
            int mostIndexLastNodeDbTree = dBTreeView.MyTreeViewDBTree.LastIndexInTreeView();
            int mostIndexLastNodeCachedTree = MyTreeViewCachedTree.LastIndexInTreeView();
            int IndexLastNode;
            if (mostIndexLastNodeDbTree > mostIndexLastNodeCachedTree)
            {
                IndexLastNode = mostIndexLastNodeDbTree;
            }
            else
            {
                IndexLastNode = mostIndexLastNodeCachedTree;
            }

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
            currentNode.Nodes.Add("value", "Node" + (IndexLastNode + 1));
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
            if (ListAllParents.Count == 0)
            {
                return;
            }

            foreach (TreeNode parentTreeNodeCached in ListAllParents)
            {
                TreeNode cloneCurrentTreeNodeCached = (TreeNode)parentTreeNodeCached.Clone();
                TreeNode changeableTreeNodeInDbTree = dBTree.MyTreeViewDBTree.FindNodeOnTextNode(cloneCurrentTreeNodeCached.Text);

                TreeNode cloneCurrentTreeNodeParentCached = changeableTreeNodeInDbTree.Parent;

                //---
                //Check nodes that are already in DbTree so that they are not deleted
                //---
                TreeNode selectedNodeDbForParentNodeCached = dBTree.MyTreeViewDBTree.FindNodeOnTextNode(parentTreeNodeCached.Text);
                CheckNodesThatAlreadyExist(selectedNodeDbForParentNodeCached, cloneCurrentTreeNodeCached);
                //---

                changeableTreeNodeInDbTree.Remove();

                if (cloneCurrentTreeNodeParentCached != null)
                {
                    cloneCurrentTreeNodeParentCached.Nodes.Add(cloneCurrentTreeNodeCached);
                }
                else
                {
                    dBTree.MyTreeViewDBTree.Nodes.Add(cloneCurrentTreeNodeCached);
                }

                //---
                //Can't be painted or removed
                //---
                CheckChildrenNodeForCorrelations(cloneCurrentTreeNodeCached, dBTree);
                //---
            }

            ResetTree();
            dBTree.MyTreeViewDBTree.TreeViewNodeSorter = new MyTreeViewSort();
            dBTree.ExpandAllNodes();
        }

        //Check nodes that are already in DbTree so that they are not deleted
        private void CheckNodesThatAlreadyExist(TreeNode treeNodeDb, TreeNode treeNodeCachedClone)
        {
            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(treeNodeDb);

            while (staging.Count > 0)
            {
                treeNodeDb = staging.Dequeue();

                TreeNode backup = treeNodeCachedClone.FindNodeOnText(treeNodeDb);


                if (backup == null)
                {
                    TreeNode backup2 = treeNodeCachedClone.FindNodeOnText(treeNodeDb.Parent);
                    backup2.Nodes.Add((TreeNode)treeNodeDb.Clone());
                }

                foreach (TreeNode node in treeNodeDb.Nodes)
                {
                    staging.Enqueue(node);

                }
            }
        }
        private void CheckChildrenNodeForCorrelations(TreeNode treeNodeCached, DBTreeView dBTree)
        {
            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(treeNodeCached);

            while (staging.Count > 0)
            {
                treeNodeCached = staging.Dequeue();

                if (treeNodeCached.BackColor == System.Drawing.Color.Red)
                {
                    TreeNode backup = dBTree.MyTreeViewDBTree.FindNodeOnTextNode(treeNodeCached);
                    ChangeColor(backup);
                }

                foreach (TreeNode node in treeNodeCached.Nodes)
                {
                    staging.Enqueue(node);

                }
            }
        }
        private void ChangeColor(TreeNode treeNode)
        {
            Queue<TreeNode> staging = new Queue<TreeNode>();
            staging.Enqueue(treeNode);

            while (staging.Count > 0)
            {
                treeNode = staging.Dequeue();

                treeNode.BackColor = System.Drawing.Color.Red;
                treeNode.Tag = "No change";

                foreach (TreeNode node in treeNode.Nodes)
                {
                    staging.Enqueue(node);

                }
            }
        }
        public void ExpandAllNodes()
        {
            MyTreeViewCachedTree.ExpandAll();
        }
    }
}
