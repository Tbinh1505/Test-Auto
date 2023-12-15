using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using Microsoft.Office.Interop.Excel;
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
    public partial class FquanLyDoanhThu : Form
    {
        ITicketServices _ticketServices;
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        public FquanLyDoanhThu()
        {
            _planeTypeServices = new PlaneTypeServices();
            _ticketServices = new TicketServices();
            _flightServices = new FlightServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            dgv_Revenue.ColumnCount = 6;
            dgv_Revenue.Rows.Clear();
            dgv_Revenue.Columns[0].Name = "STT";
            dgv_Revenue.Columns[1].Name = "Mã chuyến bay";
            dgv_Revenue.Columns[2].Name = "Ngày bay";
            dgv_Revenue.Columns[3].Name = "Số vé đã bán";
            dgv_Revenue.Columns[4].Name = "Tổng số vé";
            dgv_Revenue.Columns[5].Name = "Tổng doanh thu";
            var ticket = _ticketServices.list_Ticket().Where(c => c.Status == 1).ToList();
            int dem = 0;
            int thu = 0;
            for (int i = 0; i < ticket.Count; i++)
            {
                for (int j = 0; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId > ticket[j].FlightId)
                    {
                        Ticket term = ticket[i];
                        ticket[i] = ticket[j];
                        ticket[j] = term;
                    }
                    if (ticket[i].FlightId == ticket[j].FlightId)
                    {
                        if (thu == 0)
                        {
                            dem++;
                        }
                    }
                }
                thu++;
            }
            int total = 0;
            int stt = 1;
            for (int i = 0; i < ticket.Count; i++)
            {
                if (dem == ticket.Count)
                {
                    int soveban = 1;
                    total = ticket[i].TotalPrice;
                    for (int j = i + 1; j < ticket.Count; j++)
                    {
                        if (ticket[i].FlightId == ticket[j].FlightId)
                        {
                            soveban++;
                            total += ticket[j].TotalPrice;
                        }
                    }
                    var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                    var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                    dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, soveban, plane.TotalSeat, total);
                    break;
                }
                else
                {
                    int soveban = 1;
                    total = ticket[i].TotalPrice;
                    for (int j = i + 1; j < ticket.Count; j++)
                    {
                        if (ticket[i].FlightId == ticket[j].FlightId)
                        {
                            soveban++;
                            total += ticket[j].TotalPrice;
                        }
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }
                    if (soveban > 1)
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, soveban, plane.TotalSeat, total);
                        stt++;
                    }
                    if (soveban == 1)
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, 1, plane.TotalSeat, total);
                        stt++;
                    }
                    if (i + soveban == ticket.Count)
                    {
                        break;
                    }
                }
            }
        }
        public void btn_fill_Click(object sender, EventArgs e)
        {
            dgv_Revenue.ColumnCount = 6;
            dgv_Revenue.Rows.Clear();
            dgv_Revenue.Columns[0].Name = "STT";
            dgv_Revenue.Columns[1].Name = "Mã chuyến bay";
            dgv_Revenue.Columns[2].Name = "Ngày bay";
            dgv_Revenue.Columns[3].Name = "Số vé đã bán";
            dgv_Revenue.Columns[4].Name = "Tổng số vé";
            dgv_Revenue.Columns[5].Name = "Tổng doanh thu";
            var ticket = _ticketServices.list_Ticket().Where(c => c.CreateDate >= date_From.Value.AddDays(-1) && c.CreateDate <= date_To.Value && c.Status == 1).ToList();
            int dem = 0;
            int thu = 0;
            for (int i = 0; i < ticket.Count; i++)
            {
                for (int j = 0; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId > ticket[j].FlightId)
                    {
                        Ticket term = ticket[i];
                        ticket[i] = ticket[j];
                        ticket[j] = term;
                    }
                    if (ticket[i].FlightId == ticket[j].FlightId)
                    {
                        if (thu == 0)
                        {
                            dem++;
                        }
                    }
                }
                thu++;
            }
            int total = 0;
            int stt = 1;
            for (int i = 0; i < ticket.Count; i++)
            {
                if (dem == ticket.Count)
                {
                    int soveban = 1;
                    total = ticket[i].TotalPrice;
                    for (int j = i + 1; j < ticket.Count; j++)
                    {
                        if (ticket[i].FlightId == ticket[j].FlightId)
                        {
                            soveban++;
                            total += ticket[j].TotalPrice;
                        }
                    }
                    var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                    var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                    dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, soveban, plane.TotalSeat, total);
                    break;
                }
                else
                {
                    int soveban = 1;
                    total = ticket[i].TotalPrice;
                    for (int j = i + 1; j < ticket.Count; j++)
                    {
                        if (ticket[i].FlightId == ticket[j].FlightId)
                        {
                            soveban++;
                            total += ticket[j].TotalPrice;
                        }
                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }
                    if (soveban > 1)
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, soveban, plane.TotalSeat, total);
                        stt++;
                    }
                    if (soveban == 1)
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, 1, plane.TotalSeat, total);
                        stt++;
                    }
                    if (i + soveban == ticket.Count)
                    {
                        break;
                    }
                }
            }
        }

        public void date_To_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(date_From.Value, date_To.Value) == 1)
            {
                MessageBox.Show("Ngày sau không thể nhỏ hơn ngày trước");
                date_To.Value = date_From.Value;
            }
        }

        public void btn_Export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_Revenue);
        }
        public void ExportToExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            sheet.Name = "Exported from gridview";
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                sheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                sheet.StandardWidth = dataGridView.Columns[i].Width - 150;
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    sheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog1.FileName);
                MessageBox.Show("Xuất file thành công!");
                workbook.Close();
            }
        }
    }
}
