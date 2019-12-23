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
    public partial class Form1 : Form
    {
        private List<LopHoc> dslh;
        private List<HocSinh> dshs;
        public Form1()
        {
            InitializeComponent();
            cb_khoihoc.SelectedIndex = 0;
            cb_namhoc.SelectedIndex = 0;
            dgv1.AutoGenerateColumns = false;
            dgv2.AutoGenerateColumns = false;
            dslh = LopHoc.GetListLopHoc( cb_khoihoc.SelectedItem.ToString(),cb_namhoc.SelectedItem.ToString());
            if (dslh != null)
            {
                bds1.DataSource = dslh;
                dgv1.DataSource = bds1;
                LopHoc a = (LopHoc)bds1.Current;
                dshs = HocSinh.GetListHocSinh(a.MaLH);
                bds2.DataSource = dshs;
                dgv2.DataSource = bds2;
            }
            
        }
        private void Load()
        {
            dgv1.AutoGenerateColumns = false;
            dgv2.AutoGenerateColumns = false;
            if (cb_khoihoc.SelectedItem != null && cb_namhoc.SelectedItem!=null) { 
                String kh = cb_khoihoc.SelectedItem.ToString();
                String nh = cb_namhoc.SelectedItem.ToString();
                dslh = LopHoc.GetListLopHoc(kh, nh);
                if (dslh != null)
                {
                    bds1.DataSource = dslh;
                    dgv1.DataSource = bds1;
                    LopHoc a = (LopHoc)bds1.Current;
                    if (a != null) { 
                        dshs = HocSinh.GetListHocSinh(a.MaLH);
                        bds2.DataSource = dshs;
                        dgv2.DataSource = bds2;
                    }
                }
            }
        }

        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load();
        }

        private void Cb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void Cb_khoihoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new ThemLH();
            f.ShowDialog();
            Load();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            LopHoc i = (LopHoc)bds1.Current;
            if(MessageBox.Show("Bạn có chắc muốn xóa lớp: " + i.TenLH, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                LopHoc.XoaLH(i);
                MessageBox.Show("Đã xóa lớp: "+i.TenLH);
            }
            Load();
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            var f = new ThemHS();
            f.ShowDialog();
            Load();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            HocSinh x = (HocSinh)bds2.Current;
            if (MessageBox.Show("Bạn có chắc muốn xóa học sinh: " + x.Ho+" "+x.Ten, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                HocSinh.XoaHS(x);
                MessageBox.Show("Đã xóa học sinh: " + x.Ho + " " + x.Ten);
            }
            Load();
        }
    }
}
