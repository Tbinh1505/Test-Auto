using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace _2_BUS.Validate
{
    public class Validate
    {
        IStaffServices _staffServices;
        public Validate()
        {
            _staffServices = new StaffServices();
        }
        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"([\w]{5})+@[a-z]+\.([a-z]{2,3}|[a-z]{2,3}\.[a-z]{2,3})$");
            Match match = regex.Match(email);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public string[] cutName(string name)
        {
            string[] term = name.Split(' ');
            int number = 0;
            string firstname = "";
            string middlename = "";
            string lastname = "";
            for (int i = 0; i < term.Length; i++)
            {
                if (term[i] != " ")
                {
                    number++;
                    if (number == 1)
                    {
                        firstname = term[i].Trim();
                    }
                    else
                    {
                        middlename += term[i] + " ";
                    }
                }
            }
            string[] term1 = middlename.Trim().Split(' ');
            middlename = "";
            for (int i = 0; i < term1.Length - 1; i++)
            {
                middlename += term1[i] + " ";
            }
            lastname = term1[term1.Length - 1];
            string[] name1 = { firstname.Trim(), middlename.Trim(), lastname.Trim() };
            return name1;
        }

        public bool checkPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"^(0|\+84)([3|9|8|7|5])(\d{8})$");
            Match match = regex.Match(phone);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public bool checkpass(string pass)
        {
            Regex regex = new Regex(@"((?=.*?[!@#$%^&*])(^[a-z0-9A-Z@!#$%^&*]).([^\s]){4,100})$");
            Match match = regex.Match(pass);
            if (match!=Match.Empty)
            {
                return true;
            }
            return false;
        }
        public bool checkName(string name)
        {
            Regex regex = new Regex(@"^[a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ']{2,10}((\s[a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ']{2,10})){2,10}$");
            Match match = regex.Match(name);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> SendEmailVerify(string _email, string _subject, string _body, string code_otp,int role)
        {
            try
            {
                //staff là mail của admin để gửi
                staff staff = _staffServices.get(role);
                string senderID =staff.Email;
                string senderPassword =staff.Password;
                string body = _body;
                MailMessage mail = new MailMessage();

                SmtpClient smtp = new SmtpClient();
                body += code_otp;
                try
                {
                    mail.To.Add(_email);//đến mail ng dùng nào
                    mail.From = new MailAddress(senderID);//mail admin dùng để gửi
                    mail.Subject = _subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    smtp.Host = "smtp.gmail.com"; //host hỗ trợ gmail của smtp
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);//sử dụng mail nào gửi thì add đây nài
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);//gửi mail này
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> SendEmailInfoTiket(string _email, string _subject, string _body, int role)
        {
            try
            {
                //staff là mail của admin để gửi
                staff staff = _staffServices.get(role);
                string senderID = staff.Email;
                string senderPassword = staff.Password;
                string body = _body;
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                try
                {
                    mail.To.Add(_email);//đến mail ng dùng nào
                    mail.From = new MailAddress(senderID);//mail admin dùng để gửi
                    mail.Subject = _subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    smtp.Host = "smtp.gmail.com"; //host hỗ trợ gmail của smtp
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);//sử dụng mail nào gửi thì add đây nài
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);//gửi mail này
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string randomCode()
        {
            int ran = 0;
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                Random random = new Random();
                ran = random.Next(0, 10);
                code += ran.ToString();
            }
            return code;
        }
        public string ReversePass(string password)
        {
            byte[] pass_byte = ASCIIEncoding.ASCII.GetBytes(password);//dịch pass ra dạng bytes theo bảng mã ASCII
            MD5 mD5 = MD5.Create();

            var haspass = mD5.ComputeHash(pass_byte);//chuyển mảng bytes vừa dịch ra thành mảng bytes khác bằng md5
            string savehas = "";

            foreach (var item in haspass)
            {
                //chuyển dạng bytes về chuỗi để đảo ngược dãy bytes
                savehas += item;
            }

            char[] term = savehas.ToCharArray();
            Array.Reverse(term);//hàm đảo ngược
            string new_haspasscode = new string(term);// đưa về dạng chuỗi sau khi đảo

            pass_byte = ASCIIEncoding.ASCII.GetBytes(new_haspasscode);//tiếp tục chuyển sang bytes
            haspass = mD5.ComputeHash(pass_byte);//tiếp tục dùng md5 phân nhỏ
            savehas = "";
            foreach (var item in haspass)
            {
                savehas += item;
            }

            char[] chars = savehas.ToCharArray();//đưa về mảng char
            //mảng char theo ascii công thức: char+ vị trí chính nó + char vị trí liền kề %2
            var char_reverse = chars.Select((value, index) => new { value, index }).ToArray();
            var finish = char_reverse.Select(c => c.value + c.index + (char_reverse.Length > c.index + 1 ? char_reverse[c.index + 1].value % 2 : char_reverse[c.index / 2].value % 2)).Select(c => (char)c).ToArray();
            string new_char = new string(finish);
            foreach (var item in char_reverse)//đưa về dạng chuỗi trả ra kết quả
            {
                new_char += item.value;
            }

            return new_char;
        }

    }
}
