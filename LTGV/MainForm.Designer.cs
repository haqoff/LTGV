namespace LTGV
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblChainName = new System.Windows.Forms.Label();
            this.cbChainName = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.lblGroupname = new System.Windows.Forms.Label();
            this.cbGroupname = new System.Windows.Forms.ComboBox();
            this.lblBarname = new System.Windows.Forms.Label();
            this.cbBarname = new System.Windows.Forms.ComboBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.cbBarcode = new System.Windows.Forms.ComboBox();
            this.lblShopcode = new System.Windows.Forms.Label();
            this.cbShopcode = new System.Windows.Forms.ComboBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.cbCostPrice = new System.Windows.Forms.ComboBox();
            this.lblSilesValue = new System.Windows.Forms.Label();
            this.cbSilesValue = new System.Windows.Forms.ComboBox();
            this.lblSilesItem = new System.Windows.Forms.Label();
            this.cbSilesItem = new System.Windows.Forms.ComboBox();
            this.lblProducerBrand = new System.Windows.Forms.Label();
            this.cbProducerBrand = new System.Windows.Forms.ComboBox();
            this.btnChainName = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnGroupname = new System.Windows.Forms.Button();
            this.btnBarname = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnShopcode = new System.Windows.Forms.Button();
            this.btnCostPrice = new System.Windows.Forms.Button();
            this.btnSilesValue = new System.Windows.Forms.Button();
            this.btnSilesItem = new System.Windows.Forms.Button();
            this.btnProducerBrand = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(311, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.btnCostPrice);
            this.pMain.Controls.Add(this.btnSilesValue);
            this.pMain.Controls.Add(this.btnSilesItem);
            this.pMain.Controls.Add(this.btnProducerBrand);
            this.pMain.Controls.Add(this.btnGroupname);
            this.pMain.Controls.Add(this.btnBarname);
            this.pMain.Controls.Add(this.btnBarcode);
            this.pMain.Controls.Add(this.btnShopcode);
            this.pMain.Controls.Add(this.btnWeek);
            this.pMain.Controls.Add(this.btnMonth);
            this.pMain.Controls.Add(this.btnYear);
            this.pMain.Controls.Add(this.btnChainName);
            this.pMain.Controls.Add(this.lblCostPrice);
            this.pMain.Controls.Add(this.cbCostPrice);
            this.pMain.Controls.Add(this.lblSilesValue);
            this.pMain.Controls.Add(this.cbSilesValue);
            this.pMain.Controls.Add(this.lblSilesItem);
            this.pMain.Controls.Add(this.cbSilesItem);
            this.pMain.Controls.Add(this.lblProducerBrand);
            this.pMain.Controls.Add(this.cbProducerBrand);
            this.pMain.Controls.Add(this.lblGroupname);
            this.pMain.Controls.Add(this.cbGroupname);
            this.pMain.Controls.Add(this.lblBarname);
            this.pMain.Controls.Add(this.cbBarname);
            this.pMain.Controls.Add(this.lblBarcode);
            this.pMain.Controls.Add(this.cbBarcode);
            this.pMain.Controls.Add(this.lblShopcode);
            this.pMain.Controls.Add(this.cbShopcode);
            this.pMain.Controls.Add(this.lblWeek);
            this.pMain.Controls.Add(this.cbWeek);
            this.pMain.Controls.Add(this.lblMonth);
            this.pMain.Controls.Add(this.cbMonth);
            this.pMain.Controls.Add(this.lblYear);
            this.pMain.Controls.Add(this.cbYear);
            this.pMain.Controls.Add(this.lblChainName);
            this.pMain.Controls.Add(this.cbChainName);
            this.pMain.Location = new System.Drawing.Point(12, 37);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(287, 355);
            this.pMain.TabIndex = 1;
            // 
            // lblChainName
            // 
            this.lblChainName.AutoSize = true;
            this.lblChainName.Location = new System.Drawing.Point(3, 10);
            this.lblChainName.Name = "lblChainName";
            this.lblChainName.Size = new System.Drawing.Size(65, 13);
            this.lblChainName.TabIndex = 1;
            this.lblChainName.Text = "ChainName:";
            // 
            // cbChainName
            // 
            this.cbChainName.FormattingEnabled = true;
            this.cbChainName.Location = new System.Drawing.Point(74, 7);
            this.cbChainName.Name = "cbChainName";
            this.cbChainName.Size = new System.Drawing.Size(175, 21);
            this.cbChainName.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(3, 37);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(74, 34);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(175, 21);
            this.cbYear.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(3, 64);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Month:";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(74, 61);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(175, 21);
            this.cbMonth.TabIndex = 4;
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(3, 91);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(39, 13);
            this.lblWeek.TabIndex = 7;
            this.lblWeek.Text = "Week:";
            // 
            // cbWeek
            // 
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Location = new System.Drawing.Point(74, 88);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(175, 21);
            this.cbWeek.TabIndex = 6;
            // 
            // lblGroupname
            // 
            this.lblGroupname.AutoSize = true;
            this.lblGroupname.Location = new System.Drawing.Point(3, 199);
            this.lblGroupname.Name = "lblGroupname";
            this.lblGroupname.Size = new System.Drawing.Size(65, 13);
            this.lblGroupname.TabIndex = 15;
            this.lblGroupname.Text = "Groupname:";
            // 
            // cbGroupname
            // 
            this.cbGroupname.FormattingEnabled = true;
            this.cbGroupname.Location = new System.Drawing.Point(74, 196);
            this.cbGroupname.Name = "cbGroupname";
            this.cbGroupname.Size = new System.Drawing.Size(175, 21);
            this.cbGroupname.TabIndex = 14;
            // 
            // lblBarname
            // 
            this.lblBarname.AutoSize = true;
            this.lblBarname.Location = new System.Drawing.Point(3, 172);
            this.lblBarname.Name = "lblBarname";
            this.lblBarname.Size = new System.Drawing.Size(52, 13);
            this.lblBarname.TabIndex = 13;
            this.lblBarname.Text = "Barname:";
            // 
            // cbBarname
            // 
            this.cbBarname.FormattingEnabled = true;
            this.cbBarname.Location = new System.Drawing.Point(74, 169);
            this.cbBarname.Name = "cbBarname";
            this.cbBarname.Size = new System.Drawing.Size(175, 21);
            this.cbBarname.TabIndex = 12;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(3, 145);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 13);
            this.lblBarcode.TabIndex = 11;
            this.lblBarcode.Text = "Barcode:";
            // 
            // cbBarcode
            // 
            this.cbBarcode.FormattingEnabled = true;
            this.cbBarcode.Location = new System.Drawing.Point(74, 142);
            this.cbBarcode.Name = "cbBarcode";
            this.cbBarcode.Size = new System.Drawing.Size(175, 21);
            this.cbBarcode.TabIndex = 10;
            // 
            // lblShopcode
            // 
            this.lblShopcode.AutoSize = true;
            this.lblShopcode.Location = new System.Drawing.Point(3, 118);
            this.lblShopcode.Name = "lblShopcode";
            this.lblShopcode.Size = new System.Drawing.Size(59, 13);
            this.lblShopcode.TabIndex = 9;
            this.lblShopcode.Text = "Shopcode:";
            // 
            // cbShopcode
            // 
            this.cbShopcode.FormattingEnabled = true;
            this.cbShopcode.Location = new System.Drawing.Point(74, 115);
            this.cbShopcode.Name = "cbShopcode";
            this.cbShopcode.Size = new System.Drawing.Size(175, 21);
            this.cbShopcode.TabIndex = 8;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(3, 307);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(55, 13);
            this.lblCostPrice.TabIndex = 23;
            this.lblCostPrice.Text = "CostPrice:";
            // 
            // cbCostPrice
            // 
            this.cbCostPrice.FormattingEnabled = true;
            this.cbCostPrice.Location = new System.Drawing.Point(74, 304);
            this.cbCostPrice.Name = "cbCostPrice";
            this.cbCostPrice.Size = new System.Drawing.Size(175, 21);
            this.cbCostPrice.TabIndex = 22;
            // 
            // lblSilesValue
            // 
            this.lblSilesValue.AutoSize = true;
            this.lblSilesValue.Location = new System.Drawing.Point(3, 280);
            this.lblSilesValue.Name = "lblSilesValue";
            this.lblSilesValue.Size = new System.Drawing.Size(59, 13);
            this.lblSilesValue.TabIndex = 21;
            this.lblSilesValue.Text = "SilesValue:";
            // 
            // cbSilesValue
            // 
            this.cbSilesValue.FormattingEnabled = true;
            this.cbSilesValue.Location = new System.Drawing.Point(74, 277);
            this.cbSilesValue.Name = "cbSilesValue";
            this.cbSilesValue.Size = new System.Drawing.Size(175, 21);
            this.cbSilesValue.TabIndex = 20;
            // 
            // lblSilesItem
            // 
            this.lblSilesItem.AutoSize = true;
            this.lblSilesItem.Location = new System.Drawing.Point(3, 253);
            this.lblSilesItem.Name = "lblSilesItem";
            this.lblSilesItem.Size = new System.Drawing.Size(52, 13);
            this.lblSilesItem.TabIndex = 19;
            this.lblSilesItem.Text = "SilesItem:";
            // 
            // cbSilesItem
            // 
            this.cbSilesItem.FormattingEnabled = true;
            this.cbSilesItem.Location = new System.Drawing.Point(74, 250);
            this.cbSilesItem.Name = "cbSilesItem";
            this.cbSilesItem.Size = new System.Drawing.Size(175, 21);
            this.cbSilesItem.TabIndex = 18;
            // 
            // lblProducerBrand
            // 
            this.lblProducerBrand.AutoSize = true;
            this.lblProducerBrand.Location = new System.Drawing.Point(3, 226);
            this.lblProducerBrand.Name = "lblProducerBrand";
            this.lblProducerBrand.Size = new System.Drawing.Size(63, 13);
            this.lblProducerBrand.TabIndex = 17;
            this.lblProducerBrand.Text = "Prod.Brand:";
            // 
            // cbProducerBrand
            // 
            this.cbProducerBrand.FormattingEnabled = true;
            this.cbProducerBrand.Location = new System.Drawing.Point(74, 223);
            this.cbProducerBrand.Name = "cbProducerBrand";
            this.cbProducerBrand.Size = new System.Drawing.Size(175, 21);
            this.cbProducerBrand.TabIndex = 16;
            // 
            // btnChainName
            // 
            this.btnChainName.Location = new System.Drawing.Point(255, 7);
            this.btnChainName.Name = "btnChainName";
            this.btnChainName.Size = new System.Drawing.Size(28, 21);
            this.btnChainName.TabIndex = 24;
            this.btnChainName.Text = "...";
            this.btnChainName.UseVisualStyleBackColor = true;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(255, 34);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(28, 21);
            this.btnYear.TabIndex = 25;
            this.btnYear.Text = "...";
            this.btnYear.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(255, 88);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(28, 21);
            this.btnWeek.TabIndex = 27;
            this.btnWeek.Text = "...";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(255, 61);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(28, 21);
            this.btnMonth.TabIndex = 26;
            this.btnMonth.Text = "...";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // btnGroupname
            // 
            this.btnGroupname.Location = new System.Drawing.Point(255, 195);
            this.btnGroupname.Name = "btnGroupname";
            this.btnGroupname.Size = new System.Drawing.Size(28, 21);
            this.btnGroupname.TabIndex = 31;
            this.btnGroupname.Text = "...";
            this.btnGroupname.UseVisualStyleBackColor = true;
            // 
            // btnBarname
            // 
            this.btnBarname.Location = new System.Drawing.Point(255, 169);
            this.btnBarname.Name = "btnBarname";
            this.btnBarname.Size = new System.Drawing.Size(28, 21);
            this.btnBarname.TabIndex = 30;
            this.btnBarname.Text = "...";
            this.btnBarname.UseVisualStyleBackColor = true;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(255, 142);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(28, 21);
            this.btnBarcode.TabIndex = 29;
            this.btnBarcode.Text = "...";
            this.btnBarcode.UseVisualStyleBackColor = true;
            // 
            // btnShopcode
            // 
            this.btnShopcode.Location = new System.Drawing.Point(255, 115);
            this.btnShopcode.Name = "btnShopcode";
            this.btnShopcode.Size = new System.Drawing.Size(28, 21);
            this.btnShopcode.TabIndex = 28;
            this.btnShopcode.Text = "...";
            this.btnShopcode.UseVisualStyleBackColor = true;
            // 
            // btnCostPrice
            // 
            this.btnCostPrice.Location = new System.Drawing.Point(255, 303);
            this.btnCostPrice.Name = "btnCostPrice";
            this.btnCostPrice.Size = new System.Drawing.Size(28, 21);
            this.btnCostPrice.TabIndex = 35;
            this.btnCostPrice.Text = "...";
            this.btnCostPrice.UseVisualStyleBackColor = true;
            // 
            // btnSilesValue
            // 
            this.btnSilesValue.Location = new System.Drawing.Point(255, 277);
            this.btnSilesValue.Name = "btnSilesValue";
            this.btnSilesValue.Size = new System.Drawing.Size(28, 21);
            this.btnSilesValue.TabIndex = 34;
            this.btnSilesValue.Text = "...";
            this.btnSilesValue.UseVisualStyleBackColor = true;
            // 
            // btnSilesItem
            // 
            this.btnSilesItem.Location = new System.Drawing.Point(255, 250);
            this.btnSilesItem.Name = "btnSilesItem";
            this.btnSilesItem.Size = new System.Drawing.Size(28, 21);
            this.btnSilesItem.TabIndex = 33;
            this.btnSilesItem.Text = "...";
            this.btnSilesItem.UseVisualStyleBackColor = true;
            // 
            // btnProducerBrand
            // 
            this.btnProducerBrand.Location = new System.Drawing.Point(255, 223);
            this.btnProducerBrand.Name = "btnProducerBrand";
            this.btnProducerBrand.Size = new System.Drawing.Size(28, 21);
            this.btnProducerBrand.TabIndex = 32;
            this.btnProducerBrand.Text = "...";
            this.btnProducerBrand.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 397);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lead To General View";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblChainName;
        private System.Windows.Forms.ComboBox cbChainName;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.ComboBox cbCostPrice;
        private System.Windows.Forms.Label lblSilesValue;
        private System.Windows.Forms.ComboBox cbSilesValue;
        private System.Windows.Forms.Label lblSilesItem;
        private System.Windows.Forms.ComboBox cbSilesItem;
        private System.Windows.Forms.Label lblProducerBrand;
        private System.Windows.Forms.ComboBox cbProducerBrand;
        private System.Windows.Forms.Label lblGroupname;
        private System.Windows.Forms.ComboBox cbGroupname;
        private System.Windows.Forms.Label lblBarname;
        private System.Windows.Forms.ComboBox cbBarname;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.ComboBox cbBarcode;
        private System.Windows.Forms.Label lblShopcode;
        private System.Windows.Forms.ComboBox cbShopcode;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.ComboBox cbWeek;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnCostPrice;
        private System.Windows.Forms.Button btnSilesValue;
        private System.Windows.Forms.Button btnSilesItem;
        private System.Windows.Forms.Button btnProducerBrand;
        private System.Windows.Forms.Button btnGroupname;
        private System.Windows.Forms.Button btnBarname;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnShopcode;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnChainName;
    }
}

