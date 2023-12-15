using _1_DAL.IRepon;
using _2_BUS.IService;
using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.Views.View_User
{
    public partial class FbuyTickket : Form
    {
        string _email = "";
        bool check_button = true;
        IClassServices _classServices;
        ILocationServices _locationServices;
        IFlightServices _flightServices;
        public FbuyTickket()
        {

            InitializeComponent();

        }
        public FbuyTickket(string email) : this()
        {
            _email = email;
            _flightServices = new FlightServices();
            _classServices = new ClassServices();
            _locationServices = new LocationService();
            load();
            lb_ErrorFrom.Visible = false;
            lb_ErrorTo.Visible = false;
            lb_dateTo.Visible = false;
            lb_dateFrom.Visible = false;
        }
        void load()
        {
            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";

            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";

            txt_Discount.Visible = false;
            date_To.Visible = false;
            guna2HtmlLabel8.Visible = false;
        }
        bool check_place()
        {
            if (cbb_From.Text != cbb_To.Text)
            {
                return true;
            }
            return false;
        }
        int check_date()
        {
            DateTime date1 = new DateTime(date_From.Value.Year, date_From.Value.Month, date_From.Value.Day);
            DateTime date2 = new DateTime(date_To.Value.Year, date_To.Value.Month, date_To.Value.Day);
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
        int check_dateFrom()
        {
            DateTime date = DateTime.Now;
            DateTime date1 = new DateTime(date.Year, date.Month, date.Day);
            DateTime date2 = new DateTime(date_From.Value.Year, date_From.Value.Month, date_From.Value.Day);
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
        private void btn_Discount_Click(object sender, EventArgs e)
        {
            txt_Discount.Visible = true;
            btn_discount.Visible = false;
        }

        public void btn_oneWay_Click(object sender, EventArgs e)
        {
            check_button = true;
            btn_discount.Visible = true;
            txt_Discount.Visible = false;
            date_To.Visible = false;
            guna2HtmlLabel8.Visible = false;
            btn_OneWay.FillColor = Color.DarkCyan;
            btn_TwoWay.FillColor = Color.White;
        }

        public void btn_TwoWay_Click(object sender, EventArgs e)
        {
            check_button = false;
            btn_discount.Visible = true;
            txt_Discount.Visible = false;
            date_To.Visible = true;
            guna2HtmlLabel8.Visible = true;
            btn_TwoWay.FillColor = Color.DarkCyan;
            btn_OneWay.FillColor = Color.White;
        }

        public void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check_place())
            {
                lb_ErrorTo.Visible = false;
                lb_ErrorFrom.Visible = false;
            }
            else
            {
                lb_ErrorTo.Visible = true;
                lb_ErrorTo.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorTo.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void cbb_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check_place())
            {
                lb_ErrorTo.Visible = false;
                lb_ErrorFrom.Visible = false;
            }
            else
            {
                lb_ErrorFrom.Visible = true;
                lb_ErrorFrom.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorFrom.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void date_From_ValueChanged(object sender, EventArgs e)
        {
            if (check_dateFrom() == 1 || check_dateFrom() == 0)
            {
                lb_dateFrom.Visible = false;
            }
            else
            {
                lb_dateFrom.Visible = true;
                lb_dateFrom.Text = "Vui lòng chọn ngày đi lớn hơn hoặc bằng ngày hiện tại!!!";
                lb_dateFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_dateFrom.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void date_To_ValueChanged(object sender, EventArgs e)
        {
            if (check_date() == 0 || check_date() == 1)
            {
                lb_dateTo.Visible = false;
            }
            else
            {
                lb_dateTo.Visible = true;
                lb_dateTo.Text = "Vui lòng chọn ngày về lớn hơn ngày đi!!!";
                lb_dateTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_dateTo.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            if (check_button)
            {
                if (check_place())
                {
                    if (check_dateFrom() == 1 || check_dateFrom() == 0)
                    {
                        DateTime date = new DateTime(date_From.Value.Year, date_From.Value.Month, date_From.Value.Day);
                        var search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTom == cbb_To.Text && c.DateFlight == date && c.DateTo == date).ToList();
                        if (search.Count > 0)
                        {
                            FBuyTicketChild a = new FBuyTicketChild(search, _email);
                            this.Hide();
                            a.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm được chuyến bay phù hợp","Thông báo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đi nhỏ hơn ngày hiện tại","Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại điểm đi hoặc điểm đến","Thông báo!");
                }
            }
            else
            {
                if (check_place())
                {
                    if (check_date() == 1 || check_date() == 0)
                    {
                        if (check_dateFrom() == 1 || check_dateFrom() == 0)
                        {
                            DateTime date1 = new DateTime(date_From.Value.Year, date_From.Value.Month, date_From.Value.Day);
                            DateTime date2 = new DateTime(date_To.Value.Year, date_To.Value.Month, date_To.Value.Day);
                            var search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTom == cbb_To.Text && c.DateFlight == date1 && c.DateTo == date2).ToList();
                            if (search.Count > 0)
                            {
                                FBuyTicketChild a = new FBuyTicketChild(search, _email);
                                this.Hide();
                                a.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm được chuyến bay phù hợp","Thông báo!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ngày đi nhỏ hơn ngày hiện tại", "Thông báo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đi chọn phải nhỏ hơn ngày đến", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại điểm đi hoặc điểm đến", "Thông báo!");
                }
            }
        }


    }
}
