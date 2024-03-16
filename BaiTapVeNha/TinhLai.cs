using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class TinhLai : Form
    {
        public TinhLai()
        {
            InitializeComponent();
        }
        public bool ChecKData()
        {
            double check = 0;

            bool check1 = double.TryParse(textBox1_goctien.Text, out check);

            bool check2 = double.TryParse(textBox2_ngvay.Text, out check);

            bool check3 = double.TryParse(textBox3_tielelai.Text, out check);
            return check1 && check2 && check3;
        }
        public void TinhToanLai()
        {
            if (ChecKData())
            {

                double tiengoc = double.Parse(textBox1_goctien.Text);
                double ngayvay = double.Parse(textBox2_ngvay.Text);
                double tilelai = double.Parse(textBox3_tielelai.Text);
                if (tiengoc < 0 || ngayvay < 0 || tilelai < 0)
                {
                    MessageBox.Show("Không được nhập số âm");
                }
                else
                {
                    double tienLai = tiengoc * Math.Pow((1 + tilelai / 100), ngayvay) - tiengoc;
                    label_ketqua.Text = tienLai + "";
                }
            }
            else
            {
                MessageBox.Show("Không được nhập dữ liệu khác số mời nhập lại số");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TinhToanLai();
        }

        private void textBox1_goctien_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_goctien.Text.Length > 0 && textBox2_ngvay.Text.Length > 0 && textBox3_tielelai.Text.Length > 0)
            {
                TinhToanLai();
            }
        }

        private void textBox2_ngvay_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_goctien.Text.Length > 0 && textBox2_ngvay.Text.Length > 0 && textBox3_tielelai.Text.Length > 0)
            {
                TinhToanLai();
            }

        }

        private void textBox3_tielelai_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_goctien.Text.Length > 0 && textBox2_ngvay.Text.Length > 0 && textBox3_tielelai.Text.Length > 0)
            {
                TinhToanLai();
            }

        }

        private void textBox1_goctien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_ngvay.Focus();
            }
        }

        private void textBox2_ngvay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3_tielelai.Focus();
            }
        }
    }
}
