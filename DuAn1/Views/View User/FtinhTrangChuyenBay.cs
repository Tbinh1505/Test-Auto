using _2_BUS.IService;
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

namespace GUI.Views.View_User
{
    public partial class FtinhTrangChuyenBay : Form
    {
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        string check_button;
        bool check_code = true;
        public FtinhTrangChuyenBay()
        {
            _locationServices = new LocationService();
            _flightServices = new FlightServices();
            InitializeComponent();
            load();
            lb_ErrorDate.Visible = false;
            lb_ErrorFrom1.Visible = false;
            lb_ErrorTo1.Visible = false;
            lb_ErrorNum.Visible = false;
            guna2HtmlLabel9.Visible = false;
            txt_CodeFlight.Visible = false;
        }
        void load()
        {
            guna2Button1.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = false;
            lb_ErrorDate.Visible = false;
            lb_ErrorFrom1.Visible = false;
            lb_ErrorTo1.Visible = false;
            lb_ErrorNum.Visible = false;
            guna2HtmlLabel9.Visible = false;
            check_button = "Hành trình";
            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";

            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";

        }
        bool check()
        {
            if (cbb_From.Text != cbb_To.Text)
            {
                return true;
            }
            return false;
        }
        bool checkcode()
        {
            if (txt_CodeFlight.Text == "")
            {
                return false;
            }
            return true;
        }

        public void guna2Button1_Click(object sender, EventArgs e) // dđây là button hành trình
        {
            check_button = "Hành trình";
            guna2Button2.FillColor = Color.White;
            guna2Button1.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = false;
            guna2HtmlLabel4.Visible = true;
            date_Start.Visible = true;
            guna2HtmlLabel2.Visible = true;
            HienThiHanhTrinh();
        }

        public void guna2Button2_Click(object sender, EventArgs e)//đây là button số hiệu chuyến bay
        {
            check_button = "Số hiệu";
            guna2Button1.FillColor = Color.White;
            guna2Button2.FillColor = Color.DarkCyan;
            txt_CodeFlight.Visible = true;
            guna2HtmlLabel4.Visible = false;
            date_Start.Visible = false;
            guna2HtmlLabel9.Visible = true;
            txt_CodeFlight.Visible = true;
            guna2HtmlLabel2.Visible = false;
            HienThiSoHieuChuyenBay();
        }

        public void HienThiSoHieuChuyenBay() // HIỂN THỊ các nút trong số hiệu chuuyến bay
        {
            guna2HtmlLabel3.Visible = false;
            guna2HtmlLabel9.Visible = true;
            cbb_From.Visible = false;
            cbb_To.Visible = false;
        }

        public void HienThiHanhTrinh() //Hiển thị các nút trong hành trình
        {
            guna2HtmlLabel3.Visible = true;
            guna2HtmlLabel9.Visible = false;
            txt_CodeFlight.Visible = false;
            cbb_From.Visible = true;
            cbb_To.Visible = true;
        }

        public void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorTo1.Visible = false;
                lb_ErrorFrom1.Visible = false;
            }
            else
            {
                lb_ErrorTo1.Visible = true;
                lb_ErrorTo1.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorTo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorTo1.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void cbb_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorTo1.Visible = false;
                lb_ErrorFrom1.Visible = false;
            }
            else
            {
                lb_ErrorFrom1.Visible = true;
                lb_ErrorFrom1.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorFrom1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorFrom1.ForeColor = System.Drawing.Color.Red;
            }
        }
        int check_dateFrom()
        {
            DateTime date = DateTime.Now;
            DateTime date1 = new DateTime(date.Year, date.Month, date.Day);
            DateTime date2 = new DateTime(date_Start.Value.Year, date_Start.Value.Month, date_Start.Value.Day);
            if (DateTime.Compare(date1, date2) == -1)
            {
                return 1;
            }
            else if (DateTime.Compare(date1, date2) == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public void date_Start_ValueChanged(object sender, EventArgs e)
        {

            if (check_dateFrom() == -1)
            {
                lb_ErrorDate.Visible = true;
                lb_ErrorDate.Text = "Vui lòng chọn ngày bay lớn hơn ngày hiện tại!!";
                lb_ErrorDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorDate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lb_ErrorDate.Visible = false;
            }
        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            if (check_button == "Hành trình")
            {
                if (check())
                {
                    if (check_dateFrom() == 1 || check_dateFrom() == 0)
                    {
                        try
                        {
                            DateTime date = new DateTime(date_Start.Value.Year, date_Start.Value.Month, date_Start.Value.Day);
                            var list_search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTom == cbb_To.Text && c.DateFlight == date).ToList();
                            FTinhTrangChuyenBayHanhTrinhChild hanhtrinh = new FTinhTrangChuyenBayHanhTrinhChild(list_search);
                            this.Hide();
                            hanhtrinh.ShowDialog();
                            this.Show();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày bay bạn chọn không phù hợp yêu cầu!","Thông báo!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng thay đổi điểm đi hoặc điểm đến!","Thông báo!");
                }
            }
            else
            {
                if (checkcode())
                {
                    try
                    {
                        string code = "";
                        foreach (var item in _flightServices.get_list())
                        {
                            string[] ma = item.FlightCode.Split("VN");
                            if (ma.Length==2)
                            {
                                if (ma[1] == txt_CodeFlight.Text)
                                {
                                    code = item.FlightCode;
                                }
                            }
                        }
                        if (code != "")
                        {
                            var list_search = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
                            FTinhTrangChuyenBaySoHieuChil hanhtrinh = new FTinhTrangChuyenBaySoHieuChil(list_search);
                            this.Hide();
                            hanhtrinh.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không có số hiệu chuyến bay bạn cần tìm","Thông báo!");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hiệu chuyến bay!","Thông báo!");
                }
            }
        }
    }
}

