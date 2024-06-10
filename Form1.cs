using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HINHTRON1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double TinhDienTich(double bk) { return bk * bk * Math.PI; }
        double TinhChuVi(double bk) { return bk*2*Math.PI; }
        private void btncv_Click(object sender, EventArgs e)
        {
            double r, ketqua, pi=Math.PI;
            r = Convert.ToDouble(txtbk.Text);
            ketqua = r * 2 * pi;
            txtkq.Text=ketqua.ToString();
        }

        private void btndt_Click(object sender, EventArgs e)
        {
            double r, ketqua, pi = Math.PI;
            r = Convert.ToDouble(txtbk.Text);
            ketqua = r * r * pi;
            txtkq.Text = ketqua.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntinh1_Click(object sender, EventArgs e)
        {   
            double r = Convert.ToDouble(txtbk.Text);
            if(rdbcv.Checked)
            {
                double chuvi = r * 2 * Math.PI;
                string thongbao = "Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(rdbdt.Checked)
            {
                double dientich = r * r * Math.PI;
                string thongbao = "Chu vi " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtbk.Text);
            string thongbao = "";
            if (chkcv.Checked)
            {
                double chuvi = r*2* Math.PI;    
                thongbao=thongbao+"Chu vi" +Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (chkdt.Checked)
            {
                double dientich = r * r * Math.PI;
                thongbao = thongbao + "Diện tích" + Convert.ToString(dientich) + Environment.NewLine;

            }
            if(thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
