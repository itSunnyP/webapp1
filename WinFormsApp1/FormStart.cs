namespace WinFormsApp1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object? sender, EventArgs e)
        {
            lblTitle.Text = ProjectInfo.Title;
            lblSubtitle.Text = ProjectInfo.Subtitle;
            lblName1.Text = ProjectInfo.Member1Name;
            lblId1.Text = ProjectInfo.Member1Id;
            lblName2.Text = ProjectInfo.Member2Name;
            lblId2.Text = ProjectInfo.Member2Id;
            LoadPhoto(picMember1, ProjectInfo.Member1Photo, "รูปสมาชิกคนที่ 1");
            LoadPhoto(picMember2, ProjectInfo.Member2Photo, "รูปสมาชิกคนที่ 2");
        }

        private static void LoadPhoto(PictureBox box, string fileName, string placeholder)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Images", fileName);
            if (File.Exists(path))
            {
                try
                {
                    box.Load(path);
                    return;
                }
                catch (ArgumentException)
                {
                    // ไฟล์ไม่ใช่รูปภาพ ให้แสดงข้อความแทนรูป
                }
            }

            box.Paint += (_, e) => TextRenderer.DrawText(e.Graphics, placeholder, box.Font, box.ClientRectangle,
                Color.DimGray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormLogin());
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
