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

namespace GUI.Views
{
    public partial class FthongTinKh : Form
    {
        ICustomerServices _customerServices;
        ITicketServices _ticketServices;
        IFlightServices _flightServices;
        public FthongTinKh()
        {
            _flightServices=new FlightServices();
            _ticketServices = new TicketServices();
            _customerServices = new CustomerServices();
            InitializeComponent();
        }
        public FthongTinKh(string email, int idticket) : this()
        {
            var cus = _customerServices.GetCustomers().Where(c => c.Email == email).FirstOrDefault();
            var ticket = _ticketServices.list_Ticket().Where(c => c.Id == idticket).FirstOrDefault();
            var flight = _flightServices.get_list().Where(c => c.Id == ticket.FlightId).FirstOrDefault();
            txt_Email.Text = email;
            txt_seat.Text = ticket.SeatCode;
            txt_name.Text = cus.FirstName + " " + cus.MiddleName + " " + cus.LastName;
            txt_address.Text = cus.Address;
            txt_gender.Text = cus.Gender;
            txt_phonenumber.Text = cus.Phone;
            txt_CodeFlight.Text = flight.FlightCode;
        }
    }
}
