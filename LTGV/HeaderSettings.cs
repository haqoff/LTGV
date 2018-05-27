using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGV
{
    public sealed partial class HeaderSettings : Form
    {
        private Point lastLocationLabel = new Point(12, 13);
        private Point lastLocationTextBox = new Point(96, 10);
        private Point lastLocationCheckBox = new Point(267, 10);

        private readonly Size TEXTBOX_SIZE = new Size(165, 20);
        private const int Y_OFFSET = 26;

        private Header header;
        
        public HeaderSettings(Header header)
        {
            InitializeComponent();

            this.header = header;
            Text = $@"Настройка {header.Name}";
            InitFormatters();
        }

        private void InitFormatters()
        {
            for (int i = 0; i < header.Formatters.Length; i++)
            {
                lastLocationLabel.Offset(0, i * Y_OFFSET);
                lastLocationTextBox.Offset(0, i * Y_OFFSET);
                lastLocationCheckBox.Offset(0, i * Y_OFFSET);

                var labelLocation = new Point(lastLocationLabel.X, lastLocationLabel.Y);
                var textBoxLocation = new Point(lastLocationTextBox.X, lastLocationTextBox.Y);
                var checkBoxLocation = new Point(lastLocationCheckBox.X, lastLocationCheckBox.Y);

                var formatter = header.Formatters[i];

                formatter.LblName.Location = labelLocation;
                formatter.LblName.AutoSize = true;

                formatter.TbCommand.Location = textBoxLocation;
                formatter.TbCommand.Size = TEXTBOX_SIZE;

                formatter.CbEnabled.Location = checkBoxLocation;

                Controls.Add(formatter.LblName);
                Controls.Add(formatter.TbCommand);
                Controls.Add(formatter.CbEnabled);
            }
        }

        private void HeaderSettings_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void HeaderSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < header.Formatters.Length; i++)
            {
                var f = header.Formatters[i];

                try
                {
                    f.ParseCommand();
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message, $"Ошибка команды {f.LblName.Text}.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
