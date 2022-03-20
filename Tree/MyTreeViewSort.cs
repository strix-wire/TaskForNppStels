using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public class MyTreeViewSort : IComparer
    {
        // compare between two tree nodes
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            if (tx.Text.Length != ty.Text.Length)
                return tx.Text.Length - ty.Text.Length;

            return string.Compare(tx.Text, ty.Text);
        }
    }
}
