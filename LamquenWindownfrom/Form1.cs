namespace LamquenWindownfrom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btn_Chọn_MouseLeave(object sender, EventArgs e)
        {
            btn_Chọn.BackColor = Color.Yellow;
        }

        private void btn_Chọn_MouseHover(object sender, EventArgs e)
        {
            btn_Chọn.BackColor = Color.LightBlue;
        }

        private void btn_Chọn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                frmHome login = new frmHome();
                MessageBox.Show("Đăng Nhập Thành Công");
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mời nhập tên và mật khẩu");
            }
            
        }
    }
}
