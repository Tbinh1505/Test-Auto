using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using GUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class FQuanLyChuyenBay : Form
    {

        bool checkInfo;
        IFlightServices _flight;
        ILocationServices _location;
        IPlaneTypeServices _plantype;
        ITicketServices _ticketServices;
        string plancode = "";
        string codefrom = "";
        string codeto = "";
        string ngaydi = "";
        string ngayve = "";
        public FQuanLyChuyenBay()
        {
            _ticketServices = new TicketServices();
            _flight = new FlightServices();
            _location = new LocationService();
            _plantype = new PlaneTypeServices();
            InitializeComponent();
            cmb_status.Items.Add("Đúng giờ");
            cmb_status.Items.Add("Delay");
            cmb_status.SelectedIndex = 0;
            load();
        }
        void check_price()
        {
            if (nbr_Price.Value < 500000)
            {
                checkInfo = false;
            }
            else
            {
                checkInfo = true;
            }
        }
        void load()
        {
            cmb_PlaneType.DataSource = _plantype.get_list();
            cmb_PlaneType.DisplayMember = "displayName";
            cmb_PlaneType.ValueMember = "planeCode";

            cmb_From.DataSource = _location.get_list();
            cmb_From.DisplayMember = "locationFly";
            cmb_From.ValueMember = "airportCode";

            cmb_To.DataSource = _location.get_list();
            cmb_To.DisplayMember = "locationFly";
            cmb_To.ValueMember = "airportCode";

            loaddata();

            plancode = cmb_PlaneType.SelectedValue.ToString();
            codefrom = cmb_From.SelectedValue.ToString();
            codeto = cmb_To.SelectedValue.ToString();
            ngaydi = DateFrom.Value.ToString("dd-MM-yyyy");
            ngayve = dateTo.Value.ToString("dd-MM-yyyy");

        }
        void loaddata()
        {
            dgv_chuyenbay.Rows.Clear();
            dgv_chuyenbay.ColumnCount = 12;
            dgv_chuyenbay.Columns[0].Name = "Tên máy bay";
            dgv_chuyenbay.Columns[1].Name = "Địa điểm bay";
            dgv_chuyenbay.Columns[2].Name = "Mã chuyến bay";
            dgv_chuyenbay.Columns[3].Name = "Điểm đến";
            dgv_chuyenbay.Columns[4].Name = "Điểm đi";
            dgv_chuyenbay.Columns[5].Name = "Thời gian đi";
            dgv_chuyenbay.Columns[6].Name = "Thời gian về";
            dgv_chuyenbay.Columns[7].Name = "Giá";
            dgv_chuyenbay.Columns[8].Name = "id";
            dgv_chuyenbay.Columns[8].Visible = false;
            dgv_chuyenbay.Columns[9].Name = "Giờ khởi hành";
            dgv_chuyenbay.Columns[10].Name = "Giờ kết thúc";
            dgv_chuyenbay.Columns[11].Name = "Trạng thái";

            foreach (var item in _flight.get_list())
            {
                string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTom, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.TimeStart, item.TimeEnd, item.Status == 0 ? "Đúng giờ" : "Delay");
            }
            if (dgv_chuyenbay.RowCount > 0)
            {
                txb_codeflight.Text = dgv_chuyenbay.Rows[0].Cells[2].Value.ToString();
                nbr_Price.Value = Convert.ToInt32(dgv_chuyenbay.Rows[0].Cells[7].Value.ToString());
                cmb_PlaneType.Text = dgv_chuyenbay.Rows[0].Cells[0].Value.ToString();
                cmb_To.Text = dgv_chuyenbay.Rows[0].Cells[3].Value.ToString();
                cmb_From.Text = dgv_chuyenbay.Rows[0].Cells[4].Value.ToString();
                DateFrom.Value = (DateTime)(dgv_chuyenbay.Rows[0].Cells[5].Value);
                dateTo.Value = (DateTime)(dgv_chuyenbay.Rows[0].Cells[6].Value);
                cmb_status.Text = dgv_chuyenbay.Rows[0].Cells[11].Value.ToString();
                txb_codeflight.Text = dgv_chuyenbay.Rows[0].Cells[2].Value.ToString();
                TimeSpan timestart = (TimeSpan)(dgv_chuyenbay.Rows[0].Cells[9].Value);
                TimeSpan timeEnd = (TimeSpan)(dgv_chuyenbay.Rows[0].Cells[10].Value);
                timeStart_hour.Value = timestart.Hours;
                timeStart_minute.Value = timestart.Minutes;
                timeEnd_hour.Value = timeEnd.Hours;
                timeEnd_minute.Value = timeEnd.Minutes;
            }

            txb_codeflight.Enabled = false;
        }
        string ReverseCodeFlight()
        {
            string code = "";
            int max = 0;
            foreach (var item in _flight.get_list())
            {
                foreach (var item1 in _flight.get_list())
                {
                    if (item1 == item)
                    {
                        string[] cut = item.FlightCode.Split("VN");
                        if (cut.Count() > 1)
                        {
                            if (max < Convert.ToInt32(cut[1]))
                            {
                                max = Convert.ToInt32(cut[1]);
                            }
                        }
                    }
                }
            }
            if (max < 9)
            {
                code = $"VN00{max + 1}";
            }
            else if (max < 99)
            {
                code = $"VN0{max + 1}";
            }
            else
            {
                code = $"VN{max + 1}";
            }
            return code;
        }
        bool check_date()
        {
            DateTime date = DateTime.Now;
            DateTime dateTimefrom = new DateTime(DateFrom.Value.Year, DateFrom.Value.Month, DateFrom.Value.Day);
            DateTime dateTimeNow = new DateTime(date.Year, date.Month, date.Day);
            if (DateTime.Compare(dateTimefrom, dateTimeNow) == -1)
            {
                return false;
            }
            return true;

        }
        bool check_dateTo()
        {
            DateTime dateTimefrom = new DateTime(DateFrom.Value.Year, DateFrom.Value.Month, DateFrom.Value.Day);
            DateTime dateTimeTo = new DateTime(dateTo.Value.Year, dateTo.Value.Month, dateTo.Value.Day);
            if (DateTime.Compare(dateTimeTo, dateTimefrom) == -1)
            {
                return false;
            }
            return true;
        }
        bool checkTimeNow()
        {
            DateTime date = DateTime.Now;
            DateTime now = new DateTime(date.Year, date.Month, date.Day);
            DateTime from = new DateTime(DateFrom.Value.Year, DateFrom.Value.Month, DateFrom.Value.Day);
            TimeSpan timeNow = new TimeSpan(date.Hour, date.Minute, date.Second);
            int hourStart = Convert.ToInt32(timeStart_hour.Value);
            int minuteStart = Convert.ToInt32(timeStart_minute.Value);
            TimeSpan timeflight = new TimeSpan(hourStart, minuteStart, 0);
            if (DateTime.Compare(now, from) == 0)
            {
                if (TimeSpan.Compare(timeflight, timeNow) <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        bool check_timeDup()
        {
            int hourStart = Convert.ToInt32(timeStart_hour.Value);
            int minuteStart = Convert.ToInt32(timeStart_minute.Value);
            int hourEnd = Convert.ToInt32(timeEnd_hour.Value);
            int minuteEnd = Convert.ToInt32(timeEnd_minute.Value);
            TimeSpan timestart = new TimeSpan(hourStart, minuteStart, 0);
            TimeSpan timeEnd = new TimeSpan(hourEnd, minuteEnd, 0);
            int min = 0;
            var plane = _plantype.get_list().Where(c => c.PlaneCode == cmb_PlaneType.SelectedValue).FirstOrDefault();
            try
            {
                min = _flight.get_list().Where(c => c.PlaneTypeId == plane.Id && c.DateFlight == DateFrom.Value).FirstOrDefault().TimeStart.Hours;

            }
            catch (Exception)
            {
                min = 24;
            }
            foreach (var item in _flight.get_list().Where(c => c.PlaneTypeId == plane.Id && c.DateFlight == DateFrom.Value))
            {
                if (item.TimeStart.Hours < min)
                {
                    min = item.TimeStart.Hours;
                }
            }
            foreach (var item in _flight.get_list().Where(c => c.PlaneTypeId == plane.Id))
            {
                if (item.DateFlight == DateFrom.Value)
                {
                    if (timestart.Hours == item.TimeStart.Hours)
                    {
                        return false;
                    }
                    else
                    {
                        if (timeEnd.Hours < min)
                        {
                            return true;
                        }
                        else
                        {
                            if (TimeSpan.Compare(timestart, item.TimeEnd) <= 0)
                            {
                                return false;
                            }

                        }
                    }
                }
            }
            return true;
        }
        int check_timeFlight()
        {
            int hourStart = Convert.ToInt32(timeStart_hour.Value);
            int minuteStart = Convert.ToInt32(timeStart_minute.Value);
            int hourEnd = Convert.ToInt32(timeEnd_hour.Value);
            int minuteEnd = Convert.ToInt32(timeEnd_minute.Value);
            TimeSpan timestart = new TimeSpan(hourStart, minuteStart, 0);
            TimeSpan timeEnd = new TimeSpan(hourEnd, minuteEnd, 0);
            if (timestart.Hours >= 21 && timeEnd.Hours <= 4)
            {
                return 1;
            }
            else
            {
                if (TimeSpan.Compare(timestart, timeEnd) == -1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        bool checklocation()
        {
            if (cmb_From.Text == cmb_To.Text)
            {
                return false;
            }
            return true;
        }
        public void btn_Add_Click(object sender, EventArgs e)
        {
            check_price();
            if (checkTimeNow())
            {
                if (check_date())
                {
                    if (check_dateTo())
                    {
                        if (check_timeDup())
                        {
                            if (check_timeFlight() == 1)
                            {
                                if (checklocation())
                                {
                                    if (checkInfo)
                                    {
                                        Flight flight = new Flight();
                                        foreach (var item in _plantype.get_list())
                                        {
                                            if (item.DisplayName == cmb_PlaneType.Text)
                                            {
                                                flight.PlaneTypeId = item.Id;
                                                break;
                                            }
                                        }
                                        flight.FlightCode = ReverseCodeFlight();
                                        flight.GoFrom = cmb_From.Text;
                                        flight.GoTom = cmb_To.Text;
                                        foreach (var item in _location.get_list())
                                        {
                                            if (item.LocationFly == cmb_From.Text)
                                            {
                                                flight.LocationId = item.Id;
                                                break;
                                            }
                                        }
                                        flight.DateFlight = DateFrom.Value;
                                        flight.DateTo = dateTo.Value;
                                        flight.Price = Convert.ToInt32(nbr_Price.Value);

                                        int hours_st = Convert.ToInt32(timeStart_hour.Value.ToString());
                                        int minute_st = Convert.ToInt32(timeStart_minute.Value.ToString());

                                        int hours_e = Convert.ToInt32(timeEnd_hour.Value);
                                        int minute_e = Convert.ToInt32(timeEnd_minute.Value);
                                        TimeSpan timestart = new TimeSpan(hours_st, minute_st, 0);
                                        TimeSpan timeend = new TimeSpan(hours_e, minute_e, 0);
                                        flight.TimeStart = timestart;
                                        flight.TimeEnd = timeend;

                                        flight.Status = cmb_status.SelectedIndex == 0 ? 0 : 1;//trạng thái của chuyến bay
                                        MessageBox.Show(_flight.create(flight));
                                        load();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hãy nhập đúng giá!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hãy chọn điểm đi và điểm đến khác nhau!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thời gian đi phải lớn hơn thời gian đến!");
                            }
                        }
                        else
                        {
                            int hours_st = Convert.ToInt32(timeStart_hour.Value.ToString());
                            int minute_st = Convert.ToInt32(timeStart_minute.Value.ToString());
                            TimeSpan timestart = new TimeSpan(hours_st, minute_st, 0);

                            MessageBox.Show($"Máy bay {cmb_PlaneType.Text} vào ngày đang chọn đã có chuyến bay vào lúc {timestart} xin vui lòng chọn giờ bay khác!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày về phải lớn hơn hoặc bằng ngày đi");
                    }
                }
                else
                {
                    MessageBox.Show("Ngay bay phải lớn hơn hoặc bằng ngày hiện tại.");
                }
            }
            else
            {
                MessageBox.Show("Giờ bay phải lớn hơn giờ hiện tại");
            }

        }
        public void btn_Update_Click(object sender, EventArgs e)
        {
            var flight = _flight.get_list().Where(c => c.Id == Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[8].Value.ToString())).FirstOrDefault();
            flight.Status = flight.Status == 1 ? 0 : 1; // trạng thái của chuyến bay
            MessageBox.Show(_flight.update(flight));
            load();
        }

        public void txb_Search_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text != "")
            {
                dgv_chuyenbay.Rows.Clear();
                foreach (var item in _flight.get_list().Where(c => c.GoFrom.Contains(txb_Search.Text) || c.GoTom.Contains(txb_Search.Text) || c.FlightCode.Contains(txb_codeflight.Text)))
                {
                    string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                    string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                    dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTom, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.TimeStart, item.TimeEnd, item.Status == 0 ? "Đúng giờ" : "Delay");
                }
            }
            else
            {
                dgv_chuyenbay.Rows.Clear();
                foreach (var item in _flight.get_list())
                {
                    string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                    string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                    dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTom, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.TimeStart, item.TimeEnd, item.Status == 0 ? "Đúng giờ" : "Delay");
                }
            }
        }

        public void dgv_chuyenbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_codeflight.Text = dgv_chuyenbay.CurrentRow.Cells[2].Value.ToString();
            nbr_Price.Value = Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[7].Value.ToString());
            cmb_PlaneType.Text = dgv_chuyenbay.CurrentRow.Cells[0].Value.ToString();
            cmb_To.Text = dgv_chuyenbay.CurrentRow.Cells[3].Value.ToString();
            cmb_From.Text = dgv_chuyenbay.CurrentRow.Cells[4].Value.ToString();
            DateFrom.Value = (DateTime)(dgv_chuyenbay.CurrentRow.Cells[5].Value);
            dateTo.Value = (DateTime)(dgv_chuyenbay.CurrentRow.Cells[6].Value);
            cmb_status.Text = dgv_chuyenbay.CurrentRow.Cells[11].Value.ToString();
            TimeSpan timestart = (TimeSpan)(dgv_chuyenbay.CurrentRow.Cells[9].Value);
            TimeSpan timeEnd = (TimeSpan)(dgv_chuyenbay.CurrentRow.Cells[10].Value);
            timeStart_hour.Value = timestart.Hours;
            timeStart_minute.Value = timestart.Minutes;
            timeEnd_hour.Value = timeEnd.Hours;
            timeEnd_minute.Value = timeEnd.Minutes;
            int idfl = Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[8].Value.ToString());
            var ticket = _ticketServices.list_Ticket().Where(c => c.FlightId == idfl).FirstOrDefault();
            if (ticket != null)
            {
                FkhqlChuyenBay fkhqlChuyenBay = new FkhqlChuyenBay(idfl);
                this.Hide();
                fkhqlChuyenBay.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Chuyến bay không có khách hàng sử dụng");
            }

        }

    }
}
