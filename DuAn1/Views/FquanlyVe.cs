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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class FquanlyVe : Form
    {
        ITicketServices _ticketServices;
        IClassServices _classServices;
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        ICustomerServices _customerServices;
        ISeatDetailServices _seatDetailServices;
        IPlaneTypeServices _planeTypeServices;
        public FquanlyVe()
        {
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            _customerServices = new CustomerServices();
            _classServices = new ClassServices();
            _ticketServices = new TicketServices();
            _flightServices = new FlightServices();
            _locationServices = new LocationService();
            InitializeComponent();

            load();
        }
        void load()
        {

            cbb_DiemDen.DataSource = _locationServices.get_list();
            cbb_DiemDen.DisplayMember = "locationFly";

            cbb_DiemDi.DataSource = _locationServices.get_list();
            cbb_DiemDi.DisplayMember = "locationFly";

            dgv_data.Rows.Clear();
            dgv_data.ColumnCount = 12;
            dgv_data.Columns[0].Name = "Tên vé";
            dgv_data.Columns[1].Name = "Người mua";
            dgv_data.Columns[2].Name = "Mã chuyến bay";
            dgv_data.Columns[3].Name = "Ngày tạo vé";
            dgv_data.Columns[4].Name = "Loại vé";
            dgv_data.Columns[5].Name = "Ngày đi";
            dgv_data.Columns[6].Name = "Ngày về";
            dgv_data.Columns[7].Name = "Điểm đi";
            dgv_data.Columns[8].Name = "Điểm đến";
            dgv_data.Columns[9].Name = "Giá vé";
            dgv_data.Columns[10].Name = "Mã ghế";
            dgv_data.Columns[11].Name = "ID";
            dgv_data.Columns[11].Visible = false;
            foreach (var item in _ticketServices.list_Ticket().Where(c=>c.Status==1))
            {
                var cus = _customerServices.GetCustomers().Where(c => c.Id == item.CustomerId).FirstOrDefault();

                var flight = _flightServices.get_list().Where(c => c.Id == item.FlightId).FirstOrDefault();

                var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();

                var seat = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id && c.SeatCode == "").FirstOrDefault();
                dgv_data.Rows.Add(item.NameTicket, cus.Email, flight.FlightCode, item.CreateDate, item.TwoWay, flight.DateFlight, flight.DateTo, flight.GoFrom, flight.GoTom, item.TotalPrice, item.SeatCode, item.Id);
            }
            if (dgv_data.RowCount > 0)
            {
                date_NgayDi.Value = (DateTime)(dgv_data.Rows[0].Cells[5].Value);
                date_NgayVe.Value = (DateTime)(dgv_data.Rows[0].Cells[6].Value);
                cbb_DiemDen.Text = dgv_data.Rows[0].Cells[8].Value.ToString();
                cbb_DiemDi.Text = dgv_data.Rows[0].Cells[7].Value.ToString();
            }
        }

        public void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            date_NgayDi.Value = (DateTime)(dgv_data.CurrentRow.Cells[5].Value);
            date_NgayVe.Value = (DateTime)(dgv_data.CurrentRow.Cells[6].Value);
            cbb_DiemDen.Text = dgv_data.CurrentRow.Cells[8].Value.ToString();
            cbb_DiemDi.Text = dgv_data.CurrentRow.Cells[7].Value.ToString();
            string emailcus = dgv_data.CurrentRow.Cells[1].Value.ToString();
            int idticket = Convert.ToInt32(dgv_data.CurrentRow.Cells[11].Value.ToString());
            FthongTinKh fthongTinKh = new FthongTinKh(emailcus, idticket);
            this.Hide();
            fthongTinKh.ShowDialog();
            this.Show();

        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_data.Rows.Clear();
            dgv_data.ColumnCount = 12;
            dgv_data.Columns[0].Name = "Tên vé";
            dgv_data.Columns[1].Name = "Người mua";
            dgv_data.Columns[2].Name = "Mã chuyến bay";
            dgv_data.Columns[3].Name = "Ngày tạo vé";
            dgv_data.Columns[4].Name = "Loại vé";
            dgv_data.Columns[5].Name = "Ngày đi";
            dgv_data.Columns[6].Name = "Ngày về";
            dgv_data.Columns[7].Name = "Điểm đi";
            dgv_data.Columns[8].Name = "Điểm đến";
            dgv_data.Columns[9].Name = "Giá vé";
            dgv_data.Columns[10].Name = "Mã ghế";
            dgv_data.Columns[11].Name = "ID";
            dgv_data.Columns[11].Visible = false;
            foreach (var item in _ticketServices.list_Ticket().Where(c => c.Status == 1))
            {
                var cus = _customerServices.GetCustomers().Where(c => c.Id == item.CustomerId).FirstOrDefault();

                var flight = _flightServices.get_list().Where(c => c.Id == item.FlightId && c.DateFlight == date_NgayDi.Value && c.DateTo == date_NgayVe.Value && c.GoFrom == cbb_DiemDi.Text && c.GoTom == cbb_DiemDen.Text).FirstOrDefault();
                if (flight != null)
                {
                    var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
                    var seat = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id && c.SeatCode == "").FirstOrDefault();
                    dgv_data.Rows.Add(item.NameTicket, cus.Email, flight.FlightCode, item.CreateDate, item.TwoWay, flight.DateFlight, flight.DateTo, flight.GoFrom, flight.GoTom, item.TotalPrice, item.SeatCode, item.Id);
                }
            }
            if (dgv_data.RowCount > 0)
            {
                date_NgayDi.Value = (DateTime)(dgv_data.Rows[0].Cells[5].Value);
                date_NgayVe.Value = (DateTime)(dgv_data.Rows[0].Cells[6].Value);
                cbb_DiemDen.Text = dgv_data.Rows[0].Cells[8].Value.ToString();
                cbb_DiemDi.Text = dgv_data.Rows[0].Cells[7].Value.ToString();
            }
        }
    }
}
