namespace WinFormsApp1
{
    partial class FormCart
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
            dgvCart = new DataGridView();
            lblQty = new Label();
            numQty = new NumericUpDown();
            btnUpdateQty = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            lblTotal = new Label();
            lblError = new Label();
            btnBack = new Button();
            btnNext = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
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
            lblHeader.Text = "ตะกร้าสินค้า";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ขั้นตอนที่ 4 จาก 5";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.BackgroundColor = SystemColors.Window;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.MultiSelect = false;
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Location = new Point(24, 88);
            dgvCart.Name = "dgvCart";
            dgvCart.Size = new Size(812, 320);
            dgvCart.TabIndex = 3;
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;
            // 
            // lblQty
            // 
            lblQty.Text = "จำนวน";
            lblQty.Location = new Point(24, 424);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(70, 30);
            lblQty.TabIndex = 4;
            // 
            // numQty
            // 
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Location = new Point(96, 422);
            numQty.Name = "numQty";
            numQty.Size = new Size(80, 32);
            numQty.TabIndex = 5;
            // 
            // btnUpdateQty
            // 
            btnUpdateQty.Text = "แก้จำนวน";
            btnUpdateQty.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnUpdateQty.BackColor = Color.FromArgb(215, 204, 200);
            btnUpdateQty.ForeColor = Color.FromArgb(78, 52, 46);
            btnUpdateQty.FlatStyle = FlatStyle.Flat;
            btnUpdateQty.Cursor = Cursors.Hand;
            btnUpdateQty.FlatAppearance.BorderSize = 0;
            btnUpdateQty.Location = new Point(186, 418);
            btnUpdateQty.Name = "btnUpdateQty";
            btnUpdateQty.Size = new Size(120, 40);
            btnUpdateQty.TabIndex = 6;
            btnUpdateQty.Click += btnUpdateQty_Click;
            // 
            // btnRemove
            // 
            btnRemove.Text = "ลบรายการ";
            btnRemove.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnRemove.BackColor = Color.FromArgb(215, 204, 200);
            btnRemove.ForeColor = Color.FromArgb(78, 52, 46);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Location = new Point(316, 418);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 40);
            btnRemove.TabIndex = 7;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Text = "ล้างตะกร้า";
            btnClear.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnClear.BackColor = Color.FromArgb(198, 40, 40);
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Location = new Point(446, 418);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 8;
            btnClear.Click += btnClear_Click;
            // 
            // lblTotal
            // 
            lblTotal.Text = "รวม 0.00 บาท";
            lblTotal.Font = new Font("Leelawadee UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(141, 90, 50);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(576, 418);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(260, 40);
            lblTotal.TabIndex = 9;
            // 
            // lblError
            // 
            lblError.Text = "";
            lblError.ForeColor = Color.FromArgb(198, 40, 40);
            lblError.Location = new Point(24, 480);
            lblError.Name = "lblError";
            lblError.Size = new Size(812, 26);
            lblError.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Text = "ย้อนกลับ";
            btnBack.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(215, 204, 200);
            btnBack.ForeColor = Color.FromArgb(78, 52, 46);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(24, 536);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 44);
            btnBack.TabIndex = 11;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Text = "ชำระเงิน";
            btnNext.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnNext.BackColor = Color.FromArgb(78, 52, 46);
            btnNext.ForeColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Location = new Point(696, 536);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 44);
            btnNext.TabIndex = 12;
            btnNext.Click += btnNext_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(dgvCart);
            Controls.Add(lblQty);
            Controls.Add(numQty);
            Controls.Add(btnUpdateQty);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(lblError);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ตะกร้าสินค้า";
            Load += FormCart_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private DataGridView dgvCart;
        private Label lblQty;
        private NumericUpDown numQty;
        private Button btnUpdateQty;
        private Button btnRemove;
        private Button btnClear;
        private Label lblTotal;
        private Label lblError;
        private Button btnBack;
        private Button btnNext;
    }
}
