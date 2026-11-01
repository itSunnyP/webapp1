namespace WinFormsApp1
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object? sender, EventArgs e)
        {
            lblMemberCap.Text = $"ส่วนลดลูกค้า ({AppData.Current.CustomerType})";
            ShowSummary();
        }

        private void ShowSummary()
        {
            Order order = AppData.Current;
            lblSubtotal.Text = order.Subtotal.ToString("N2");
            lblMember.Text = order.MemberDiscount.ToString("N2");
            lblCoupon.Text = order.CouponDiscount.ToString("N2");
            lblTotal.Text = order.Total.ToString("N2");
            ShowChange();
        }

        private void ShowChange()
        {
            if (decimal.TryParse(txtReceived.Text, out decimal received) && received >= AppData.Current.Total)
                lblChange.Text = $"เงินทอน {received - AppData.Current.Total:N2} บาท";
            else
                lblChange.Text = "เงินทอน -";
        }

        private void btnApplyCoupon_Click(object? sender, EventArgs e)
        {
            bool valid = txtCoupon.Text.Trim().Equals(Order.CouponCode, StringComparison.OrdinalIgnoreCase);
            AppData.Current.UsedCoupon = valid;
            lblError.Text = valid ? "" : "รหัสคูปองไม่ถูกต้อง";
            ShowSummary();
        }

        private void Method_Changed(object? sender, EventArgs e)
        {
            pnlCash.Visible = rdoCash.Checked;
            lblMethodInfo.Visible = !rdoCash.Checked;
            lblError.Text = "";
        }

        private void txtReceived_TextChanged(object? sender, EventArgs e)
        {
            lblError.Text = "";
            ShowChange();
        }

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            Order order = AppData.Current;

            if (rdoCash.Checked)
            {
                if (!decimal.TryParse(txtReceived.Text, out decimal received) || received < order.Total)
                {
                    lblError.Text = "กรุณากรอกจำนวนเงินที่รับมาให้ครบตามยอดสุทธิ";
                    txtReceived.Focus();
                    return;
                }
                order.PayMethod = "เงินสด";
                order.Received = received;
            }
            else
            {
                order.PayMethod = rdoTransfer.Checked ? "โอนเงิน" : "บัตรเครดิต";
                order.Received = order.Total;
            }

            AppData.CompleteCurrentOrder();
            Navigator.Go(this, new FormReceipt());
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormCart());
        }
    }
}
