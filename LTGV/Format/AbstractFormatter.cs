using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGV.Format
{
    public abstract class AbstractFormatter
    {
        public Label LblName { get; }
        public TextBox TbCommand { get; }
        public CheckBox CbEnabled { get; }

        private string hint;

        protected AbstractFormatter(string name, string hint)
        {
            LblName = new Label {Text = name};

            TbCommand = new TextBox();
            this.hint = hint;
            TbCommand.TextChanged += OnTextChanged;
            TbCommand.Text = hint;

            CbEnabled = new CheckBox();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (TbCommand.Text == hint) TbCommand.ForeColor = Color.Silver;
            else
            {
                TbCommand.ForeColor = Color.Black;
                TbCommand.Text = TbCommand.Text.Replace(hint, "");
            }
        }


        public abstract string Format(string source);
    }
}
