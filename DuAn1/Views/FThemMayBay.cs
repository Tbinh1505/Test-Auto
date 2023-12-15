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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FThemMayBay : Form
    {
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        public FThemMayBay()
        {
            _seatDetailServices = new SeatDetailServices();
            _planeTypeServices = new PlaneTypeServices();
            InitializeComponent();
            cmb_totalSeats.Items.Add(30);
            cmb_totalSeats.Items.Add(50);
            load();
        }
        bool checkDuplicate()
        {
            foreach (var item in _planeTypeServices.get_list())
            {
                if (item.PlaneCode == txt_PlaneCode.Text)
                {
                    return false;
                }
            }
            return true;
        }
        bool checkEmpty()
        {
            if (txt_NamePlane.Text == "" || txt_PlaneCode.Text == "")
            {
                return false;
            }
            return true;
        }
        void load()
        {
           
            dgv_dataPlane.Rows.Clear();
            dgv_dataPlane.ColumnCount = 3;
            dgv_dataPlane.Columns[0].Name = "Mã máy bay";
            dgv_dataPlane.Columns[1].Name = "Tên máy bay";
            dgv_dataPlane.Columns[2].Name = "Tổng số ghế";
            foreach (var item in _planeTypeServices.get_list())
            {
                dgv_dataPlane.Rows.Add(item.PlaneCode, item.DisplayName, item.TotalSeat);
            }
            btn_update.Enabled = false;
            cmb_totalSeats.SelectedIndex = 0;
        }

        public void dgv_dataPlane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
            txt_PlaneCode.Text = dgv_dataPlane.CurrentRow.Cells[0].Value.ToString();
            txt_NamePlane.Text = dgv_dataPlane.CurrentRow.Cells[1].Value.ToString();
            cmb_totalSeats.Text = dgv_dataPlane.CurrentRow.Cells[2].Value.ToString();
        }
        void createSeatDetail(long id)
        {
            var plane = _planeTypeServices.get_list().Where(c => c.Id == id).FirstOrDefault();
            int a = 0;
            for (int i = 0; i < plane.TotalSeat; i++)
            {
                if (plane.TotalSeat == 30)
                {
                    if (i < 20)
                    {
                        SeatDetail seat = new SeatDetail();
                        seat.ClassId = 2;
                        seat.PlaneTypeId = plane.Id;
                        seat.SeatCode = "PT" + (i + 1);
                        _seatDetailServices.Create(seat);
                    }
                    else
                    {
                        SeatDetail seat = new SeatDetail();
                        seat.ClassId = 1;
                        seat.PlaneTypeId = plane.Id;
                        seat.SeatCode = "TG" + (a + 1);
                        _seatDetailServices.Create(seat);
                    }
                }
                else
                {
                    if (i < 35)
                    {
                        SeatDetail seat = new SeatDetail();
                        seat.ClassId = 2;
                        seat.PlaneTypeId = plane.Id;
                        seat.SeatCode = "PT" + (i + 1);
                        _seatDetailServices.Create(seat);
                    }
                    else
                    {
                        SeatDetail seat = new SeatDetail();
                        seat.ClassId = 1;
                        seat.PlaneTypeId = plane.Id;
                        seat.SeatCode = "TG" + (a + 1);
                        _seatDetailServices.Create(seat);
                    }
                }
            }
        }
        public void btn_add_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {
                if (checkDuplicate())
                {
                    PlaneType planeType = new PlaneType();
                    planeType.DisplayName = txt_NamePlane.Text;
                    planeType.PlaneCode = txt_PlaneCode.Text;
                    planeType.TotalSeat = Convert.ToInt32(cmb_totalSeats.Text);
                    MessageBox.Show(_planeTypeServices.create(planeType));
                    var plane=_planeTypeServices.get_list().Where(c=>c.PlaneCode== planeType.PlaneCode).FirstOrDefault();
                    createSeatDetail(plane.Id);
                    load();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã máy bay khác mã đã nhập trùng máy bay đã có sẵn");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        public void btn_update_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
            {

                PlaneType planeType = _planeTypeServices.get_list().Where(c => c.PlaneCode == txt_PlaneCode.Text).FirstOrDefault();
                planeType.DisplayName = txt_NamePlane.Text;
                MessageBox.Show(_planeTypeServices.update(planeType));
                load();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
    }
}
