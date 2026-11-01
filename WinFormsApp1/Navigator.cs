namespace WinFormsApp1
{
    /// <summary>
    ///  สลับหน้าจอ โดยเปิดฟอร์มถัดไปในตำแหน่งเดิมแล้วปิดฟอร์มปัจจุบัน
    ///  โปรแกรมจะจบเมื่อฟอร์มที่เปิดอยู่ถูกปิดโดยผู้ใช้
    /// </summary>
    public static class Navigator
    {
        public static ApplicationContext Context { get; } = new();

        public static void Go(Form current, Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Location = current.Location;
            Context.MainForm = next;
            next.Show();
            current.Close();
        }
    }
}
