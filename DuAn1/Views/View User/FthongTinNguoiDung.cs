using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FthongTinNguoiDung : Form
    {
        private string _message = "";

        ICustomerServices _service;

        Validate _validate;
        bool _check_Name = true;
        bool _check_Email = true;
        bool _check_Phone = true;
        bool _check_date = true;
        string _mail = "";
        public FthongTinNguoiDung()
        {
            InitializeComponent();
        }


        public FthongTinNguoiDung(string message) : this()
        {
            _mail = message;
            _service = new CustomerServices();
            cbx_gt.Items.Add("Nam");
            cbx_gt.Items.Add("Nữ");
            _validate = new Validate();
            load();
            Unelable();
            _message = message;
            _service = new CustomerServices();
            load();
            lb_ErrorDate.Visible = false;
            lb_ErrorEmail.Visible = false;
            lb_ErrorPhone.Visible = false;
            llb_ErrorName.Visible = false;
        }

        public void load()
        {
            var item = _service.GetCustomers().Where(c => c.Email == _mail).FirstOrDefault();
            tbx_email.Text = item.Email;
            tbx_diaChi.Text = item.Address;
            tbx_hoTen.Text = item.FirstName + " " + item.MiddleName + " " + item.LastName;
            if (item.Gender == "Nam")
            {
                cbx_gt.Text = "Nam";
            }
            else
            {
                cbx_gt.Text = "Nữ";
            }
            date_bird.Value = (DateTime)(item.Dob);
            tbx_sdt.Text = item.Phone;
        }

        public void btn_sua_Click(object sender, EventArgs e)
        {
            tbx_email.Enabled = false;
            tbx_diaChi.Enabled = true;
            tbx_hoTen.Enabled = true;
            cbx_gt.Enabled = true;
            date_bird.Enabled = true;
            tbx_sdt.Enabled = true;
            btn_update.Enabled = true;
            btn_sua.Enabled = false;
        }

        public void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_email.Text != "" || tbx_diaChi.Text != "" || tbx_hoTen.Text != "" || cbx_gt.Text != "" || date_bird.Text != "" || tbx_sdt.Text != "")
            {
                if (_check_date && _check_Email && _check_Name && _check_Phone)
                {
                    Customer custom = _service.GetCustomers().Where(c => c.Email == _message).FirstOrDefault();
                    custom.Address = tbx_diaChi.Text;
                    string[] name = _validate.cutName(tbx_hoTen.Text);
                    custom.FirstName = name[0];
                    custom.MiddleName = name[1];
                    custom.LastName = name[2];
                    custom.Phone = tbx_sdt.Text;
                    if (cbx_gt.Text == "Nam")
                    {
                        custom.Gender = "Nam";
                    }
                    else
                    {
                        custom.Gender = "Nữ";
                    }
                    custom.Dob = date_bird.Value;
                    MessageBox.Show(_service.Update(custom));
                    Unelable();
                    load();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin bạn nhập chưa đúng yêu cầu");
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa!");
            }
        }

        public void Unelable()
        {
            tbx_email.Enabled = false;
            tbx_diaChi.Enabled = false;
            tbx_hoTen.Enabled = false;
            cbx_gt.Enabled = false;
            date_bird.Enabled = false;
            tbx_sdt.Enabled = false;

            btn_sua.Enabled = true;

            btn_update.Enabled = false;
        }

        public void tbx_hoTen_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkName(tbx_hoTen.Text))
            {
                llb_ErrorName.Text = "";
                llb_ErrorName.Visible = false;
                _check_Name = true;
            }
            else
            {
                _check_Name = false;
                llb_ErrorName.Text = "Không đúng định dạng tên";
                llb_ErrorName.Visible = true;
                llb_ErrorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                llb_ErrorName.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void tbx_sdt_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkPhoneNumber(tbx_sdt.Text))
            {
                lb_ErrorPhone.Text = "";
                lb_ErrorPhone.Visible = false;
                _check_Phone = true;
            }
            else
            {
                _check_Phone = false;
                lb_ErrorPhone.Text = "Không đúng định dạng số điện thoại";
                lb_ErrorPhone.Visible = true;
                lb_ErrorPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPhone.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void tbx_email_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkEmail(tbx_email.Text))
            {
                lb_ErrorEmail.Text = "";
                lb_ErrorEmail.Visible = false;
                _check_Phone = true;
            }
            else
            {
                _check_Phone = false;
                lb_ErrorEmail.Text = "Không đúng định dạng số điện thoại";
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void date_bird_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan time = now - date_bird.Value;
            double year = Math.Round(time.TotalDays / 365);
            if (year < 18)
            {
                _check_date = false;
                lb_ErrorDate.Text = "Ngày tháng năm sinh chọn không phù hợp";
                lb_ErrorDate.Visible = true;
                lb_ErrorDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorDate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                _check_date = true;
                lb_ErrorDate.Visible = false;
            }
        }
    }
}
