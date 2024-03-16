namespace BaiTapVeNha
{
    partial class TinhLai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1_goctien = new TextBox();
            textBox2_ngvay = new TextBox();
            textBox3_tielelai = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label_ketqua = new Label();
            SuspendLayout();
            // 
            // textBox1_goctien
            // 
            textBox1_goctien.BackColor = SystemColors.Window;
            textBox1_goctien.Font = new Font("Segoe UI", 12F);
            textBox1_goctien.Location = new Point(309, 57);
            textBox1_goctien.Name = "textBox1_goctien";
            textBox1_goctien.PlaceholderText = "Mời nhập số tiền gốc";
            textBox1_goctien.Size = new Size(357, 34);
            textBox1_goctien.TabIndex = 0;
            textBox1_goctien.TextChanged += textBox1_goctien_TextChanged;
            textBox1_goctien.KeyDown += textBox1_goctien_KeyDown;
            // 
            // textBox2_ngvay
            // 
            textBox2_ngvay.Font = new Font("Segoe UI", 12F);
            textBox2_ngvay.Location = new Point(309, 130);
            textBox2_ngvay.Name = "textBox2_ngvay";
            textBox2_ngvay.PlaceholderText = "Mời nhập số ngày vay";
            textBox2_ngvay.Size = new Size(357, 34);
            textBox2_ngvay.TabIndex = 1;
            textBox2_ngvay.TextChanged += textBox2_ngvay_TextChanged;
            textBox2_ngvay.KeyDown += textBox2_ngvay_KeyDown;
            // 
            // textBox3_tielelai
            // 
            textBox3_tielelai.Font = new Font("Segoe UI", 12F);
            textBox3_tielelai.Location = new Point(309, 218);
            textBox3_tielelai.Name = "textBox3_tielelai";
            textBox3_tielelai.PlaceholderText = "Mời nhập tỉ lệ vay theo %";
            textBox3_tielelai.Size = new Size(357, 34);
            textBox3_tielelai.TabIndex = 2;
            textBox3_tielelai.TextChanged += textBox3_tielelai_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(183, 63);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 3;
            label1.Text = "Số tiền gốc :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(200, 136);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 3;
            label2.Text = "Ngày vay :";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(222, 224);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 3;
            label3.Text = "Tỉ lệ lãi :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(367, 276);
            button1.Name = "button1";
            button1.Size = new Size(154, 57);
            button1.TabIndex = 4;
            button1.Text = "Tính Toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Font = new Font("Segoe UI", 12F);
            label_ketqua.Location = new Point(222, 364);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(82, 28);
            label_ketqua.TabIndex = 5;
            label_ketqua.Text = "Kết Quả";
            // 
            // TinhLai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ve_tranh_phong_canh_don_gian_11;
            ClientSize = new Size(800, 493);
            Controls.Add(label_ketqua);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3_tielelai);
            Controls.Add(textBox2_ngvay);
            Controls.Add(textBox1_goctien);
            Name = "TinhLai";
            Text = "TinhLai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_goctien;
        private TextBox textBox2_ngvay;
        private TextBox textBox3_tielelai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label_ketqua;
    }
}