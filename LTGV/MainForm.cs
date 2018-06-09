using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LTGV
{
    public partial class MainForm : Form
    {
        private List<Header> headers;

        private readonly OpenFileDialog ofd;
        private readonly SaveFileDialog sfd;
        private string ofdLastPath;
        private string sfdLastPath;

        private DataTable table;

        public MainForm()
        {
            InitializeComponent();
            BindGenerelHeaders();

            ofd = new OpenFileDialog { Filter = "(*.xls, *.xlsx)|*.xls;*xlsx", ValidateNames = true };
            sfd = new SaveFileDialog { Filter = "*.txt|*.txt", ValidateNames = true };

            ofdLastPath = string.Empty;
            sfdLastPath = string.Empty;
        }

        private void BindGenerelHeaders()
        {
            headers = new List<Header>
            {
                new Header(btnChainName, cbChainName, "ChainName"),
                new Header(btnYear, cbYear, "Year"),
                new Header(btnMonth, cbMonth, "Month"),
                new Header(btnWeek, cbWeek, "Week"),
                new Header(btnShopcode, cbShopcode, "Shopcode"),
                new Header(btnBarcode, cbBarcode, "Barcode"),
                new Header(btnBarname, cbBarname, "Barname"),
                new Header(btnGroupname, cbGroupname, "Groupname"),
                new Header(btnProducerBrand, cbProducerBrand, "ProducerBrand"),
                new Header(btnSalesItem, cbSalesItem, "SalesItem"),
                new Header(btnSalesValue, cbSalesValue, "SalesValue"),
                new Header(btnCostPrice, cbCostPrice, "CostPrice")
            };
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            ofd.FileName = ofdLastPath;
            if (ofd.ShowDialog() == DialogResult.OK) OpenProject(ofd.FileName);
        }

        private void OpenProject(string fileName)
        {
            CloseProject();

            var dataSet = IOUtils.GetDataSetFromExcelFileAsync(fileName).Result;

            var tableIndex = 0;
            if (dataSet.Tables.Count > 1)
            {
                var sheetNames = new string[dataSet.Tables.Count];
                for (var i = 0; i < dataSet.Tables.Count; i++) sheetNames[i] = dataSet.Tables[i].TableName;

                var cd = new ComboboxDialog("Выберите лист.", sheetNames);
                cd.ShowDialog();
                tableIndex = cd.SelectedIndex;
            }

            table = dataSet.Tables[tableIndex];

            foreach (var header in headers)
                for (var i = 0; i < table.Columns.Count; i++)
                    header.DimList.Items.Add(StringUtils.GetExcelColumnName(i, 0) + ": " +
                                             table.Columns[i].ColumnName);

            ofdLastPath = fileName;
            pMain.Enabled = true;
        }


        private void btnProccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sfdLastPath))
                sfd.FileName = sfdLastPath.Replace(Path.GetFileName(sfdLastPath), "") + @"\";
            sfd.FileName += Path.GetFileName(ofdLastPath);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var thread = new Thread(() => Proccess(sfd.FileName, table));
                sfdLastPath = sfd.FileName;
                thread.Start();
            }
        }

        private void Proccess(string path, DataTable table)
        {
            const char tab = '\t';

            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Value = 0));
            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Maximum = table.Rows.Count));
            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Visible = true));
            pMain.Invoke((MethodInvoker)(() => pMain.Enabled = false));

            using (var streamWriter = new StreamWriter(path, false, Encoding.Default))
            {
                var sb = new StringBuilder();

                //Write Headers
                for (var i = 0; i < headers.Count; i++)
                {
                    sb.Append(headers[i].Name);
                    if (i != headers.Count - 1) sb.Append(tab);
                }

                streamWriter.WriteLine(sb);

                //Write Data
                foreach (DataRow row in table.Rows)
                {
                    sb.Clear();

                    for (var i = 0; i < headers.Count; i++)
                    {
                        var header = headers[i];
                        var indexColumn = header.ListSelectedIndex;

                        string value = null;

                        if (indexColumn > -1) value = row[indexColumn].ToString();
                        else value = header.ListText;

                        foreach (var formatter in header.Formatters)
                            if (formatter.Enabled)
                                value = formatter.Format(value);

                        sb.Append(value);
                        if (i != headers.Count - 1) sb.Append(tab);
                    }

                    streamWriter.WriteLine(sb);
                    pbProgress.Invoke((MethodInvoker)(() => pbProgress.Increment(1)));
                }
            }

            MessageBox.Show("Обработка завершена.", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.None);
            pMain.Invoke((MethodInvoker)(() => pMain.Enabled = true));
            pbProgress.Invoke((MethodInvoker)(() => pbProgress.Visible = false));
        }

        private void miClose_Click(object sender, EventArgs e) => CloseProject();

        private void CloseProject()
        {
            pMain.Enabled = false;
            table = null;
            foreach (var header in headers) header.DimList.Items.Clear();
        }
    }
}