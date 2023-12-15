using _1_DAL.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GUI.Views.View_User
{
    public partial class FAfterSeat : Form
    {
        Validate _validate;
        FChonGheSmallSize _fsm;
        SeatFlightSer _ser;
        FlightServices _f;
        SeatDetailServices _sd;
        PlaneTypeServices _plane;
        CustomerServices _cus;
        TicketServices _ticketServices;
        ClassServices _classServices;
        long id;
        List<int> lst;
        List<string> lst_ma;
        long idmb;
        string macb;
        string _email = "";
        int _price = 0;
        public string Status;
        public FAfterSeat()
        {
            _validate = new Validate();
            _classServices = new ClassServices();
            _ticketServices = new TicketServices();
            _cus = new CustomerServices();
            _fsm = new FChonGheSmallSize();
            _ser = new SeatFlightSer();
            _f = new();
            _sd = new SeatDetailServices();
            _plane = new PlaneTypeServices();
            InitializeComponent();
        }

        public FAfterSeat(string machuyenbay, List<string> maghe, string email, int price) : this()
        {
            lst = new List<int>();
            lst_ma = new List<string>();
            lst_ma = maghe;
            _email = email;
            _price = price;
            lb_CodeFlight.Text = machuyenbay;
            var fl = _f.get_list().Where(c => c.FlightCode == machuyenbay).FirstOrDefault();
            id = fl.Id;
            var cus = _cus.GetCustomers().Where(c => c.Email == email).FirstOrDefault();
            lb_name.Text = $"{cus.FirstName} {cus.MiddleName} {cus.LastName}";
            DateTime datetime = new DateTime(fl.DateTo.Value.Year, fl.DateTo.Value.Month, fl.DateTo.Value.Day);
            lb_date.Text = fl.DateFlight == fl.DateTo ? fl.DateFlight.ToShortDateString() : fl.DateFlight.ToShortDateString() + " - " + datetime.ToShortDateString();
            lb_from.Text = fl.GoFrom;
            lb_tom.Text = fl.GoTom;
            lb_seat.Text = maghe[0];
            for (int i = 1; i < maghe.Count; i++)
            {
                lb_seat.Text += ", " + maghe[i];
            }
            lb_totalSeats.Text = maghe.Count.ToString();
            foreach (var item in maghe)
            {
                var seatfl = _sd.list().Where(c => c.PlaneTypeId == fl.PlaneTypeId && c.SeatCode == item).FirstOrDefault();
                if (seatfl != null)
                {
                    lst.Add(seatfl.Id);
                }
            }
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            FthanhToan f = new FthanhToan(_price);
            SeatFlight sf;
            if (MessageBox.Show("Xác nhận mua vé?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
                if (f.status == "Thanh toán")
                {
                    foreach (var item in lst_ma)
                    {
                        Ticket creatticket = new Ticket();
                        var flterm = _f.get_list().Where(c => c.Id == id).FirstOrDefault();
                        creatticket.CustomerId = _cus.GetCustomers().Where(c => c.Email == _email).FirstOrDefault().Id;
                        creatticket.FlightId = id;
                        creatticket.CreateDate = DateTime.Now;
                        creatticket.TwoWay = flterm.DateFlight == flterm.DateTo ? 1 : 0;
                        creatticket.TotalTicket = 1;
                        var seat_book = _sd.list().Where(c => c.PlaneTypeId == flterm.PlaneTypeId && c.SeatCode == item).FirstOrDefault();
                        int price = seat_book.ClassId == 1 ? 1000000 : 500000;
                        creatticket.TotalPrice = flterm.Price + price;
                        creatticket.SeatCode = item;
                        creatticket.NameTicket = flterm.FlightCode + "_" + item;
                        creatticket.Status = 1;
                        _ticketServices.add(creatticket);
                    }
                    foreach (var item in lst)
                    {
                        sf = new SeatFlight()
                        {
                            Flightid = id,
                            Seatid = item,
                            Status = 1
                        };
                        _ser.Create(sf);
                    }
                }
                var flight = _f.get_list().Where(c => c.FlightCode == lb_CodeFlight.Text).FirstOrDefault();
                string email = _email;
                string subject = "THÔNG TIN NHỮNG VÉ MÁY BAY ĐÃ MUA";
                string body = $"Mã chuyến bay của quý khách là: {lb_CodeFlight.Text}.\n" +
                              $"Địa điểm bay: {lb_from.Text}.\n" +
                              $"Địa điếm đến: {lb_tom.Text}.\n" +
                              $"Ngày bay: {lb_date.Text}.\n" +
                              $"Tổng số ghế đã đặt: {lb_totalSeats.Text}.\n" +
                              $"Các mã ghế đã đặt: {lb_seat.Text}.\n" +
                              $"Thời gia bay: {flight.TimeStart}.\n" +
                              $"Thời gian đến: {flight.TimeEnd}.\n" +
                              $"Tông số tiền quý khách đã thanh toán là: {_price}.\n" +
                              $"Cảm ơn quý khách đã sử dụng dịch vụ của chúng tôi!\n";
                string code = lb_CodeFlight.Text;
                await _validate.SendEmailInfoTiket(email, subject, body, 99);
                Status = "True";
                this.Close();
            }
            else
            {
                MessageBox.Show("Mua vé thất bại");
            }

        }

        public void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
