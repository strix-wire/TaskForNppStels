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
            currentNode.Nodes.Add("value", "Node" + (mostIndexLastNode + 1));
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
            if (currentNode != null)
            {
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

            }
        }
        public void ResetTree()
        {
            MyTreeViewCachedTree.Nodes.Clear();
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
                SelectedNodeInDBTree.Remove();

                if (temp != null)
                {
                    temp.Nodes.Add((TreeNode)i.Clone());
                }

                //SelectedNodeInDBTree already parent
                if (temp==null)
                {
                    dBTree.MyTreeViewDBTree.Nodes.Add((TreeNode)i.Clone());
                }
            }
            ResetTree();
            dBTree.ExpandAllNodes();
        }
        public void ExpandAllNodes()
        {
            MyTreeViewCachedTree.ExpandAll();
        }
    }
}
