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
    public partial class FtaikhoanNh : Form
    {
        IBankServices _bankServices;
        ICustomerServices _customerServices;
        bool _checkName = false;
        Validate _validate;
        public FtaikhoanNh()
        {
            _validate = new Validate();
            _customerServices = new CustomerServices();
            _bankServices = new BankServices();
            InitializeComponent();
            lb_ErrorName.Visible = false;
            cbb_BankName.Items.Add("BIDV");
            cbb_BankName.Items.Add("AGRIBANK");
        }

        string _email = "";
        public FtaikhoanNh(string emai) : this()
        {
            _email = emai;
        }
        bool checkDup()
        {
            foreach (var item in _bankServices.List_bank())
            {
                if (item.BankAccountNum == Convert.ToInt32(txt_BankNumber.Text))
                {
                    return false;
                }
            }
            return true;
        }
        bool check()
        {
            if (txt_BankNumber.Text == "" || txt_Name.Text == "")
            {
                return false;
            }
            return true;
        }
        public void btn_Add_Click(object sender, EventArgs e)
        {
            if (_checkName)
            {
                if (check())
                {
                    if (checkDup())
                    {
                        var cus = _customerServices.GetCustomers().Where(c => c.Email == _email).FirstOrDefault();
                        if (cus != null)
                        {
                            Bank bank = new Bank();
                            bank.DisplayName = txt_Name.Text;
                            bank.CustomerId = cus.Id;
                            bank.BankAccountNum = Convert.ToInt32(txt_BankNumber.Text);
                            MessageBox.Show(_bankServices.create(bank));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số tài khoản đã được sử dụng");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập các trường còn thiếu");
                }
            }
            else
            {
                MessageBox.Show("Tên chưa đúng định dạng");
            }
        }

        public void txt_BankNumber_TextChanged(object sender, EventArgs e)
        {
            if (txt_BankNumber.Text != "")
            {
                char[] number = txt_BankNumber.Text.ToCharArray();
                int index = 0;
                try
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        index = i;
                        Convert.ToInt32(number[i].ToString());
                    }
                }
                catch (Exception)
                {
                    string term = "";
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (i != index)
                        {
                            term += number[i].ToString();
                        }
                    }
                    txt_BankNumber.Text = term;
                }
            }

        }

        public void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkName(txt_Name.Text))
            {
                _checkName = true;
                lb_ErrorName.Visible = false;
            }
            else
            {
                _checkName = false;
                lb_ErrorName.Visible = true;
                lb_ErrorName.Text = "Nhập tên chưa đúng định dạng";
                lb_ErrorName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorName.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
