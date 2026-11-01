namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        private const string DemoUser = "admin";
        private const string DemoPassword = "1234";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void chkShowPass_CheckedChanged(object? sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != DemoUser || txtPass.Text != DemoPassword)
            {
                lblError.Text = "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง";
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            AppData.StaffName = txtUser.Text.Trim();
            Navigator.Go(this, new FormMainMenu());
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormStart());
        }
    }
}
