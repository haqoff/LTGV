using LTGV.GUI;
using System;
using System.Windows.Forms;

namespace LTGV.Format
{
    public abstract class AbstractFormatter
    {
        public bool Enabled { get; private set; }

        public Label LblName { get; }
        public HintTextBox TbCommand { get; }
        public CheckBox CbEnabled { get; }

        protected AbstractFormatter(string name, string hint)
        {
            LblName = new Label { Text = name };
            TbCommand = new HintTextBox() { Hint = hint };

            CbEnabled = new CheckBox() { Text = "" };
            CbEnabled.CheckedChanged += (sender, args) => SwitchEnable();
            SwitchEnable();
        }

        private void SwitchEnable()
        {
            Enabled = CbEnabled.Checked;

            if (CbEnabled.Checked)
            {
                LblName.Enabled = true;
                TbCommand.Enabled = true;
            }
            else
            {
                LblName.Enabled = false;
                TbCommand.Enabled = false;
            }
        }

        public abstract string Format(string source);

        public abstract void ParseCommand();
    }
}
