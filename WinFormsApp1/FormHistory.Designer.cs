namespace WinFormsApp1
{
    partial class FormHistory
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkDate = new CheckBox();
            dtpDate = new DateTimePicker();
            lvOrders = new ListView();
            txtDetail = new TextBox();
            btnBack = new Button();
            btnDelete = new Button();
            pnlHeader.SuspendLayout();
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
            lblHeader.Text = "ประวัติการสั่งซื้อ";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ค้นหาและดูรายละเอียดย้อนหลัง";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.Text = "ค้นหาชื่อลูกค้า";
            lblSearch.Location = new Point(24, 88);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(110, 30);
            lblSearch.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(140, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 32);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // chkDate
            // 
            chkDate.Text = "เฉพาะวันที่";
            chkDate.Location = new Point(430, 88);
            chkDate.Name = "chkDate";
            chkDate.Size = new Size(130, 30);
            chkDate.TabIndex = 5;
            chkDate.CheckedChanged += Filter_Changed;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(566, 86);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 32);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += Filter_Changed;
            // 
            // lvOrders
            // 
            lvOrders.FullRowSelect = true;
            lvOrders.GridLines = true;
            lvOrders.HideSelection = false;
            lvOrders.MultiSelect = false;
            lvOrders.View = View.Details;
            lvOrders.Location = new Point(24, 128);
            lvOrders.Name = "lvOrders";
            lvOrders.Size = new Size(812, 200);
            lvOrders.TabIndex = 7;
            lvOrders.SelectedIndexChanged += lvOrders_SelectedIndexChanged;
            // 
            // txtDetail
            // 
            txtDetail.Multiline = true;
            txtDetail.ReadOnly = true;
            txtDetail.BackColor = Color.White;
            txtDetail.ScrollBars = ScrollBars.Vertical;
            txtDetail.Location = new Point(24, 338);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(812, 186);
            txtDetail.TabIndex = 8;
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
            btnBack.TabIndex = 9;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Text = "ลบรายการที่เลือก";
            btnDelete.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(666, 536);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 44);
            btnDelete.TabIndex = 10;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(chkDate);
            Controls.Add(dtpDate);
            Controls.Add(lvOrders);
            Controls.Add(txtDetail);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ประวัติการสั่งซื้อ";
            Load += FormHistory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblSearch;
        private TextBox txtSearch;
        private CheckBox chkDate;
        private DateTimePicker dtpDate;
        private ListView lvOrders;
        private TextBox txtDetail;
        private Button btnBack;
        private Button btnDelete;
    }
}
