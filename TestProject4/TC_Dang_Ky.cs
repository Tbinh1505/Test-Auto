using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace TestProject4
{
    [TestFixture]
    public class TC_DangKy
    {
        //các nút và textbox trong forrm login
        public WindowsElement taiKhoan => drive.FindElementByAccessibilityId("tb_user");
        public WindowsElement dangKy => drive.FindElementByName("Đăng ký");
        public WindowsElement quenMatKhau => drive.FindElementByName("Quên mật khẩu?");
        public WindowsElement ghiNhoLogin => drive.FindElementByAccessibilityId("cb_reme");
        public WindowsElement matKhau => drive.FindElementByAccessibilityId("tb_pass");
        public WindowsElement dangNhap => drive.FindElementByAccessibilityId("btn_login");
        public WindowsElement thongBao => drive.FindElementByAccessibilityId("2");

        public WindowsElement thoat => drive.FindElementByName("Close");
        public static AppiumOptions options = new AppiumOptions();
        string actual;
        WindowsDriver<WindowsElement> drive;

        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");//gọi winappdrive

            options.AddAdditionalCapability("app", @"C:\Users\ASUS\source\repos\DuAn1\bin\Debug\net6.0-windows\GUI.exe");//đường dẫn đến app cần test

            drive = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void ExistTest()
        {
            drive.Quit();
        }

        //cắt chuỗi để lấy số
        int cutInt(string inputString)
        {
            // Sử dụng regex để tìm chuỗi chứa số
            string pattern = @"\d+";
            Match match = Regex.Match(inputString, pattern);

                string numberPart = match.Value;
            int opt = int.Parse(numberPart);
            return opt;
        }
        //Chức năng đăng nhập
        //tài khoản mật khẩu trống
        //Hiện ra thông báo vui lòng không để trống email và mật khẩu
        [Test]
        public void TestCase_DK1()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(dangKy).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            string ngay = "15";
            string thang = "15";
            string nam = "2003";
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            //txb_name
            drive.FindElementByAccessibilityId("txb_name").SendKeys("Nguyễn Đức Việt");
            //txb_email
            drive.FindElementByAccessibilityId("txb_email").SendKeys("vpnbi7389@gmail.com");
            //date
            WindowsElement dateTimepick = drive.FindElementByAccessibilityId("Date");
            dateTimepick.Click();
            //nhập năm
            //nhập tháng
            actions.SendKeys(Keys.Left).SendKeys(thang).Perform();
            Thread.Sleep(1000);
            //nhập ngày
            actions.SendKeys(Keys.Left).SendKeys(ngay).Perform();
            actions.SendKeys(Keys.Left).SendKeys(nam).Perform();
            Thread.Sleep(5000);
            //btn_SendCode
            drive.FindElementByAccessibilityId("btn_SendCode").Click();
            //65535 thông báo
            Thread.Sleep(9000);
            WindowsElement succ = drive.FindElementByAccessibilityId("65535");
            string otp_code = succ.Text;
            int pass = cutInt(otp_code);
            thongBao.Click();
            Thread.Sleep(2000);
            //txb_Otp
            drive.FindElementByAccessibilityId("txb_Otp").SendKeys(Convert.ToString(pass));
            //tbx_phone
            drive.FindElementByAccessibilityId("tbx_phone").SendKeys("0989789678");
            //txb_address
            drive.FindElementByAccessibilityId("txb_address").SendKeys("Nhà ở Hồ Gươm");
            //tbx_pass1
            drive.FindElementByAccessibilityId("tbx_pass1").SendKeys("Binh@123");
            //tbx_pass2
            drive.FindElementByAccessibilityId("tbx_pass2").SendKeys("Binh@123");
            //cbx_gender
            WindowsElement gen = drive.FindElementByAccessibilityId("cbx_gender");
            //giới tính nữ
            gen.SendKeys("Nữ");
            Thread.Sleep(2000);
            //btn_sign
            drive.FindElementByAccessibilityId("btn_sign").Click();
            Thread.Sleep(2000);
           WindowsElement su = drive.FindElementByAccessibilityId("66535");
            actual = su.Text;
            //Điền đúng thông tin được yêu cầu!
            Assert.AreEqual("Đăng ký thành công", actual);
        }

        //Hiện ra thông báo vui lòng không để trống email và mật khẩu
        [Test]
        public void TestCase_DK2()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(dangKy).Click().Perform();
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            //txb_name
            drive.FindElementByAccessibilityId("txb_name").SendKeys("Nguyễn Đức Việt");
            //txb_email
            drive.FindElementByAccessibilityId("txb_email").SendKeys("vpnbi7389@gmail.com");
            //btn_sendCode
            drive.FindElementByAccessibilityId("btn_SendCode").Click();
            Thread.Sleep(2000);
            // thông báo
            WindowsElement tb = drive.FindElementByAccessibilityId("65535");
            actual = tb.Text;
            thongBao.Click();
            Assert.AreEqual("Email đã được sử dụng để đăng ký", actual);
        }

        [Test]
        public void TestCase_DK3()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(dangKy).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            string ngay = "15";
            string thang = "15";
            string nam = "2003";
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            //txb_name
            drive.FindElementByAccessibilityId("txb_name").SendKeys("123213binh thnha ibnh");
            //txb_email
            drive.FindElementByAccessibilityId("txb_email").SendKeys("binhptph30020@fpt.edu.vn");
            //date
            WindowsElement dateTimepick = drive.FindElementByAccessibilityId("Date");
            dateTimepick.Click();
            //nhập năm
            //nhập tháng
            actions.SendKeys(Keys.Left).SendKeys(thang).Perform();
            //nhập ngày
            actions.SendKeys(Keys.Left).SendKeys(ngay).Perform();
            actions.SendKeys(Keys.Left).SendKeys(nam).Perform();
            //btn_SendCode
            drive.FindElementByAccessibilityId("btn_SendCode").Click();
            //65535 thông báo
            Thread.Sleep(9000);
            WindowsElement succ = drive.FindElementByAccessibilityId("65535");
            string otp_code = succ.Text;
            int pass = cutInt(otp_code);
            thongBao.Click();
            Thread.Sleep(2000);
            //txb_Otp
            drive.FindElementByAccessibilityId("txb_Otp").SendKeys(Convert.ToString(pass));
            //tbx_phone
            drive.FindElementByAccessibilityId("tbx_phone").SendKeys("0979391154");
            //txb_address
            drive.FindElementByAccessibilityId("txb_address").SendKeys("123");
            //tbx_pass1
            drive.FindElementByAccessibilityId("tbx_pass1").SendKeys("Binh@1231");
            //tbx_pass2
            drive.FindElementByAccessibilityId("tbx_pass2").SendKeys("Binh@1231");
            //cbx_gender
            WindowsElement gen = drive.FindElementByAccessibilityId("cbx_gender");
            //giới tính nữ
            gen.SendKeys("Nữ");
            Thread.Sleep(2000);
            //btn_sign
            drive.FindElementByAccessibilityId("btn_sign").Click();
            Thread.Sleep(3000);
            WindowsElement su = drive.FindElementByAccessibilityId("65535");
            actual = su.Text;
            thongBao.Click();
            Assert.AreEqual("Điền đúng thông tin được yêu cầu!", actual);
        }

        [Test]
        public void TestCase_DK4()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(dangKy).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            string ngay = "15";
            string thang = "15";
            string nam = "2003";
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            //txb_name
            drive.FindElementByAccessibilityId("txb_name").SendKeys("@#!$%binh thanh binh");
            //txb_email
            drive.FindElementByAccessibilityId("txb_email").SendKeys("phungthanhbinh594@gmail.com");
            //date
            WindowsElement dateTimepick = drive.FindElementByAccessibilityId("Date");
            dateTimepick.Click();
            //nhập năm
            //nhập tháng
            actions.SendKeys(Keys.Left).SendKeys(thang).Perform();
            //nhập ngày
            actions.SendKeys(Keys.Left).SendKeys(ngay).Perform();
            actions.SendKeys(Keys.Left).SendKeys(nam).Perform();
            //btn_SendCode
            drive.FindElementByAccessibilityId("btn_SendCode").Click();
            //65535 thông báo
            Thread.Sleep(9000);
            WindowsElement succ = drive.FindElementByAccessibilityId("65535");
            string otp_code = succ.Text;
            int pass = cutInt(otp_code);
            thongBao.Click();
            Thread.Sleep(2000);
            //txb_Otp
            drive.FindElementByAccessibilityId("txb_Otp").SendKeys(Convert.ToString(pass));
            //tbx_phone
            drive.FindElementByAccessibilityId("tbx_phone").SendKeys("0979391154");
            //txb_address
            drive.FindElementByAccessibilityId("txb_address").SendKeys("123");
            //tbx_pass1
            drive.FindElementByAccessibilityId("tbx_pass1").SendKeys("Binh@1231");
            //tbx_pass2
            drive.FindElementByAccessibilityId("tbx_pass2").SendKeys("Binh@1231");
            //cbx_gender
            WindowsElement gen = drive.FindElementByAccessibilityId("cbx_gender");
            //giới tính nữ
            gen.SendKeys("Nữ");
            Thread.Sleep(2000);
            //btn_sign
            drive.FindElementByAccessibilityId("btn_sign").Click();
            Thread.Sleep(3000);
            WindowsElement su = drive.FindElementByAccessibilityId("65535");
            actual = su.Text;
            thongBao.Click();
            Assert.AreEqual("Tên người dùng không được chứa ký tự đặc biệt", actual);
        }
    }
}
