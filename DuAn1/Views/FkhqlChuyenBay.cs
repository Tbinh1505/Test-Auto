using _1_DAL.IRepon;
using _1_DAL.Models;
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
    public partial class FkhqlChuyenBay : Form
    {
        ITicketServices _ticketServices;
        ICustomerServices _customerServices;
        IFlightServices _flightServices;
        public FkhqlChuyenBay()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _flightServices = new FlightServices();
            _ticketServices = new TicketServices();
            _customerServices = new CustomerServices();
            InitializeComponent();
        }
        public FkhqlChuyenBay(int idFlight) : this()
        {
            dgv_InforCus.ColumnCount = 6;
            dgv_InforCus.Columns[0].Name = "Họ tên";
            dgv_InforCus.Columns[1].Name = "Số điện thoại";
            dgv_InforCus.Columns[2].Name = "Giới tính";
            dgv_InforCus.Columns[3].Name = "Địa chỉ";
            dgv_InforCus.Columns[4].Name = "Ghế ngồi";
            dgv_InforCus.Columns[5].Name = "Mã chuyến bay";
            dgv_InforCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_InforCus.AllowUserToAddRows = false;
            foreach (var item in _ticketServices.list_Ticket().Where(c => c.FlightId == idFlight))
            {
                var cus = _customerServices.GetCustomers().Where(c => c.Id == item.CustomerId).FirstOrDefault();
                var fl = _flightServices.get_list().Where(c => c.Id == item.FlightId).FirstOrDefault();
                dgv_InforCus.Rows.Add(cus.FirstName + " " + cus.MiddleName + " " + cus.LastName, cus.Phone, cus.Gender, cus.Address, item.SeatCode, fl.FlightCode);
            }
            txt_Name.Text = dgv_InforCus.Rows[0].Cells[0].Value.ToString();
            txt_PhoneNumber.Text = dgv_InforCus.Rows[0].Cells[1].Value.ToString();
            txt_Gender.Text = dgv_InforCus.Rows[0].Cells[2].Value.ToString();
            txt_Address.Text = dgv_InforCus.Rows[0].Cells[3].Value.ToString();
            txt_SeatCode.Text = dgv_InforCus.Rows[0].Cells[4].Value.ToString();
            txt_FlightCode.Text = dgv_InforCus.Rows[0].Cells[5].Value.ToString();
        }

        public void dgv_InforCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dgv_InforCus.CurrentRow.Cells[0].Value.ToString();
            txt_PhoneNumber.Text = dgv_InforCus.CurrentRow.Cells[1].Value.ToString();
            txt_Gender.Text = dgv_InforCus.CurrentRow.Cells[2].Value.ToString();
            txt_Address.Text = dgv_InforCus.CurrentRow.Cells[3].Value.ToString();
            txt_SeatCode.Text = dgv_InforCus.CurrentRow.Cells[4].Value.ToString();
            txt_FlightCode.Text = dgv_InforCus.CurrentRow.Cells[5].Value.ToString();
        }

 
    }
}
