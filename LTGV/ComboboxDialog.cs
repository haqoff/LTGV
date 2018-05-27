using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LTGV
{
    public partial class ComboboxDialog : Form
    {
        public object SelectedItem { get; private set; }
        public int SelectedIndex { get; private set; }
        
        public ComboboxDialog(string caption, IEnumerable<object> objects)
        {
            InitializeComponent();
            Text = caption;
            foreach (var obj in objects)
            {
                cbList.Items.Add(obj);
            }
            cbList.SelectedIndex = 0;

            SelectedItem = cbList.SelectedItem;
            SelectedIndex = cbList.SelectedIndex;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = cbList.SelectedItem;
            SelectedIndex = cbList.SelectedIndex;
        }
    }
}
