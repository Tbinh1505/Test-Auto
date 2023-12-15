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
using TheArtOfDevHtmlRenderer.Adapters;

namespace DuAn1
{
    public partial class Fquanlynv : Form
    {
        bool _check_name = false;
        bool _check_mail = false;
        bool _check_sdt = false;
        Validate _validate;
        INhanVienServices _inhanVienServices;
        public Fquanlynv()
        {
            _validate = new Validate();
            InitializeComponent();
            _inhanVienServices = new NhanVienServices();
            loadData();
            lb_ErrorEmail.Visible = false;
            lb_ErrorName.Visible = false;
            lb_ErrorPhone.Visible = false;
        }
        public void loadData()
        {
            dgrid_NhanVien.Rows.Clear();
            dgrid_NhanVien.ColumnCount = 4;
            dgrid_NhanVien.Columns[0].Name = "Họ và tên";
            dgrid_NhanVien.Columns[1].Name = "Email";
            dgrid_NhanVien.Columns[2].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[3].Name = "Trạng thái";
            txt_Ten.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pass.Enabled = false;
            txt_Sdt.Enabled = false;
            if (txt_timkiem.Text != "")
            {
                dgrid_NhanVien.DataSource = _inhanVienServices.getAllNhanVien().Where(c => c.DisplayName.Contains(txt_timkiem.Text) || c.Phone.StartsWith(txt_timkiem.Text)).ToList();
            }
            foreach (var item in _inhanVienServices.getAllNhanVien().Where(c => c.RoleId != 99))
            {
                if (item.Status == 1)
                {
                    dgrid_NhanVien.Rows.Add(item.DisplayName, item.Email, item.Phone, "Đang hoạt động");
                }
                else
                {
                    dgrid_NhanVien.Rows.Add(item.DisplayName, item.Email, item.Phone, "Ngừng hoạt động");
                }
            }
            txt_Ten.Text = dgrid_NhanVien.Rows[1].Cells[0].Value.ToString();
            txt_Sdt.Text = dgrid_NhanVien.Rows[1].Cells[2].Value.ToString();
            txt_Email.Text = dgrid_NhanVien.Rows[1].Cells[1].Value.ToString();
            if (dgrid_NhanVien.Rows[1].Cells[3].Value.ToString() == "Đang hoạt động")
            {
                rbtn_onl.Checked = true;
            }
            else
            {
                rbtn_off.Checked = true;
            }
        }
        public void reset()
        {
            loadData();
            txt_Ten.Text = "";
            txt_Pass.Text = "";
            txt_Email.Text = "";
            txt_Sdt.Text = "";
            rbtn_onl.Checked = false;
            rbtn_off.Checked = false;
        }
        public bool checknhap()
        {
            if (txt_Pass.Text == "" || txt_Email.Text == "" || txt_Ten.Text == "" /*|| txt_user.Text == "" */|| txt_Sdt.Text == "")
                return false;
            return true;
        }
        int check = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            if (check > 0)
            {
                staff staff = new staff();
                if (checknhap())
                {
                    if (_check_name && _check_mail && _check_sdt)
                    {
                        bool checkDuplicate = false;
                        foreach (var item in _inhanVienServices.getAllNhanVien().Where(c => c.RoleId != 99))
                        {
                            if (txt_Email.Text == item.Email || txt_Sdt.Text == item.Phone)
                            {
                                checkDuplicate = true;
                            }
                        }
                        if (!checkDuplicate)
                        {
                            staff.DisplayName = txt_Ten.Text;
                            staff.Email = txt_Email.Text;
                            staff.Phone = txt_Sdt.Text;
                            staff.Password = _validate.ReversePass(txt_Pass.Text);
                            MessageBox.Show(_inhanVienServices.addNhanVien(staff));
                            loadData();
                            check = 0;
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc số điện thoại đã được sử dụng để đăng kí!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập thông tin đúng định dạng");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    txt_Ten.Enabled = false;
                    txt_Email.Enabled = false;
                    txt_Pass.Enabled = false;
                    txt_Sdt.Enabled = false;
                    txt_Ten.Text = dgrid_NhanVien.Rows[1].Cells[0].Value.ToString();
                    txt_Sdt.Text = dgrid_NhanVien.Rows[1].Cells[2].Value.ToString();
                    txt_Email.Text = dgrid_NhanVien.Rows[1].Cells[1].Value.ToString();
                    if (dgrid_NhanVien.Rows[1].Cells[3].Value.ToString() == "Đang hoạt động")
                    {
                        rbtn_onl.Checked = true;
                    }
                    else
                    {
                        rbtn_off.Checked = true;
                    }
                    lb_ErrorEmail.Visible = false;
                    lb_ErrorName.Visible = false;
                    lb_ErrorPhone.Visible = false;
                }
            }
            else
            {
                txt_Ten.Enabled = true;
                txt_Email.Enabled = true;
                txt_Pass.Enabled = true;
                txt_Sdt.Enabled = true;
                txt_Email.Text = "";
                txt_Pass.Text = "";
                txt_Ten.Text = "";
                txt_Sdt.Text = "";
                lb_ErrorEmail.Visible = false;
                lb_ErrorName.Visible = false;
                lb_ErrorPhone.Visible = false;
            }
            check++;
        }

        public void btn_Sua_Click(object sender, EventArgs e)
        {
            staff staff = _inhanVienServices.getAllNhanVien().Where(c => c.Email == txt_Email.Text).FirstOrDefault();
            if (rbtn_onl.Checked)
            {
                staff.Status = 0;
                MessageBox.Show(_inhanVienServices.updateNhanVien(staff));
            }
            else
            {
                staff.Status = 1;
                MessageBox.Show(_inhanVienServices.updateNhanVien(staff));
            }
            loadData();
        }

        public void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ten.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pass.Enabled = false;
            txt_Sdt.Enabled = false;
            txt_Ten.Text = dgrid_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_Sdt.Text = dgrid_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_Email.Text = dgrid_NhanVien.CurrentRow.Cells[1].Value.ToString();
            if (dgrid_NhanVien.CurrentRow.Cells[3].Value.ToString() == "Đang hoạt động")
            {
                rbtn_onl.Checked = true;
            }
            else
            {
                rbtn_off.Checked = true;
            }
        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            dgrid_NhanVien.Rows.Clear();
            dgrid_NhanVien.ColumnCount = 4;
            dgrid_NhanVien.Columns[0].Name = "Họ và tên";
            dgrid_NhanVien.Columns[1].Name = "Email";
            dgrid_NhanVien.Columns[2].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[3].Name = "Trạng thái";
            txt_Ten.Enabled = false;
            txt_Email.Enabled = false;
            txt_Pass.Enabled = false;
            txt_Sdt.Enabled = false;

            foreach (var item in _inhanVienServices.getAllNhanVien().Where(c => c.DisplayName.Contains(txt_timkiem.Text) || c.Phone.StartsWith(txt_timkiem.Text)).Where(c => c.RoleId != 99))
            {
                if (item.Status == 1)
                {
                    dgrid_NhanVien.Rows.Add(item.DisplayName, item.Email, item.Phone, "Đang hoạt động");
                }
                else
                {
                    dgrid_NhanVien.Rows.Add(item.DisplayName, item.Email, item.Phone, "Ngừng hoạt động");
                }
            }
            if (dgrid_NhanVien.RowCount > 0)
            {
                txt_Ten.Text = dgrid_NhanVien.Rows[0].Cells[0].Value.ToString();
                txt_Sdt.Text = dgrid_NhanVien.Rows[0].Cells[2].Value.ToString();
                txt_Email.Text = dgrid_NhanVien.Rows[0].Cells[1].Value.ToString();
                if (dgrid_NhanVien.Rows[0].Cells[3].Value.ToString() == "Đang hoạt động")
                {
                    rbtn_onl.Checked = true;
                }
                else
                {
                    rbtn_off.Checked = true;
                }
            }
        }

        public void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkName(txt_Ten.Text))
            {
                lb_ErrorName.Text = "";
                lb_ErrorName.Visible = false;
                _check_name = true;
            }
            else
            {
                _check_name = false;
                lb_ErrorName.Text = "Không đúng định dạng tên";
                lb_ErrorName.Visible = true;
                lb_ErrorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorName.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void txt_Sdt_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkPhoneNumber(txt_Sdt.Text))
            {
                lb_ErrorPhone.Text = "";
                lb_ErrorPhone.Visible = false;
                _check_sdt = true;
            }
            else
            {
                _check_sdt = false;
                lb_ErrorPhone.Text = "Không đúng định dạng sô điện thoại";
                lb_ErrorPhone.Visible = true;
                lb_ErrorPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPhone.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkEmail(txt_Email.Text))
            {
                lb_ErrorEmail.Text = "";
                lb_ErrorEmail.Visible = false;
                _check_mail = true;
            }
            else
            {
                _check_mail = false;
                lb_ErrorEmail.Text = "Không đúng định dạng email";
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
