using _1_DAL.Models;
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

namespace GUI.Views.View_User
{
    public partial class FBuyTicketChild : Form
    {
        string _email = "";
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        IClassServices _classServices;
        List<Flight> _test;
        long idmb;
        public FBuyTicketChild()
        {
            InitializeComponent();
        }
        public FBuyTicketChild(List<Flight> list, string email) : this()
        {
            _email = email;
            _test = list;
            _classServices = new ClassServices();
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            foreach (var item in list)
            {
                Panel form = new Panel();
                form.Name = item.FlightCode;
                form.Width = 1059;
                form.Height = 111;
                form.BorderStyle = BorderStyle.FixedSingle;
                Label time1 = new Label();// thời gian đi
                time1.Text = item.TimeStart.ToString();
                time1.ForeColor = Color.DarkCyan;
                time1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
                time1.Location = new Point(18, 30);
                Label time2 = new Label();// thời gian đến
                time2.Text = item.TimeEnd.ToString();
                time2.ForeColor = Color.DarkCyan;
                time2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
                time2.Location = new Point(149, 30);
                Label code = new Label();
                code.Text = item.FlightCode;
                code.Location = new Point(18, 62);
                Label name = new Label();
                var plane = _planeTypeServices.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault();
                name.Text = plane.DisplayName;
                name.Tag = plane.Id;
                name.Location = new Point(149, 62);
                Guna2Button pt = new Guna2Button();
                pt.Text = _classServices.get_list().Where(c => c.Id == 2).FirstOrDefault().Price.ToString();
                pt.BorderRadius = 10;
                pt.BorderThickness = 1;
                pt.FillColor = Color.White;
                pt.ForeColor = Color.DarkCyan;
                pt.BorderColor = Color.DarkCyan;
                pt.Width = 217;
                pt.Height = 76;
                pt.Location = new Point(613, 22);
                pt.Name = item.FlightCode;
                pt.Tag = "PT";
                pt.Click += Pt_Click;
                Guna2Button tg = new Guna2Button();
                tg.Text = _classServices.get_list().Where(c => c.Id == 1).FirstOrDefault().Price.ToString();
                tg.BorderRadius = 10;
                tg.BorderThickness = 1;
                tg.FillColor = Color.White;
                tg.ForeColor = Color.Goldenrod;
                tg.BorderColor = Color.Goldenrod;
                tg.Width = 217;
                tg.Height = 76;
                tg.Name = item.FlightCode;
                tg.Click += Tg_Click;
                tg.Tag = "TG";
                tg.Location = new Point(836, 22);
                form.Controls.Add(time1);
                form.Controls.Add(time2);
                form.Controls.Add(code);
                form.Controls.Add(name);
                form.Controls.Add(pt);
                form.Controls.Add(tg);
                flowLayoutPanel1.Controls.Add(form);
                idmb = (long)name.Tag;
            }
        }

        public void Tg_Click(object? sender, EventArgs e)
        {
            Guna2Button btn_current = (Guna2Button)sender;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == btn_current.Name).FirstOrDefault();

            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            DateTime dateNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (DateTime.Compare(flight.DateFlight, dateNow) == 1)
            {
                if (seatdetail.Count() == 50)
                {
                    FChonGheBigSize fChonGhe = new FChonGheBigSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                    FChonGheSmallSize fChonGhe = new FChonGheSmallSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                        FChonGheBigSize fChonGhe = new FChonGheBigSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                        FChonGheSmallSize fChonGhe = new FChonGheSmallSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                    MessageBox.Show("Không thể đặt vé chuyến bay này");
                }

            }
        }

        public void Pt_Click(object? sender, EventArgs e)
        {
            Guna2Button btn_current = (Guna2Button)sender;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == btn_current.Name).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            DateTime dateNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (DateTime.Compare(flight.DateFlight, dateNow) == 1)
            {
                if (seatdetail.Count() == 50)
                {
                    FChonGheBigSize fChonGhe = new FChonGheBigSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                    FChonGheSmallSize fChonGhe = new FChonGheSmallSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                        FChonGheBigSize fChonGhe = new FChonGheBigSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                        FChonGheSmallSize fChonGhe = new FChonGheSmallSize(btn_current.Name, btn_current.Tag.ToString(), _email);
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
                    MessageBox.Show("Không thể đặt vé chuyến bay này");
                }
            }
        }

    }
}
