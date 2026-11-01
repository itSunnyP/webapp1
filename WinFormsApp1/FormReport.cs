namespace WinFormsApp1
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object? sender, EventArgs e)
        {
            dgvProducts.Columns.Add("colName", "สินค้า");
            dgvProducts.Columns.Add("colQty", "จำนวนที่ขาย");
            dgvProducts.Columns.Add("colAmount", "ยอดขาย (บาท)");
            dgvProducts.Columns["colName"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducts.Columns["colQty"]!.Width = 140;
            dgvProducts.Columns["colAmount"]!.Width = 160;

            dgvPayments.Columns.Add("colMethod", "วิธีชำระเงิน");
            dgvPayments.Columns.Add("colCount", "จำนวนออเดอร์");
            dgvPayments.Columns.Add("colAmount", "ยอดสุทธิ (บาท)");
            dgvPayments.Columns["colMethod"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPayments.Columns["colCount"]!.Width = 140;
            dgvPayments.Columns["colAmount"]!.Width = 160;

            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            ShowReport();
        }

        private void btnShow_Click(object? sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("วันที่เริ่มต้นต้องไม่เกินวันที่สิ้นสุด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowReport();
        }

        private void ShowReport()
        {
            List<Order> orders = AppData.Orders
                .Where(order => order.Time.Date >= dtpFrom.Value.Date && order.Time.Date <= dtpTo.Value.Date)
                .ToList();

            decimal revenue = orders.Sum(order => order.Total);
            lblOrders.Text = orders.Count.ToString();
            lblRevenue.Text = revenue.ToString("N2");
            lblAverage.Text = (orders.Count == 0 ? 0 : revenue / orders.Count).ToString("N2");

            dgvProducts.Rows.Clear();
            var products = orders.SelectMany(order => order.Lines)
                .GroupBy(line => line.Name)
                .OrderByDescending(group => group.Sum(line => line.Total));
            foreach (var group in products)
                dgvProducts.Rows.Add(group.Key, group.Sum(line => line.Qty), group.Sum(line => line.Total).ToString("N2"));

            dgvPayments.Rows.Clear();
            foreach (var group in orders.GroupBy(order => order.PayMethod))
                dgvPayments.Rows.Add(group.Key, group.Count(), group.Sum(order => order.Total).ToString("N2"));
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormMainMenu());
        }
    }
}
