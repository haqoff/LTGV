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
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnProccess = new System.Windows.Forms.Button();
            this.btnCostPrice = new System.Windows.Forms.Button();
            this.btnSalesValue = new System.Windows.Forms.Button();
            this.btnSalesItem = new System.Windows.Forms.Button();
            this.btnProducerBrand = new System.Windows.Forms.Button();
            this.btnGroupname = new System.Windows.Forms.Button();
            this.btnBarname = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnShopcode = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnChainName = new System.Windows.Forms.Button();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.cbCostPrice = new System.Windows.Forms.ComboBox();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.cbSalesValue = new System.Windows.Forms.ComboBox();
            this.lblSalesItem = new System.Windows.Forms.Label();
            this.cbSalesItem = new System.Windows.Forms.ComboBox();
            this.lblProducerBrand = new System.Windows.Forms.Label();
            this.cbProducerBrand = new System.Windows.Forms.ComboBox();
            this.lblGroupname = new System.Windows.Forms.Label();
            this.cbGroupname = new System.Windows.Forms.ComboBox();
            this.lblBarname = new System.Windows.Forms.Label();
            this.cbBarname = new System.Windows.Forms.ComboBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.cbBarcode = new System.Windows.Forms.ComboBox();
            this.lblShopcode = new System.Windows.Forms.Label();
            this.cbShopcode = new System.Windows.Forms.ComboBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblChainName = new System.Windows.Forms.Label();
            this.cbChainName = new System.Windows.Forms.ComboBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
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
            this.miOpen,
            this.miClose});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(121, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(121, 22);
            this.miClose.Text = "Закрыть";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.btnProccess);
            this.pMain.Controls.Add(this.btnCostPrice);
            this.pMain.Controls.Add(this.btnSalesValue);
            this.pMain.Controls.Add(this.btnSalesItem);
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
            this.pMain.Controls.Add(this.lblSalesValue);
            this.pMain.Controls.Add(this.cbSalesValue);
            this.pMain.Controls.Add(this.lblSalesItem);
            this.pMain.Controls.Add(this.cbSalesItem);
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
            this.pMain.Enabled = false;
            this.pMain.Location = new System.Drawing.Point(12, 37);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(287, 360);
            this.pMain.TabIndex = 1;
            // 
            // btnProccess
            // 
            this.btnProccess.Location = new System.Drawing.Point(115, 331);
            this.btnProccess.Name = "btnProccess";
            this.btnProccess.Size = new System.Drawing.Size(75, 23);
            this.btnProccess.TabIndex = 36;
            this.btnProccess.Text = "Обработать";
            this.btnProccess.UseVisualStyleBackColor = true;
            this.btnProccess.Click += new System.EventHandler(this.btnProccess_Click);
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
            // btnSalesValue
            // 
            this.btnSalesValue.Location = new System.Drawing.Point(255, 277);
            this.btnSalesValue.Name = "btnSalesValue";
            this.btnSalesValue.Size = new System.Drawing.Size(28, 21);
            this.btnSalesValue.TabIndex = 34;
            this.btnSalesValue.Text = "...";
            this.btnSalesValue.UseVisualStyleBackColor = true;
            // 
            // btnSalesItem
            // 
            this.btnSalesItem.Location = new System.Drawing.Point(255, 250);
            this.btnSalesItem.Name = "btnSalesItem";
            this.btnSalesItem.Size = new System.Drawing.Size(28, 21);
            this.btnSalesItem.TabIndex = 33;
            this.btnSalesItem.Text = "...";
            this.btnSalesItem.UseVisualStyleBackColor = true;
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
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(255, 34);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(28, 21);
            this.btnYear.TabIndex = 25;
            this.btnYear.Text = "...";
            this.btnYear.UseVisualStyleBackColor = true;
            // 
            // btnChainName
            // 
            this.btnChainName.Location = new System.Drawing.Point(255, 7);
            this.btnChainName.Name = "btnChainName";
            this.btnChainName.Size = new System.Drawing.Size(28, 21);
            this.btnChainName.TabIndex = 24;
            this.btnChainName.Text = "...";
            this.btnChainName.UseVisualStyleBackColor = false;
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
            // lblSalesValue
            // 
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Location = new System.Drawing.Point(3, 280);
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(63, 13);
            this.lblSalesValue.TabIndex = 21;
            this.lblSalesValue.Text = "SalesValue:";
            // 
            // cbSalesValue
            // 
            this.cbSalesValue.FormattingEnabled = true;
            this.cbSalesValue.Location = new System.Drawing.Point(74, 277);
            this.cbSalesValue.Name = "cbSalesValue";
            this.cbSalesValue.Size = new System.Drawing.Size(175, 21);
            this.cbSalesValue.TabIndex = 20;
            // 
            // lblSalesItem
            // 
            this.lblSalesItem.AutoSize = true;
            this.lblSalesItem.Location = new System.Drawing.Point(3, 253);
            this.lblSalesItem.Name = "lblSalesItem";
            this.lblSalesItem.Size = new System.Drawing.Size(56, 13);
            this.lblSalesItem.TabIndex = 19;
            this.lblSalesItem.Text = "SalesItem:";
            // 
            // cbSalesItem
            // 
            this.cbSalesItem.FormattingEnabled = true;
            this.cbSalesItem.Location = new System.Drawing.Point(74, 250);
            this.cbSalesItem.Name = "cbSalesItem";
            this.cbSalesItem.Size = new System.Drawing.Size(175, 21);
            this.cbSalesItem.TabIndex = 18;
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
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(0, 397);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(311, 12);
            this.pbProgress.TabIndex = 37;
            this.pbProgress.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 409);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.pMain);
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
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.ComboBox cbSalesValue;
        private System.Windows.Forms.Label lblSalesItem;
        private System.Windows.Forms.ComboBox cbSalesItem;
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
        private System.Windows.Forms.Button btnSalesValue;
        private System.Windows.Forms.Button btnSalesItem;
        private System.Windows.Forms.Button btnProducerBrand;
        private System.Windows.Forms.Button btnGroupname;
        private System.Windows.Forms.Button btnBarname;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnShopcode;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnChainName;
        private System.Windows.Forms.Button btnProccess;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ToolStripMenuItem miClose;
    }
}

