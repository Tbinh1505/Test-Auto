using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using DuAn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{

    public partial class FDoimk : Form
    {
        private string _message = "";
        bool _check_info = false;
        bool _check_passnew = false;
        ICustomerServices _services;
        Validate _validate;
        IStaffServices _staffServices;
        public FDoimk()
        {
            InitializeComponent();
            _services = new CustomerServices();
            _staffServices = new StaffServices();
            _validate = new Validate();
            lbl_passOld.Visible = false;
            lbl_passNew.Visible = false;
            lbl_passReNew.Visible = false;

        }
        public FDoimk(string messege) : this()
        {
            _message = messege;
            lblWell.Text = "Chào mừng thượng đế: " + _message;
        }
        bool checkpassold()
        {
            try
            {
                if (_services.GetCustomers().Where(c => c.Password == _validate.ReversePass(tbx_passOld.Text) && c.Email == _message).FirstOrDefault() != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbx_passOld.Text != "" && tbx_passNew.Text != "" && tbx_passReNew.Text != "")
            {
                if (_check_info && _check_passnew)
                {
                    if (checkpassold())
                    {
                        Customer customer = _services.Get(_message);
                        customer.Password = _validate.ReversePass(tbx_passReNew.Text);
                        if (MessageBox.Show(_services.Update(customer), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin đúng yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void tbx_passReNew_TextChanged(object sender, EventArgs e)
        {
            if (tbx_passReNew.Text == tbx_passNew.Text)
            {
                lbl_passReNew.Text = "";
                lbl_passReNew.Visible = false;
                _check_info = true;
            }
            else
            {
                _check_info = false;
                lbl_passReNew.Text = "Mật khẩu nhập lại phải trùng khớp mật khẩu đã nhập!";
                lbl_passReNew.Visible = true;
                lbl_passReNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lbl_passReNew.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tbx_passNew_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkpass(tbx_passNew.Text))
            {
                lbl_passNew.Text = "";
                lbl_passNew.Visible = false;
                _check_passnew = true;
            }
            else
            {
                _check_passnew = false;
                lbl_passNew.Text = "Mật khẩu nhập phải từ 6 kí tự và có ít nhất 1 ký tự đặc biệt!";
                lbl_passNew.Visible = true;
                lbl_passNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lbl_passNew.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
