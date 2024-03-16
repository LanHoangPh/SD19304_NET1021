namespace LamquenWindownfrom
{
    partial class frmHome
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
            TrangChu_btn = new Label();
            SuspendLayout();
            // 
            // TrangChu_btn
            // 
            TrangChu_btn.AutoSize = true;
            TrangChu_btn.Location = new Point(289, 71);
            TrangChu_btn.Name = "TrangChu_btn";
            TrangChu_btn.Size = new Size(221, 20);
            TrangChu_btn.TabIndex = 0;
            TrangChu_btn.Text = "Chào mừng đến from Trang Chủ";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(TrangChu_btn);
            Name = "frmHome";
            Text = "frmHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TrangChu_btn;
    }
}