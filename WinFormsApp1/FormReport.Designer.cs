namespace WinFormsApp1
{
    partial class FormReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblHeaderSub = new Label();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnShow = new Button();
            pnlOrders = new Panel();
            lblOrdersCap = new Label();
            lblOrders = new Label();
            pnlRevenue = new Panel();
            lblRevenueCap = new Label();
            lblRevenue = new Label();
            pnlAverage = new Panel();
            lblAverageCap = new Label();
            lblAverage = new Label();
            tabReport = new TabControl();
            tabProducts = new TabPage();
            dgvProducts = new DataGridView();
            tabPayments = new TabPage();
            dgvPayments = new DataGridView();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlAverage.SuspendLayout();
            tabReport.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(860, 72);
            pnlHeader.TabIndex = 0;
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(lblHeaderSub);
            // 
            // lblHeader
            // 
            lblHeader.Text = "รายงานยอดขาย";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "สรุปตามช่วงวันที่";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblFrom
            // 
            lblFrom.Text = "ตั้งแต่";
            lblFrom.Location = new Point(24, 88);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(60, 30);
            lblFrom.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(86, 86);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(190, 32);
            dtpFrom.TabIndex = 4;
            // 
            // lblTo
            // 
            lblTo.Text = "ถึง";
            lblTo.Location = new Point(292, 88);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(40, 30);
            lblTo.TabIndex = 5;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(334, 86);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(190, 32);
            dtpTo.TabIndex = 6;
            // 
            // btnShow
            // 
            btnShow.Text = "แสดงรายงาน";
            btnShow.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnShow.BackColor = Color.FromArgb(78, 52, 46);
            btnShow.ForeColor = Color.White;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.Location = new Point(540, 84);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(130, 36);
            btnShow.TabIndex = 7;
            btnShow.Click += btnShow_Click;
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Location = new Point(24, 130);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(260, 84);
            pnlOrders.TabIndex = 8;
            pnlOrders.Controls.Add(lblOrdersCap);
            pnlOrders.Controls.Add(lblOrders);
            // 
            // lblOrdersCap
            // 
            lblOrdersCap.Text = "จำนวนออเดอร์";
            lblOrdersCap.Font = new Font("Leelawadee UI", 9.5F);
            lblOrdersCap.ForeColor = Color.FromArgb(97, 97, 97);
            lblOrdersCap.Location = new Point(12, 6);
            lblOrdersCap.Name = "lblOrdersCap";
            lblOrdersCap.Size = new Size(236, 26);
            lblOrdersCap.TabIndex = 9;
            // 
            // lblOrders
            // 
            lblOrders.Text = "0";
            lblOrders.Font = new Font("Leelawadee UI", 20F, FontStyle.Bold);
            lblOrders.ForeColor = Color.FromArgb(141, 90, 50);
            lblOrders.Location = new Point(12, 32);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(236, 44);
            lblOrders.TabIndex = 10;
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Location = new Point(300, 130);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(260, 84);
            pnlRevenue.TabIndex = 11;
            pnlRevenue.Controls.Add(lblRevenueCap);
            pnlRevenue.Controls.Add(lblRevenue);
            // 
            // lblRevenueCap
            // 
            lblRevenueCap.Text = "ยอดขายสุทธิ (บาท)";
            lblRevenueCap.Font = new Font("Leelawadee UI", 9.5F);
            lblRevenueCap.ForeColor = Color.FromArgb(97, 97, 97);
            lblRevenueCap.Location = new Point(12, 6);
            lblRevenueCap.Name = "lblRevenueCap";
            lblRevenueCap.Size = new Size(236, 26);
            lblRevenueCap.TabIndex = 12;
            // 
            // lblRevenue
            // 
            lblRevenue.Text = "0.00";
            lblRevenue.Font = new Font("Leelawadee UI", 20F, FontStyle.Bold);
            lblRevenue.ForeColor = Color.FromArgb(141, 90, 50);
            lblRevenue.Location = new Point(12, 32);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(236, 44);
            lblRevenue.TabIndex = 13;
            // 
            // pnlAverage
            // 
            pnlAverage.BackColor = Color.White;
            pnlAverage.Location = new Point(576, 130);
            pnlAverage.Name = "pnlAverage";
            pnlAverage.Size = new Size(260, 84);
            pnlAverage.TabIndex = 14;
            pnlAverage.Controls.Add(lblAverageCap);
            pnlAverage.Controls.Add(lblAverage);
            // 
            // lblAverageCap
            // 
            lblAverageCap.Text = "เฉลี่ยต่อออเดอร์ (บาท)";
            lblAverageCap.Font = new Font("Leelawadee UI", 9.5F);
            lblAverageCap.ForeColor = Color.FromArgb(97, 97, 97);
            lblAverageCap.Location = new Point(12, 6);
            lblAverageCap.Name = "lblAverageCap";
            lblAverageCap.Size = new Size(236, 26);
            lblAverageCap.TabIndex = 15;
            // 
            // lblAverage
            // 
            lblAverage.Text = "0.00";
            lblAverage.Font = new Font("Leelawadee UI", 20F, FontStyle.Bold);
            lblAverage.ForeColor = Color.FromArgb(141, 90, 50);
            lblAverage.Location = new Point(12, 32);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(236, 44);
            lblAverage.TabIndex = 16;
            // 
            // tabReport
            // 
            tabReport.Location = new Point(24, 226);
            tabReport.Name = "tabReport";
            tabReport.Size = new Size(812, 298);
            tabReport.TabIndex = 17;
            tabReport.Controls.Add(tabProducts);
            tabReport.Controls.Add(tabPayments);
            // 
            // tabProducts
            // 
            tabProducts.Text = "ตามสินค้า (ก่อนส่วนลด)";
            tabProducts.Location = new Point(4, 34);
            tabProducts.Name = "tabProducts";
            tabProducts.Size = new Size(804, 260);
            tabProducts.TabIndex = 18;
            tabProducts.Controls.Add(dgvProducts);
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(804, 260);
            dgvProducts.TabIndex = 19;
            // 
            // tabPayments
            // 
            tabPayments.Text = "ตามวิธีชำระเงิน";
            tabPayments.Location = new Point(4, 34);
            tabPayments.Name = "tabPayments";
            tabPayments.Size = new Size(804, 260);
            tabPayments.TabIndex = 20;
            tabPayments.Controls.Add(dgvPayments);
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.BackgroundColor = SystemColors.Window;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.Location = new Point(0, 0);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.Size = new Size(804, 260);
            dgvPayments.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.Text = "กลับเมนูหลัก";
            btnBack.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(215, 204, 200);
            btnBack.ForeColor = Color.FromArgb(78, 52, 46);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(24, 536);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 44);
            btnBack.TabIndex = 22;
            btnBack.Click += btnBack_Click;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnShow);
            Controls.Add(pnlOrders);
            Controls.Add(pnlRevenue);
            Controls.Add(pnlAverage);
            Controls.Add(tabReport);
            Controls.Add(btnBack);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "รายงานยอดขาย";
            Load += FormReport_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlAverage.ResumeLayout(false);
            pnlAverage.PerformLayout();
            tabReport.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnShow;
        private Panel pnlOrders;
        private Label lblOrdersCap;
        private Label lblOrders;
        private Panel pnlRevenue;
        private Label lblRevenueCap;
        private Label lblRevenue;
        private Panel pnlAverage;
        private Label lblAverageCap;
        private Label lblAverage;
        private TabControl tabReport;
        private TabPage tabProducts;
        private DataGridView dgvProducts;
        private TabPage tabPayments;
        private DataGridView dgvPayments;
        private Button btnBack;
    }
}
