namespace WinFormsApp1
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private OrderLine? SelectedLine =>
            dgvCart.CurrentRow?.Index is int index && index < AppData.Current.Lines.Count
                ? AppData.Current.Lines[index]
                : null;

        private void FormCart_Load(object? sender, EventArgs e)
        {
            dgvCart.Columns.Add("colName", "รายการ");
            dgvCart.Columns.Add("colDetail", "รายละเอียด");
            dgvCart.Columns.Add("colPrice", "ราคา/หน่วย");
            dgvCart.Columns.Add("colQty", "จำนวน");
            dgvCart.Columns.Add("colTotal", "รวม");
            dgvCart.Columns["colName"]!.Width = 200;
            dgvCart.Columns["colDetail"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCart.Columns["colPrice"]!.Width = 110;
            dgvCart.Columns["colQty"]!.Width = 80;
            dgvCart.Columns["colTotal"]!.Width = 110;
            ShowLines();
        }

        private void ShowLines()
        {
            dgvCart.Rows.Clear();
            foreach (OrderLine line in AppData.Current.Lines)
                dgvCart.Rows.Add(line.Name, line.Detail, line.UnitPrice.ToString("N2"), line.Qty, line.Total.ToString("N2"));

            lblTotal.Text = $"รวม {AppData.Current.Subtotal:N2} บาท";
        }

        private void dgvCart_SelectionChanged(object? sender, EventArgs e)
        {
            if (SelectedLine is OrderLine line)
                numQty.Value = Math.Min(line.Qty, numQty.Maximum);
        }

        private void btnUpdateQty_Click(object? sender, EventArgs e)
        {
            if (SelectedLine is not OrderLine line)
                return;

            line.Qty = (int)numQty.Value;
            ShowLines();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            if (SelectedLine is not OrderLine line)
                return;

            AppData.Current.Lines.Remove(line);
            ShowLines();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            if (AppData.Current.Lines.Count == 0)
                return;

            if (MessageBox.Show("ต้องการล้างตะกร้าทั้งหมดหรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AppData.Current.Lines.Clear();
                ShowLines();
            }
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            if (AppData.Current.Lines.Count == 0)
            {
                lblError.Text = "ตะกร้าว่าง กรุณาเลือกสินค้าก่อนชำระเงิน";
                return;
            }

            Navigator.Go(this, new FormPayment());
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormBakery());
        }
    }
}
