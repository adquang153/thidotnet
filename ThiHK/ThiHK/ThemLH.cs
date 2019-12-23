using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiHK.DAL.Entity;

namespace ThiHK
{
    public partial class ThemLH : Form
    {
        private List<LopHoc> dslh;
        public ThemLH()
        {
            InitializeComponent();
            cb_khoihoc.SelectedIndex = 0;
            cb_namhoc.SelectedIndex = 0;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dslh = LopHoc.GetListLopHoc(cb_khoihoc.SelectedItem.ToString(),cb_namhoc.SelectedItem.ToString());
            if (!txtmalop.Text.Equals("") && !txttenlop.Text.Equals("") && !txtphonghoc.Text.Equals(""))
            {
                LopHoc a = new LopHoc();
                foreach (LopHoc i in dslh)
                {
                    if (!i.MaLH.Equals(txtmalop.Text))
                    {
                        a = new LopHoc
                        {
                            MaLH = txtmalop.Text,
                            TenLH = txttenlop.Text,
                            PhongHoc = txtphonghoc.Text,
                            KhoiHoc = cb_khoihoc.SelectedItem.ToString(),
                            NamHoc = cb_namhoc.SelectedItem.ToString()
                        };

                    }
                    else
                    {
                        MessageBox.Show("Mã lớp đã tồn tại!");
                        break;
                    }
                }
                LopHoc.ThemLH(a);
                MessageBox.Show("Đã thêm lớp: " + txttenlop.Text);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Các trường không được để trống");
        }
    }
}
