using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using _2_BUS.IService;
using _2_BUS.Service;
using _1_DAL.Models;
using _2_BUS.Validate;

namespace DuAn1.Views
{
    public partial class FforGotPass : Form
    {
        bool _check_email = false;
        bool _check_ma = false;
        bool _check_pass = false;
        bool _check_passNew = false;
        ICustomerServices _services;
        Validate _validate;
        string code_otp = "";
        int seconds = 60;
        int minutes = 5;
        public FforGotPass()
        {
            _validate = new Validate();
            _services = new CustomerServices();
            InitializeComponent();
            btn_success.Enabled = false;
        }
        void reset()
        {
            tbx_email.Text = "";
            tbx_ma.Text = "";
            tbx_pass2.Text = "";
            txb_pass1.Text = "";
            lb_errorCode.Visible = false;
            lb_errorEmail.Visible = false;
            lb_errorPass.Visible = false;
            lb_ErrorPassNew.Visible = false;
            time.Visible = false;
        }
        public async void btn_sendCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_email.Text != "" && _services.Get(tbx_email.Text).Email == tbx_email.Text)
                {
                    countDown.Interval = 1000;
                    countDown.Start();
                    minutes = 5;
                    seconds = 60;
                    string email = tbx_email.Text;
                    string subject = "Mã xác thực để lấy lại mật khẩu của bạn là:";
                    string body = "Mã xác thực của bạn là: ";
                    int role_id = 99;
                    code_otp = _validate.randomCode();
                    if (await _validate.SendEmailVerify(email, subject, body, code_otp, role_id))
                    {
                        time.Visible = true;
                        MessageBox.Show("Mã xác thực đã được gửi đến email của bạn"+code_otp);
                        btn_sendCode.Enabled = false;
                        btn_success.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể gửi mã xác thực đến email");
                    }
                }
                else
                {
                    MessageBox.Show("Email chưa được sử dụng để đăng ký");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Email chưa được sử dụng để đăng ký");
            }

        }


        public void countDown_Tick(object sender, EventArgs e)
        {
            btn_sendCode.Enabled = false;
            if (minutes > -2)
            {
                seconds--;
                lb_Minutes.Text = "0" + minutes.ToString();
                lb_Seconds.Text = seconds.ToString();
                if (minutes == 5)
                {
                    minutes--;
                    lb_Minutes.Text = "0" + minutes.ToString();
                }
                if (seconds == 0)
                {
                    minutes--;
                    if (minutes == -1)
                    {
                        minutes = -2;
                        minutes = 0;
                        seconds = 0;
                        lb_Minutes.Text = "00";
                        lb_Seconds.Text = "00";
                        btn_sendCode.Enabled = true;
                        code_otp = _validate.randomCode();
                        countDown.Stop();
                        time.Visible = false;
                    }
                    lb_Minutes.Text = "0" + minutes.ToString();
                    seconds = 60;
                }
            }
        }

        public void btn_success_Click(object sender, EventArgs e)
        {
            if (tbx_email.Text != "" && tbx_ma.Text != "" && tbx_pass2.Text != "" && txb_pass1.Text != "" && tbx_pass2.Text != "")
            {
                if (tbx_ma.Text == code_otp)
                {
                    if (txb_pass1.Text == tbx_pass2.Text)
                    {
                        if (_check_pass && _check_email && _check_ma)
                        {
                            Customer customer = _services.Get(tbx_email.Text);
                            customer.Password = _validate.ReversePass(tbx_pass2.Text);
                            MessageBox.Show(_services.Update(customer));
                            code_otp = _validate.randomCode();
                            reset();
                            btn_success.Enabled = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin điền đúng thông tin yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu đã nhập không trùng nhau");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin điền đúng thông tin yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void tbx_email_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkEmail(tbx_email.Text))
            {
                lb_errorEmail.Text = "";
                lb_errorEmail.Visible = false;
                _check_email = true;
            }
            else
            {
                _check_email = false;
                lb_errorEmail.Text = "Email ko đúng định dạng";
                lb_errorEmail.Visible = true;
                lb_errorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorEmail.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void tbx_ma_TextChanged(object sender, EventArgs e)
        {
            if (tbx_ma.Text == code_otp)
            {
                lb_errorCode.Text = "";
                lb_errorCode.Visible = false;
                _check_ma = true;
            }
            else
            {
                _check_ma = false;
                lb_errorCode.Text = "Mã otp nhập chưa đúng mã được cấp";
                lb_errorCode.Visible = true;
                lb_errorCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorCode.ForeColor = System.Drawing.Color.Red;
            }

        }

        public void tbx_pass2_TextChanged(object sender, EventArgs e)
        {
            if (tbx_pass2.Text == txb_pass1.Text)
            {
                lb_errorPass.Text = "";
                lb_errorPass.Visible = false;
                _check_pass = true;
            }
            else
            {
                _check_pass = false;
                lb_errorPass.Text = "Mật khẩu nhập lại phải trùng khớp mật khẩu đã nhập!";
                lb_errorPass.Visible = true;
                lb_errorPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorPass.ForeColor = System.Drawing.Color.Red;
            }

        }

        public void txb_pass1_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkpass(txb_pass1.Text))
            {
                lb_ErrorPassNew.Visible = false;
                _check_passNew = true;
            }
            else
            {
                _check_passNew = false;
                lb_ErrorPassNew.Text = "Mật khẩu nhập phải ít nhất 6 ký tự và có ít nhất 1 ký tự đặc biệt như @,!,#,$,...";
                lb_ErrorPassNew.Visible = true;
                lb_ErrorPassNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPassNew.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void FforGotPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            reset();
        }
    }
}
