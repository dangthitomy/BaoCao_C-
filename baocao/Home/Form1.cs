using System;
using System.Drawing;
using System.Windows.Forms;

namespace baocao
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray; // Màu nền của trang chủ
        }

        private void btnGoToManagement_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Ẩn trang chủ
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã khởi tạo ở đây nếu cần
        }
    }
}
