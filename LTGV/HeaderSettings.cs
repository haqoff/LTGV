using System.Windows.Forms;

namespace LTGV
{
    public sealed partial class HeaderSettings : Form
    {
        private Header header;

        public HeaderSettings(Header header)
        {
            this.header = header;
            Text = $@"Настройка {header.Name}";

            InitializeComponent();
        }

    }
}
