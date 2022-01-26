using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        readonly DBTreeView dBTreeView;
        readonly CachedTreeView cachedTreeView;
        public Form1()
        {
            InitializeComponent();
            //Initialize Database
            dBTreeView = new DBTreeView(TreeViewDataBase);
            //Initialize Cached
            cachedTreeView = new CachedTreeView(TreeViewCache);
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            try
            {
                cachedTreeView.MoveElementFromCacheToDatabase(dBTreeView);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDatabaseToCache_Click(object sender, EventArgs e)
        {
            try
            {
                dBTreeView.LoadElementToCached(TreeViewCache);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                cachedTreeView.AddChildNode();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                cachedTreeView.RemoveNode();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                dBTreeView.SetDefaultTree(TreeViewDataBase);
                cachedTreeView.ResetTree();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonValue_Click(object sender, EventArgs e)
        {
            try
            {
                cachedTreeView.ChangeValue();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
