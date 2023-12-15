using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using Guna.UI2.Designer;
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
    public partial class FLichBayChild : Form
    {
        string _email = "";
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        public FLichBayChild()
        {
            InitializeComponent();
        }
        public FLichBayChild(List<Flight> list, DateTime date, string email) : this()
        {
            _email = email;

            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day).AddDays(5);
            foreach (Control item in groupBox1.Controls)
            {
                for (int i = 3; i < 7; i++)
                {
                    if (item.Name == $"label{i}")
                    {
                        dateTime = dateTime.AddDays(-1);
                        item.Text = $"{dateTime.Day}/{dateTime.Month}";
                        break;
                    }
                }
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in _planeTypeServices.get_list())
            {
                //Point loca_timeStart = new Point(25, 35);
                //Point loca_timeEnd = new Point(147, 35);
                Point loca_code = new Point(25, 45);
                Point loca_StopPoint = new Point(453, 45);
                Point loca_pic = new Point(635, 22);
                Point loca_textPic = new Point(650, 72);
                GroupBox group = new GroupBox();
                group.Size = new Size(1140, 105);
                int count = 0;
                DateTime date1 = new DateTime(date.Year, date.Month, date.Day).AddDays(1);
                var info = list.Where(c => c.PlaneTypeId == item.Id).FirstOrDefault();
                if (info != null)
                {
                    //Label lb_timeStart = new Label();
                    //lb_timeStart.Text = info.TimeStart.ToString();
                    ////lb_timeStart.Location = loca_timeStart;
                    //lb_timeStart.ForeColor = Color.DarkCyan;
                    //lb_timeStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    //Label lb_timeEnd = new Label();
                    //lb_timeEnd.Text = info.TimeEnd.ToString();
                    //lb_timeEnd.Location = loca_timeEnd;
                    //lb_timeEnd.ForeColor = Color.DarkCyan;
                    //lb_timeEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    Label lb_code = new Label();
                    lb_code.Text = item.PlaneCode;
                    lb_code.Location = loca_code;
                    lb_code.ForeColor = Color.DarkCyan;
                    lb_code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    Label lb_stopPoint = new Label();
                    lb_stopPoint.Text = "Bay thẳng";
                    lb_stopPoint.Location = loca_StopPoint;

                    //group.Controls.Add(lb_timeStart);
                    //group.Controls.Add(lb_timeEnd);
                    group.Controls.Add(lb_code);
                    group.Controls.Add(lb_stopPoint);
                }
                for (int i = 0; i < 4; i++)
                {
                    var fl = list.Where(c => c.PlaneTypeId == item.Id && c.DateFlight == date1).FirstOrDefault();
                    if (fl != null)
                    {
                        PictureBox pic = new PictureBox();
                        Image image = Image.FromFile(@"..\\..\\..\\Resources\\icons8-plane-30 (2).png");
                        pic.Image = image;
                        pic.Size = new Size(64, 47);
                        pic.Location = loca_pic;
                        pic.Click += Pic_Click;
                        pic.MouseHover += Pic_MouseHover;
                        pic.MouseLeave += Pic_MouseLeave;
                        pic.Name = fl.FlightCode;
                        pic.BackColor = SystemColors.Control;
                        pic.SizeMode = PictureBoxSizeMode.CenterImage;

                        Label lb_select = new Label();
                        lb_select.Text = "Chọn";
                        lb_select.ForeColor = Color.DarkCyan;
                        lb_select.Location = loca_textPic;
                        group.Controls.Add(pic);
                        group.Controls.Add(lb_select);
                    }
                    date1 = date1.AddDays(1);
                    loca_pic.X += 135;
                    loca_textPic.X += 135;
                }
                if (group.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Add(group);
                }
            }
        }

        private void Pic_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)(sender);
            pic.Cursor = Cursors.Default;
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Pic_MouseHover(object? sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)(sender);
            pic.Cursor = Cursors.Hand;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void Pic_Click(object? sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)(sender);
            var flight = _flightServices.get_list().Where(c => c.FlightCode == pic.Name).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            if (DateTime.Compare(flight.DateFlight, DateTime.Now) == 1)
            {
                if (seatdetail.Count() == 50)
                {
                    FChonGheBigSize fChonGhe = new FChonGheBigSize(pic.Name, _email);
                    this.Hide();
                    fChonGhe.ShowDialog();
                    this.Show();
                    if (fChonGhe.status == "True")
                    {
                        this.Close();
                    }
                }
                else
                {
                    FChonGheSmallSize fChonGhe = new FChonGheSmallSize(pic.Name, _email);
                    this.Hide();
                    fChonGhe.ShowDialog();
                    this.Show();
                    if (fChonGhe.status == "True")
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                TimeSpan timeNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                if (flight.TimeStart.Hours - timeNow.Hours > 6)
                {
                    if (seatdetail.Count() == 50)
                    {
                        FChonGheBigSize fChonGhe = new FChonGheBigSize(pic.Name, _email);
                        this.Hide();
                        fChonGhe.ShowDialog();
                        this.Show();
                        if (fChonGhe.status == "True")
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        FChonGheSmallSize fChonGhe = new FChonGheSmallSize(pic.Name, _email);
                        this.Hide();
                        fChonGhe.ShowDialog();
                        this.Show();
                        if (fChonGhe.status == "True")
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chuyến bay quá thời gian đặt vé");
                }
            }
        }
    }
}
