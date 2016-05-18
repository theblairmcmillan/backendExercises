namespace YahooStockDownloader
{
    partial class YahooDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.indexComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasDaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnChoosesSavePath = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboFromMonth = new System.Windows.Forms.ComboBox();
            this.nudFromDate = new System.Windows.Forms.NumericUpDown();
            this.nudFromYear = new System.Windows.Forms.NumericUpDown();
            this.cboToMonth = new System.Windows.Forms.ComboBox();
            this.nudToDay = new System.Windows.Forms.NumericUpDown();
            this.nudToYear = new System.Windows.Forms.NumericUpDown();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.lblTickers = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexComponentsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(758, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // indexComponentsToolStripMenuItem
            // 
            this.indexComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dow30ToolStripMenuItem,
            this.sP100ToolStripMenuItem,
            this.nasDaq100ToolStripMenuItem});
            this.indexComponentsToolStripMenuItem.Name = "indexComponentsToolStripMenuItem";
            this.indexComponentsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.indexComponentsToolStripMenuItem.Text = "Index Components";
            // 
            // dow30ToolStripMenuItem
            // 
            this.dow30ToolStripMenuItem.Name = "dow30ToolStripMenuItem";
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            // 
            // sP100ToolStripMenuItem
            // 
            this.sP100ToolStripMenuItem.Name = "sP100ToolStripMenuItem";
            this.sP100ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sP100ToolStripMenuItem.Text = "S&&P 100";
            // 
            // nasDaq100ToolStripMenuItem
            // 
            this.nasDaq100ToolStripMenuItem.Name = "nasDaq100ToolStripMenuItem";
            this.nasDaq100ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nasDaq100ToolStripMenuItem.Text = "NasDaq 100";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(93, 37);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(58, 13);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "FolderPath";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(157, 30);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(233, 20);
            this.txtSavePath.TabIndex = 3;
            // 
            // btnChoosesSavePath
            // 
            this.btnChoosesSavePath.Location = new System.Drawing.Point(396, 27);
            this.btnChoosesSavePath.Name = "btnChoosesSavePath";
            this.btnChoosesSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnChoosesSavePath.TabIndex = 4;
            this.btnChoosesSavePath.Text = "Choose";
            this.btnChoosesSavePath.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 132);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(12, 158);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date";
            // 
            // cboFromMonth
            // 
            this.cboFromMonth.FormattingEnabled = true;
            this.cboFromMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboFromMonth.Location = new System.Drawing.Point(73, 129);
            this.cboFromMonth.Name = "cboFromMonth";
            this.cboFromMonth.Size = new System.Drawing.Size(121, 21);
            this.cboFromMonth.TabIndex = 7;
            this.cboFromMonth.SelectedIndexChanged += new System.EventHandler(this.cboFromMonth_SelectedIndexChanged);
            // 
            // nudFromDate
            // 
            this.nudFromDate.Location = new System.Drawing.Point(210, 130);
            this.nudFromDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudFromDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFromDate.Name = "nudFromDate";
            this.nudFromDate.Size = new System.Drawing.Size(120, 20);
            this.nudFromDate.TabIndex = 8;
            this.nudFromDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFromYear
            // 
            this.nudFromYear.Location = new System.Drawing.Point(336, 129);
            this.nudFromYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudFromYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudFromYear.Name = "nudFromYear";
            this.nudFromYear.Size = new System.Drawing.Size(120, 20);
            this.nudFromYear.TabIndex = 9;
            this.nudFromYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cboToMonth
            // 
            this.cboToMonth.FormattingEnabled = true;
            this.cboToMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboToMonth.Location = new System.Drawing.Point(73, 158);
            this.cboToMonth.Name = "cboToMonth";
            this.cboToMonth.Size = new System.Drawing.Size(121, 21);
            this.cboToMonth.TabIndex = 10;
            // 
            // nudToDay
            // 
            this.nudToDay.Location = new System.Drawing.Point(210, 159);
            this.nudToDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudToDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToDay.Name = "nudToDay";
            this.nudToDay.Size = new System.Drawing.Size(120, 20);
            this.nudToDay.TabIndex = 11;
            this.nudToDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToYear
            // 
            this.nudToYear.Location = new System.Drawing.Point(336, 159);
            this.nudToYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudToYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudToYear.Name = "nudToYear";
            this.nudToYear.Size = new System.Drawing.Size(120, 20);
            this.nudToYear.TabIndex = 12;
            this.nudToYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Location = new System.Drawing.Point(478, 133);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 13;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(478, 161);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 14;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(478, 184);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 15;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(572, 129);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 16;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(97, 202);
            this.txtTicker.Multiline = true;
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(359, 96);
            this.txtTicker.TabIndex = 17;
            this.txtTicker.Text = "GOOG,AAPL,AMZN";
            // 
            // lblTickers
            // 
            this.lblTickers.AutoSize = true;
            this.lblTickers.Location = new System.Drawing.Point(12, 202);
            this.lblTickers.Name = "lblTickers";
            this.lblTickers.Size = new System.Drawing.Size(79, 13);
            this.lblTickers.TabIndex = 18;
            this.lblTickers.Text = "Ticker Symbols";
            // 
            // YahooDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 310);
            this.Controls.Add(this.lblTickers);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.nudToYear);
            this.Controls.Add(this.nudToDay);
            this.Controls.Add(this.cboToMonth);
            this.Controls.Add(this.nudFromYear);
            this.Controls.Add(this.nudFromDate);
            this.Controls.Add(this.cboFromMonth);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnChoosesSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YahooDownloader";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem indexComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sP100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasDaq100ToolStripMenuItem;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnChoosesSavePath;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboFromMonth;
        private System.Windows.Forms.NumericUpDown nudFromDate;
        private System.Windows.Forms.NumericUpDown nudFromYear;
        private System.Windows.Forms.ComboBox cboToMonth;
        private System.Windows.Forms.NumericUpDown nudToDay;
        private System.Windows.Forms.NumericUpDown nudToYear;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label lblTickers;
    }
}

