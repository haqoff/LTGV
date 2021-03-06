﻿using System;
using System.Drawing;
using System.Windows.Forms;
using LTGV.Format;

namespace LTGV
{
    public class Header
    {
        public Header(Button btnSettings, ComboBox dimList, string name)
        {
            BtnSettings = btnSettings;
            BtnSettings.Click += OnButtonClick;
            DimList = dimList;
            Name = name;
            Formatters = FormatterFactory.CreateStandartFormatters();

            DimList.TextChanged += (sender, args) => OnListTextChanged();
            OnListTextChanged();
        }

        public string Name { get; }
        public int ListSelectedIndex { get; private set; }
        public string ListText { get; private set; }

        public Button BtnSettings { get; }
        public ComboBox DimList { get; }
        public AbstractFormatter[] Formatters { get; }

        private void OnListTextChanged()
        {
            ListSelectedIndex = DimList.SelectedIndex;
            if (ListSelectedIndex == -1) ListText = DimList.Text;
        }

        public void UpdateButtonColor()
        {
            var hasEnabledFormatter = false;
            for (var i = 0; i < Formatters.Length; i++)
                if (Formatters[i].CbEnabled.Checked)
                {
                    hasEnabledFormatter = true;
                    break;
                }

            if (hasEnabledFormatter)
            {
                BtnSettings.BackColor = SystemColors.ScrollBar;
                BtnSettings.ForeColor = Color.Red;
            }
            else
            {
                BtnSettings.BackColor = SystemColors.ControlLight;
                BtnSettings.ForeColor = SystemColors.ControlText;
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            var h = new HeaderSettings(this);
            h.ShowDialog();

            UpdateButtonColor();
        }
    }
}