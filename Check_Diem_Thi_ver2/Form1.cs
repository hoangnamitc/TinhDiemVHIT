using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Check_Diem_Thi_ver2
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {


                float a = float.Parse(txtquatrinh.Text);
                float b = float.Parse(txtdiemthi.Text);
                lbldiemthishow.Text = Math.Round((a * 0.3) + (b * 0.7), 2).ToString("F1");
                float c = float.Parse(lbldiemthishow.Text);
                button1.Enabled = true;
 
                if(a > 10 || a < 0)
                {
                    lbldiemthishow.Text = c.ToString("Lỗi");
                    lbldiemchushow.Text = c.ToString("Lỗi");
                }
                else

                if (b > 10 || b < 0)
                {
                    lbldiemthishow.Text = c.ToString("Lỗi");
                    lbldiemchushow.Text = c.ToString("Lỗi");   
                }
                else

                if (c > 10 || c < 0)
                {
                    lbldiemthishow.Text = c.ToString("Lỗi");
                    lbldiemchushow.Text = c.ToString("Lỗi");
                }
                else

                if (c >= 8.5)
                {
                    lbldiemchushow.Text = c.ToString("Loại A");
                }
                else if (c >= 7 && c < 8.5)
                {
                    lbldiemchushow.Text = c.ToString("Loại B");
                }
                else if (c >= 5.5 && c < 7)
                {
                    lbldiemchushow.Text = c.ToString("Loại C");
                }
                else if (c >= 4 && c < 5.5)
                {
                    lbldiemchushow.Text = c.ToString("Loại D");
                }
                else
                {
                    lbldiemchushow.Text = c.ToString("Loại F");
                    MessageBox.Show("..::: Xin Chia Buồn ::...\n\n Bạn bị thi lại môn này!", "Thông Điệp", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                DialogResult err;
                err = MessageBox.Show("Bạn chỉ được nhập số !!!", "CÓ LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdiemthi.Text = "";
            txtquatrinh.Text = "";
            lbldiemthishow.Text = "";
            lbldiemchushow.Text = "";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Điểm nhập vào có phân biệt giữa 2 dấu: | . | , | \n\n Bạn phải nhập đúng kiểu thì kết quả mới đúng !!");
        }

        private void txtquatrinh_Click(object sender, EventArgs e)
        {
            //txtquatrinh.SelectAll();
        }

        private void txtdiemthi_Click(object sender, EventArgs e)
        {
            //txtdiemthi.SelectAll();
        }

        private void frmCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }
    }
}
