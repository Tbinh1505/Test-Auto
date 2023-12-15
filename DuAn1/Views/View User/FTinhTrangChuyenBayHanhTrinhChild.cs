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

namespace GUI.Views.View_User
{
    public partial class FTinhTrangChuyenBayHanhTrinhChild : Form
    {
        IPlaneTypeServices _planeTypeServices;
        IFlightServices _flightServices;
        public FTinhTrangChuyenBayHanhTrinhChild()
        {
            InitializeComponent();
        }
        public FTinhTrangChuyenBayHanhTrinhChild(List<Flight> flights) : this()
        {
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            Point pointStart = new Point(24, 32);
            Point pointEnd = new Point(151, 32);
            Point pointPlane = new Point(24, 61);
            Point pointFlight = new Point(151, 61);
            Point pointPlace = new Point(24, 98);
            Point pointStop = new Point(640, 66);
            Point pointStatus = new Point(945, 64);
            foreach (var item in flights)
            {
                GroupBox group = new GroupBox();
                group.Size = new Size(1052, 136);
                Label timeStart = new Label();
                timeStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                timeStart.ForeColor = Color.DarkCyan;
                Label timeEnd = new Label();
                timeEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                timeEnd.ForeColor = Color.DarkCyan;
                Label namePlane = new Label();
                Label codeFlight = new Label();
                Label place = new Label();
                Label stopPoint = new Label();
                Label status = new Label();
                timeStart.Text = item.TimeStart.ToString();
                timeStart.Location = pointStart;
                timeEnd.Text = item.TimeEnd.ToString();
                timeEnd.Location = pointEnd;
                namePlane.Text = _planeTypeServices.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                namePlane.Location = pointPlane;
                codeFlight.Text = item.FlightCode.ToString();
                codeFlight.Location = pointFlight;
                place.Text = $"{item.GoFrom} - {item.GoTom}";
                place.Location = pointPlace;
                place.Size = new Size(300, 20);
                stopPoint.Text = "Bay thẳng";
                stopPoint.Location = pointStop;
                status.Text = item.Status == 1 ? "Delay" : "Đúng giờ";
                status.Location = pointStatus;
                group.Controls.Add(timeStart);
                group.Controls.Add(timeEnd);
                group.Controls.Add(namePlane);
                group.Controls.Add(stopPoint);
                group.Controls.Add(status);
                group.Controls.Add(place);
                group.Controls.Add(codeFlight);
                flowLayoutPanel1.Controls.Add(group);
            }

        }
    }
}
