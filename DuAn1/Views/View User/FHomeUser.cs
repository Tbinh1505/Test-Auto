using GUI.Views.View_User;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.Views
{
    public partial class FHomeUser : Form
    {
        private string _message = "";
        FthongTinNguoiDung _fTinNguoiDung;
        FbuyTickket _buyticket;
        public FHomeUser()
        {
            InitializeComponent();
        }
        public FHomeUser(string Message) : this()
        {
            _message = Message;
            _buyticket = new FbuyTickket(_message);
            label1.Text = _message;
            label1.Visible = false;
            load();

        }
        void load()
        {
            guna2Button1.FillColor = Color.DarkCyan;

            guna2Button2.FillColor = Color.White;//màu background button
            guna2Button2.ForeColor = Color.Black;//thay màu chữ

            guna2Button3.FillColor = Color.White;
            guna2Button3.ForeColor = Color.Black;

            guna2Button4.FillColor = Color.White;
            guna2Button4.ForeColor = Color.Black;

            ChildForm(_buyticket);

        }

        public void ChildForm(Form child)
        {
            guna2Panel1.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(child);
            child.Show();
        }

        public void guna2Button1_Click(object sender, EventArgs e) //button mua ve truc tuyen
        {

            FbuyTickket child = new FbuyTickket(_message);
            ChildForm(child);
            if (guna2Button1.Enabled == true)
            {
                guna2Button1.FillColor = Color.DarkCyan;

                guna2Button2.FillColor = Color.White;//màu background button
                guna2Button2.ForeColor = Color.Black;//thay màu chữ

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;
            }
        }

        public void guna2Button3_Click(object sender, EventArgs e)//button tinh trang chuyen bay
        {
            FtinhTrangChuyenBay child = new();
            ChildForm(child);
            if (guna2Button3.Enabled == true)
            {
                guna2Button3.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button2.FillColor = Color.White;
                guna2Button2.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;

            }
        }

        public void guna2Button4_Click(object sender, EventArgs e)//button lich bay
        {
            FlichBay child = new FlichBay(_message);
            ChildForm(child);
            if (guna2Button4.Enabled == true)
            {
                guna2Button4.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button2.FillColor = Color.White;
                guna2Button2.ForeColor = Color.Black;

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

            }
        }

        public void guna2Button2_Click(object sender, EventArgs e)
        {
            FQuanLyVeDat child = new FQuanLyVeDat(_message);
            ChildForm(child);
            if (guna2Button2.Enabled == true)
            {
                guna2Button2.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;

            }
        }


        public void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDoimk _fDoimk = new FDoimk(_message);
            _fDoimk.ShowDialog();
        }

        public void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FthongTinNguoiDung fthongTinNguoiDung = new FthongTinNguoiDung(label1.Text);
            fthongTinNguoiDung.ShowDialog();
        }

        public void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHuongDanUs fhuongdan = new FHuongDanUs();
            fhuongdan.ShowDialog();

        }

        public void thêmTàiKhoảnNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FtaikhoanNh ftaikhoanNh = new FtaikhoanNh(_message);
            ftaikhoanNh.ShowDialog();
        }
    }
}
