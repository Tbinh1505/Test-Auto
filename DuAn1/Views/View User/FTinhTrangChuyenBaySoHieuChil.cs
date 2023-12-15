using _1_DAL.Models;
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
    public partial class FTinhTrangChuyenBaySoHieuChil : Form
    {
        PlaneTypeServices _planeTypeServices;
        public FTinhTrangChuyenBaySoHieuChil()
        {
            _planeTypeServices = new PlaneTypeServices();
            InitializeComponent();
        }
        public FTinhTrangChuyenBaySoHieuChil(Flight flights) : this()
        {
            lb_TimeStart.Text = flights.TimeStart.ToString();
            lb_TimeEnd.Text = flights.TimeEnd.ToString();
            lb_NamePlane.Text = _planeTypeServices.get_list().Where(c => c.Id == flights.PlaneTypeId).FirstOrDefault().DisplayName;
            lb_FiightCode.Text = flights.FlightCode;
            lb_place.Text = $"{flights.GoFrom} - {flights.GoTom}";
            lb_StatusFlight.Text = flights.Status == 0 ? "Đúng giờ" : "Delay";
            lb_StatusFlight1.Text = flights.Status == 0 ? "Đúng giờ" : "Delay";
            lb_StatusFlight2.Text = flights.Status == 0 ? "Đúng giờ" : "Delay";
            lb_timeStart1.Text = flights.TimeStart.ToString();
            lb_timeEnd1.Text = flights.TimeEnd.ToString();
        }
    }
}
