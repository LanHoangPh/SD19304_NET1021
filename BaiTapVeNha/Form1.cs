namespace BaiTapVeNha
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_login.Text == "admim" && textBox2_pass.Text == "1234")
            {
                if (checkBox1.Checked)
                {
                    MessageBox.Show("Đăng Nhập Thành Công !");
                    this.Hide();
                    new TinhLai().ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Vui lòng xác nhận Bạn không phải là RoBot !");
                }

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công mời đăng nhập lại !");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1_login.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1_login.BackColor = Color.Yellow;
        }

        private void textBox1_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_pass.Focus();
            }
        }

        private void textBox2_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                button1_login.Focus();
            }
        }
    }
}
