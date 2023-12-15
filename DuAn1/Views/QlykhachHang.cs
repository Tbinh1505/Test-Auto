using _1_DAL.Models;
using _2_BUS.Service;
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
    public partial class QlykhachHang : Form
    {
        CustomerServices _cusServices;
        int id;
        int? sta;
        public QlykhachHang()
        {
            _cusServices = new CustomerServices();
            InitializeComponent();
        }

        public void QlykhachHang_Load(object sender, EventArgs e)
        {
            dtgv_kh.Rows.Clear();
            dtgv_kh.ColumnCount = 8;
            dtgv_kh.Columns[0].Name = "STT";
            dtgv_kh.Columns[1].Name = "Tên khách hàng";
            dtgv_kh.Columns[2].Name = "Email";
            dtgv_kh.Columns[3].Name = "Ngày sinh";
            dtgv_kh.Columns[4].Name = "SĐT";
            dtgv_kh.Columns[5].Name = "Địa chỉ";
            dtgv_kh.Columns[6].Name = "Giới tính";
            dtgv_kh.Columns[7].Name = "Trạng thái";

            foreach (var i in _cusServices.GetCustomers())
            {
                dtgv_kh.Rows.Add(i.Id, i.FirstName + " " + i.MiddleName + " " + i.LastName, i.Email, i.Dob.Value.Date.ToString(), i.Phone, i.Address, i.Gender,
                    i.Status == 1 ? "Hoạt động" : "Vô hiệu hóa");
                sta = i.Status;
            }
        }

        public void dtgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dtgv_kh.CurrentRow.Cells[0].Value.ToString());
            tb_name.Text = dtgv_kh.CurrentRow.Cells[1].Value.ToString();
            tb_email.Text = dtgv_kh.CurrentRow.Cells[2].Value.ToString();
            tb_gender.Text = dtgv_kh.CurrentRow.Cells[6].Value.ToString();
            tb_phone.Text = dtgv_kh.CurrentRow.Cells[4].Value.ToString();
            rtb_addr.Text = dtgv_kh.CurrentRow.Cells[5].Value.ToString();
            dtp_dob.Value = Convert.ToDateTime(dtgv_kh.CurrentRow.Cells[3].Value.ToString());
            tb_status.Text = dtgv_kh.CurrentRow.Cells[7].Value.ToString();
        }

        public void btn_find_Click(object sender, EventArgs e)
        {
            if (tb_find.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên người cần tìm kiếm", "Thông báo");
            }
            else
            {
                dtgv_kh.Rows.Clear();
                dtgv_kh.ColumnCount = 8;
                dtgv_kh.Columns[0].Name = "STT";
                dtgv_kh.Columns[1].Name = "Tên khách hàng";
                dtgv_kh.Columns[2].Name = "Email";
                dtgv_kh.Columns[3].Name = "Ngày sinh";
                dtgv_kh.Columns[4].Name = "SĐT";
                dtgv_kh.Columns[5].Name = "Địa chỉ";
                dtgv_kh.Columns[6].Name = "Giới tính";
                dtgv_kh.Columns[7].Name = "Trạng thái";

                foreach (var i in _cusServices.GetCustomers().Where(c => c.FirstName.Contains(tb_find.Text) || c.MiddleName.Contains(tb_find.Text) || c.LastName.Contains(tb_find.Text)||c.Email.Contains(tb_find.Text)||c.Phone.Contains(tb_find.Text)))
                {
                    dtgv_kh.Rows.Add(i.Id, i.FirstName + " " + i.MiddleName + " " + i.LastName, i.Email, i.Dob.Value.Date.ToString(), i.Phone, i.Address, i.Gender,
                        i.Status == 1 ? "Hoạt động" : "Vô hiệu hóa");
                }
            }
        }

        public void tb_find_TextChanged(object sender, EventArgs e)
        {
            if (tb_find.Text == "")
            {
                QlykhachHang_Load(null, null);
            }
        }

        public void btn_sua_Click(object sender, EventArgs e)
        {
            if (sta == 1)
            {
                sta = 0;
            }
            else
            {
                sta = 1;
            }
            Customer cus = new Customer()
            {
                Id = id,
                Status = sta
            };
            if (MessageBox.Show("Xác nhận cập nhật trạng thái của tài khoản này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(_cusServices.Update(cus));
                Clear();
                QlykhachHang_Load(null, null);
            }
        }
        public void Clear()
        {
            tb_name.Clear();
            tb_status.Clear();
            tb_phone.Clear();
            rtb_addr.Clear();
            tb_gender.Clear();
            dtp_dob.Value = DateTime.Now;
        }
    }
}
