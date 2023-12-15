using _2_BUS.IService;
using _2_BUS.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.Views.View_User
{
    public partial class FQuanLyVeDat : Form
    {
        ICustomerServices _customerServices;
        ITicketServices _ticketServices;
        IFlightServices _flightServices;
        public FQuanLyVeDat()
        {
            _customerServices = new CustomerServices();
            _flightServices = new FlightServices();
            _ticketServices = new TicketServices();
            InitializeComponent();
        }
        string _email = "";
        public FQuanLyVeDat(string email) : this()
        {
            _email = email;
            load();
        }
        void load()
        {
            var cus = _customerServices.GetCustomers().Where(c => c.Email == _email).FirstOrDefault();
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in _ticketServices.list_Ticket().Where(c => c.Status == 1 && c.CustomerId == cus.Id))
            {
                Point pointMa = new Point(14, 17);
                Point pointFrom = new Point(14, 67);
                Point pointTo = new Point(133, 67);
                Point pointDateFrom = new Point(230, 67);
                Point pointDateTo = new Point(340, 67);
                Point pointSeat = new Point(230, 37);
                Point pointTimeStart = new Point(14, 37);
                Point pointTimeEnd = new Point(133, 37);
                Point pointStatus = new Point(340, 37);
                Point pointBtnCancel = new Point(595, 28);
                var fl = _flightServices.get_list().Where(c => c.Id == item.FlightId).FirstOrDefault();

                Panel pan = new Panel();
                pan.BorderStyle = BorderStyle.FixedSingle;
                pan.Size = new Size(785, 100);

                Label machuyenbay = new Label();
                machuyenbay.Location = pointMa;
                machuyenbay.Text = fl.FlightCode;
                machuyenbay.Size = new Size(200, 15);

                Label from = new Label();
                from.Location = pointFrom;
                from.Text = fl.GoFrom;
                from.Size = new Size(100, 15);

                Label to = new Label();
                to.Location = pointTo;
                to.Size = new Size(100, 15);
                to.Text = fl.GoTom;

                Label seat = new Label();
                seat.Location = pointSeat;
                string term = item.SeatCode.Substring(0, 2);
                seat.Text = term == "PT" ? $"Phổ Thông {item.SeatCode.Substring(2)}" : $"Thương Gia {item.SeatCode.Substring(2)}";

                Label status = new Label();
                status.Location = pointStatus;
                status.Text = item.TwoWay == 1 ? "Một chiều" : "Khứ hồi";

                Label timeStart = new Label();
                timeStart.Location = pointTimeStart;
                timeStart.Text = fl.TimeStart.ToString();

                Label timeEnd = new Label();
                timeEnd.Location = pointTimeEnd;
                timeEnd.Text = fl.TimeEnd.ToString();

                Label dateFrom = new Label();
                dateFrom.Location = pointDateFrom;
                dateFrom.Text = fl.DateFlight.ToShortDateString();

                Label dateTo = new Label();
                dateTo.Location = pointDateTo;
                DateTime date = new DateTime(fl.DateTo.Value.Year, fl.DateTo.Value.Month, fl.DateTo.Value.Day);
                dateTo.Text = date.ToShortDateString();

                Guna2Button btn_Cancel = new Guna2Button();
                btn_Cancel.BorderRadius = 10;
                btn_Cancel.FillColor = Color.FromArgb(235, 64, 52);
                btn_Cancel.Location = pointBtnCancel;
                btn_Cancel.Text = "Hủy vé";
                btn_Cancel.Click += Btn_Cancel_Click;
                btn_Cancel.Name = item.Id.ToString();
                pan.Controls.Add(machuyenbay);
                pan.Controls.Add(from);
                pan.Controls.Add(to);
                pan.Controls.Add(seat);
                pan.Controls.Add(status);
                pan.Controls.Add(timeEnd);
                pan.Controls.Add(timeStart);
                pan.Controls.Add(dateFrom);
                pan.Controls.Add(dateTo);
                pan.Controls.Add(btn_Cancel);
                flowLayoutPanel1.Controls.Add(pan);
            }
        }
        public void Btn_Cancel_Click(object? sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)(sender);
            var ticket = _ticketServices.list_Ticket().Where(c => c.Id == Convert.ToInt32(btn.Name)).FirstOrDefault();
            var flight = _flightServices.get_list().Where(c => c.Id == ticket.FlightId).FirstOrDefault();
            if (Math.Abs(flight.DateFlight.Day - DateTime.Now.Day) > 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn hủy vé?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ticket.Status = 0;
                    ticket.LastUpdate = DateTime.Now;
                    _ticketServices.update(ticket);
                    MessageBox.Show("Hủy vé thành công", "Thông báo!");
                    load();
                }
            }
            else
            {
                MessageBox.Show("Quá thời hạn hủy vé", "Thông báo!");
            }
        }

    }
}
