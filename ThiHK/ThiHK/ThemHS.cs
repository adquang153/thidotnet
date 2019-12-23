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
    public partial class ThemHS : Form
    {
        private List<HocSinh> dshs;
        public ThemHS()
        {
            InitializeComponent();
           
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Txtmalop_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dshs = HocSinh.GetListHocSinh();
            if(!txtmahs.Text.Equals("")&&!txtho.Text.Equals("")&&!txtten.Text.Equals("")
                && !txtnoisinh.Text.Equals("") && !txtquequan.Text.Equals("")&&!txtmalh.Text.Equals("")
                )
            {
                HocSinh hs = new HocSinh();
                HocSinh k = new HocSinh(); 
                k.GioiTinh = Sex.Nu;
                if (chkGT.Checked == true)
                    k.GioiTinh = Sex.Nam;

                foreach (HocSinh i in dshs)
                {
                    if (!i.MaHS.Equals(txtmahs.Text.Trim()))
                    {
                        hs = new HocSinh
                        {
                            MaHS = txtmahs.Text,
                            Ho  =txtho.Text,
                            Ten = txtten.Text,
                            NoiSinh = txtnoisinh.Text,
                            GioiTinh = k.GioiTinh,
                            QueQuan = txtquequan.Text,
                            MaLH = txtmalh.Text
                        };
                    }
                    else
                    {
                        MessageBox.Show("Học sinh này đang học lớp khác");
                        break;
                    }
                }
                HocSinh.ThemHS(hs);
                MessageBox.Show("Đã thêm học sinh: " + hs.Ho + " " + hs.Ten);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
