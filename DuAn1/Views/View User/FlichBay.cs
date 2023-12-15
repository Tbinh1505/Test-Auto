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
    public partial class FlichBay : Form
    {
        string _email = "";
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        bool check_date = true;
        public FlichBay()
        {
            InitializeComponent();

        }
        public FlichBay(string email) : this()
        {
            _email = email;
            _locationServices = new LocationService();
            _flightServices = new FlightServices();
            load();
        }
        void load()
        {
            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";
            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";
            lb_ErrorFrom.Visible = false;
            lb_ErrorTo.Visible = false;
            lb_ErrorDate.Visible = false;
        }
        bool check()
        {
            if (cbb_From.Text == cbb_To.Text)
            {
                return false;
            }
            return true;
        }
        int check_dateFrom()
        {
            DateTime date = DateTime.Now;
            DateTime date1 = new DateTime(date.Year, date.Month, date.Day);
            DateTime date2 = new DateTime(date_nkh.Value.Year, date_nkh.Value.Month, date_nkh.Value.Day);
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

        public void btn_Search_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (check_dateFrom() == 1 || check_dateFrom() == 0)
                {
                    try
                    {
                        DateTime date = new DateTime(date_nkh.Value.Year, date_nkh.Value.Month, date_nkh.Value.Day).AddDays(-1);
                        DateTime date1 = new DateTime(date_nkh.Value.Year, date_nkh.Value.Month, date_nkh.Value.Day).AddDays(4);
                        var list_search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTom == cbb_To.Text && c.DateFlight > date && c.DateFlight < date1).ToList();
                        if (list_search.Count > 0)
                        {
                            FLichBayChild fLichBayChild = new FLichBayChild(list_search, date, _email);
                            this.Hide();
                            fLichBayChild.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày bay bạn chọn không phù hợp yêu cầu!", "Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Điểm đến điểm đi chọn không phù hợp yêu cầu!", "Thông báo!");
            }
        }

        public void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
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
            if (check())
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

        public void date_nkh_ValueChanged(object sender, EventArgs e)
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
    }
}
