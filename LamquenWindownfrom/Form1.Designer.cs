namespace LamquenWindownfrom
{
    partial class Login
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
            btn_Chọn = new Button();
            textBox1 = new TextBox();
            tbt_Input = new Label();
            Nam_input = new CheckBox();
            Nữ_Input = new CheckBox();
            mk_Input = new Label();
            textBox2 = new TextBox();
            gt_Input = new Label();
            rb_Input = new CheckBox();
            SuspendLayout();
            // 
            // btn_Chọn
            // 
            btn_Chọn.BackColor = Color.Yellow;
            btn_Chọn.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Chọn.ForeColor = Color.Red;
            btn_Chọn.Location = new Point(306, 278);
            btn_Chọn.Name = "btn_Chọn";
            btn_Chọn.Size = new Size(343, 83);
            btn_Chọn.TabIndex = 0;
            btn_Chọn.Text = "Đăng Nhập";
            btn_Chọn.UseVisualStyleBackColor = false;
            btn_Chọn.Click += btn_Chọn_Click;
            btn_Chọn.MouseLeave += btn_Chọn_MouseLeave;
            btn_Chọn.MouseHover += btn_Chọn_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Hãy nhập tên của bạn";
            textBox1.Size = new Size(576, 27);
            textBox1.TabIndex = 1;
            // 
            // tbt_Input
            // 
            tbt_Input.AutoSize = true;
            tbt_Input.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbt_Input.Location = new Point(78, 57);
            tbt_Input.Name = "tbt_Input";
            tbt_Input.Size = new Size(148, 28);
            tbt_Input.TabIndex = 2;
            tbt_Input.Text = "Tên đăng nhập";
            // 
            // Nam_input
            // 
            Nam_input.AutoSize = true;
            Nam_input.Location = new Point(232, 167);
            Nam_input.Name = "Nam_input";
            Nam_input.Size = new Size(51, 24);
            Nam_input.TabIndex = 3;
            Nam_input.Text = "Nữ";
            Nam_input.UseVisualStyleBackColor = true;
            // 
            // Nữ_Input
            // 
            Nữ_Input.AutoSize = true;
            Nữ_Input.Location = new Point(321, 167);
            Nữ_Input.Name = "Nữ_Input";
            Nữ_Input.Size = new Size(63, 24);
            Nữ_Input.TabIndex = 4;
            Nữ_Input.Text = "Nam";
            Nữ_Input.UseVisualStyleBackColor = true;
            // 
            // mk_Input
            // 
            mk_Input.AutoSize = true;
            mk_Input.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            mk_Input.Location = new Point(87, 102);
            mk_Input.Name = "mk_Input";
            mk_Input.Size = new Size(98, 28);
            mk_Input.TabIndex = 5;
            mk_Input.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 103);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Mời nhập mật khẩu";
            textBox2.Size = new Size(576, 27);
            textBox2.TabIndex = 6;
            // 
            // gt_Input
            // 
            gt_Input.AutoSize = true;
            gt_Input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gt_Input.Location = new Point(87, 160);
            gt_Input.Name = "gt_Input";
            gt_Input.Size = new Size(110, 28);
            gt_Input.TabIndex = 7;
            gt_Input.Text = "Giới Tính :";
            // 
            // rb_Input
            // 
            rb_Input.AutoSize = true;
            rb_Input.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rb_Input.Location = new Point(360, 226);
            rb_Input.Name = "rb_Input";
            rb_Input.Size = new Size(219, 29);
            rb_Input.TabIndex = 8;
            rb_Input.Text = "Tôi không phải là robot";
            rb_Input.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 440);
            Controls.Add(rb_Input);
            Controls.Add(gt_Input);
            Controls.Add(textBox2);
            Controls.Add(mk_Input);
            Controls.Add(Nữ_Input);
            Controls.Add(Nam_input);
            Controls.Add(tbt_Input);
            Controls.Add(textBox1);
            Controls.Add(btn_Chọn);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Chọn;
        private TextBox textBox1;
        private Label tbt_Input;
        private CheckBox Nam_input;
        private CheckBox Nữ_Input;
        private Label mk_Input;
        private TextBox textBox2;
        private Label gt_Input;
        private CheckBox rb_Input;
    }
}
