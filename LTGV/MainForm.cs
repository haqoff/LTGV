using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LTGV
{
    public partial class MainForm : Form
    {
        private DataTable table;
        private List<Header> headers;

        public MainForm()
        {
            InitializeComponent();
            BindGenerelHeaders();
        }

        private void BindGenerelHeaders()
        {
            headers = new List<Header>()
            {
                new Header(cbChainName, "ChainName"),
                new Header(cbYear, "Year"),
                new Header(cbWeek, "Week"),
                new Header(cbShopcode, "Shopcode"),
                new Header(cbBarcode, "Barcode"),
                new Header(cbBarname, "Barname"),
                new Header(cbGroupname, "Groupname"),
                new Header(cbProducerBrand, "ProducerBrand"),
                new Header(cbSilesItem, "SilesItem"),
                new Header(cbSilesValue, "SilesValue"),
                new Header(cbCostPrice, "CostPrice")
            };
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

                foreach (var header in headers)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        header.DimList.Items.Add(StringUtils.GetExcelColumnName(i, 0) + ": " + table.Columns[i].ColumnName);
                    }
                }
            }
        }


        private void btnSettings_Click(object sender, EventArgs args)
        {
            var s = sender as Button;

            if (s == btnChainName)
            {

            }
            else if(s == btnYear)
        }
    }
}
