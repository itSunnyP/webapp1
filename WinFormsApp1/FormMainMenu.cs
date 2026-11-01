namespace WinFormsApp1
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object? sender, EventArgs e)
        {
            lblWelcome.Text = $"ยินดีต้อนรับ คุณ{AppData.StaffName}  |  ออเดอร์ทั้งหมด {AppData.Orders.Count} รายการ";
            ShowClock();
        }

        private void tmrClock_Tick(object? sender, EventArgs e)
        {
            ShowClock();
        }

        private void ShowClock()
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnNewOrder_Click(object? sender, EventArgs e)
        {
            AppData.StartNewOrder();
            Navigator.Go(this, new FormCustomer());
        }

        private void btnHistory_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormHistory());
        }

        private void btnReport_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormReport());
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            AppData.StaffName = "";
            Navigator.Go(this, new FormStart());
        }
    }
}
