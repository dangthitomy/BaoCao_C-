using System;
using System.Drawing;
using System.Windows.Forms;

namespace baocao
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Cấu hình màu sắc cho form và các thành phần
            this.BackColor = Color.LightBlue; // Màu nền của form
            tbUsername.BackColor = Color.LightYellow; // Màu nền của ô nhập username
            tbPassword.BackColor = Color.LightYellow; // Màu nền của ô nhập password
            btnLogin.BackColor = Color.LightGreen; // Màu nền của nút đăng nhập
            btnLogin.ForeColor = Color.DarkGreen; // Màu chữ trên nút đăng nhập
            btnExit.BackColor = Color.LightCoral; // Màu nền của nút thoát
            btnExit.ForeColor = Color.White; // Màu chữ trên nút thoát
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username == "tomy" && password == "123456") // Kiểm tra thông tin đăng nhập
            {
                // Mở HomePage sau khi đăng nhập thành công
                HomePage homePage = new HomePage();
                homePage.Show(); // Hiển thị HomePage
                this.Hide(); // Ẩn Form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã khởi tạo ở đây nếu cần
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
