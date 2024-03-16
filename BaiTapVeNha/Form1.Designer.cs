namespace BaiTapVeNha
{
    partial class From1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1_login = new TextBox();
            textBox2_pass = new TextBox();
            login_nun = new Label();
            mk_nun = new Label();
            checkBox1 = new CheckBox();
            button1_login = new Button();
            SuspendLayout();
            // 
            // textBox1_login
            // 
            textBox1_login.Font = new Font("Segoe UI", 10.8F);
            textBox1_login.ForeColor = Color.Black;
            textBox1_login.Location = new Point(261, 48);
            textBox1_login.Name = "textBox1_login";
            textBox1_login.PlaceholderText = "Mời nhập tên người dùng";
            textBox1_login.Size = new Size(309, 31);
            textBox1_login.TabIndex = 0;
            textBox1_login.KeyDown += textBox1_login_KeyDown;
            // 
            // textBox2_pass
            // 
            textBox2_pass.Font = new Font("Segoe UI", 10.8F);
            textBox2_pass.Location = new Point(261, 110);
            textBox2_pass.Name = "textBox2_pass";
            textBox2_pass.PasswordChar = '*';
            textBox2_pass.PlaceholderText = "Mời nhập mật khẩu";
            textBox2_pass.Size = new Size(309, 31);
            textBox2_pass.TabIndex = 1;
            textBox2_pass.KeyDown += textBox2_pass_KeyDown;
            // 
            // login_nun
            // 
            login_nun.AutoSize = true;
            login_nun.Font = new Font("Segoe UI", 10.8F);
            login_nun.Location = new Point(134, 55);
            login_nun.Name = "login_nun";
            login_nun.Size = new Size(91, 25);
            login_nun.TabIndex = 2;
            login_nun.Text = "Username";
            // 
            // mk_nun
            // 
            mk_nun.AutoSize = true;
            mk_nun.Font = new Font("Segoe UI", 10.8F);
            mk_nun.Location = new Point(134, 113);
            mk_nun.Name = "mk_nun";
            mk_nun.Size = new Size(87, 25);
            mk_nun.TabIndex = 3;
            mk_nun.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 10.8F);
            checkBox1.Location = new Point(294, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(219, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Tôi không phải là robot";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1_login
            // 
            button1_login.BackColor = Color.Yellow;
            button1_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1_login.ForeColor = Color.Red;
            button1_login.Location = new Point(327, 250);
            button1_login.Name = "button1_login";
            button1_login.Size = new Size(175, 61);
            button1_login.TabIndex = 5;
            button1_login.Text = "Đăng Nhập";
            button1_login.UseVisualStyleBackColor = false;
            button1_login.Click += button1_Click;
            button1_login.MouseLeave += button1_MouseLeave;
            button1_login.MouseHover += button1_MouseHover;
            // 
            // From1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tải_xuống__2_;
            ClientSize = new Size(800, 450);
            Controls.Add(button1_login);
            Controls.Add(checkBox1);
            Controls.Add(mk_nun);
            Controls.Add(login_nun);
            Controls.Add(textBox2_pass);
            Controls.Add(textBox1_login);
            Name = "From1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_login;
        private TextBox textBox2_pass;
        private Label login_nun;
        private Label mk_nun;
        private CheckBox checkBox1;
        private Button button1_login;
    }
}
