using _2_BUS.Service;
using GUI.Views;
using GUI.Views.View_User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class fStaff : Form
    {
        private string _messe;
        int _role;
        public fStaff()
        {
            InitializeComponent();
        }
        public fStaff(int role, string messege) : this()
        {
            _messe = messege;
            _role = role;
            EnableButton();
        }

        private void EnableButton()
        {
            if (_role == 1)
            {
                btn_qlynv.Visible = false;
                btn_dthu.Visible = false;
            }
            else
            {
                btn_qlynv.Visible = true;
                btn_dthu.Visible = true;
            }
        }

        public void ChildForm(Form child)
        {
            pn_chil.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pn_chil.Controls.Add(child);
            child.Show();
        }
        public void btn_qlynv_Click(object sender, EventArgs e)
        {
            Fquanlynv child = new();
            ChildForm(child);

            if (btn_qlynv.Enabled == true)
            {
                btn_qlynv.BackColor = Color.DarkCyan;
                btn_qlynv.ForeColor = Color.White;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.White;
                btn_addPlane.ForeColor = Color.Black;

            }
        }

        public void btn_dthu_Click(object sender, EventArgs e)
        {
            FquanLyDoanhThu child = new FquanLyDoanhThu();
            ChildForm(child);
            if (btn_dthu.Enabled == true)
            {
                btn_dthu.BackColor = Color.DarkCyan;
                btn_dthu.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.White;
                btn_addPlane.ForeColor = Color.Black;


            }
        }

        public void btn_qlyve_Click(object sender, EventArgs e)
        {
            FquanlyVe child = new FquanlyVe();
            ChildForm(child);

            if (btn_qlyve.Enabled == true)
            {
                btn_qlyve.BackColor = Color.DarkCyan;
                btn_qlyve.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.White;
                btn_addPlane.ForeColor = Color.Black;
            }
        }

        public void btn_qlyflight_Click(object sender, EventArgs e)
        {
            FQuanLyChuyenBay child = new();
            ChildForm(child);
            if (btn_qlyflight.Enabled == true)
            {
                btn_qlyflight.BackColor = Color.DarkCyan;
                btn_qlyflight.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.White;
                btn_addPlane.ForeColor = Color.Black;
            }
        }

        public void btn_qlykh_Click(object sender, EventArgs e)
        {
            QlykhachHang child = new QlykhachHang();
            ChildForm(child);
            if (btn_qlykh.Enabled == true)
            {
                btn_qlykh.BackColor = Color.DarkCyan;
                btn_qlykh.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.White;
                btn_addPlane.ForeColor = Color.Black;
            }
        }


        public void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FDoimk f = new FDoimk(_messe);
            f.ShowDialog();
        }

        public void đăngXuấtToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void btn_addPlane_Click(object sender, EventArgs e)
        {
            FThemMayBay child = new FThemMayBay();
            ChildForm(child);
            if (btn_qlykh.Enabled == true)
            {
                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

                btn_addPlane.BackColor = Color.DarkCyan;
                btn_addPlane.ForeColor = Color.White;

            }
        }
    }
}
