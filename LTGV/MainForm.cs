using System;
using System.Data;
using System.Windows.Forms;

namespace LTGV
{
    public partial class MainForm : Form
    {
        private DataTable table;

        public MainForm()
        {
            InitializeComponent();
        }


        private void miOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "(*.xls, *.xlsx)|*.xls;*xlsx", ValidateNames = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var dataSet = IOUtils.GetDataSetFromExcelFile(ofd.FileName);

                int tableIndex = 0;
                if (dataSet.Tables.Count > 1)
                {
                    var sheetNames = new string[dataSet.Tables.Count];
                    for (int i = 0; i < dataSet.Tables.Count; i++)
                    {
                        sheetNames[i] = dataSet.Tables[i].TableName;
                    }

                    var cd = new ComboboxDialog("Выберите лист.", sheetNames);
                    cd.ShowDialog();
                    tableIndex = cd.SelectedIndex;
                }

                table = dataSet.Tables[tableIndex];
            }
        }
    }
}
