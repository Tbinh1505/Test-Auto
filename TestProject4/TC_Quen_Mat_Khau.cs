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
    public class TC_Quen_Mat_Khau
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


        [Test]
        public void TestCase_QMK1()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(quenMatKhau).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            //txb_email
            drive.FindElementByAccessibilityId("tbx_email").SendKeys("123123@gmail.com");
            drive.FindElementByAccessibilityId("btn_sendCode").Click();
            //65535 thông báo
            WindowsElement succ = drive.FindElementByAccessibilityId("65535");
            actual = succ.Text;
            Thread.Sleep(5000);
            thongBao.Click();
            Assert.AreEqual("Email chưa được sử dụng để đăng ký", actual);
        }

        [Test]
        public void TestCase_QMK2()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(quenMatKhau).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            drive.FindElementByAccessibilityId("tbx_email").SendKeys("binhptph30020@fpt.edu.vn");
            //tbx_pass1
            drive.FindElementByAccessibilityId("txb_pass1").SendKeys("binh123@");
            //tbx_pass2
            drive.FindElementByAccessibilityId("tbx_pass2").SendKeys("binh123@");
            WindowsElement btn_sc = drive.FindElementByAccessibilityId("btn_success");
            Thread.Sleep(2000);
            // nếu nút xác nhận bị displayed thì pass
            Assert.IsTrue(btn_sc.Displayed);
        }


        [Test]
        public void TestCase_QMK3()
        {
            Actions actions = new Actions(drive);
            actions.MoveToElement(quenMatKhau).Click().Perform();
            //thay ngày sinh muốn điền vào đây
            //chuyển hướng sang trang khác
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            drive.FindElementByAccessibilityId("tbx_email").SendKeys("vpnbi7389@gmail.com");
            //btn_sendCode
            drive.FindElementByAccessibilityId("btn_sendCode").Click();
            Thread.Sleep(5000);
            WindowsElement succ = drive.FindElementByAccessibilityId("65535");
            string otp_code = succ.Text;
            int pass = cutInt(otp_code);
            thongBao.Click();
            //code
            drive.FindElementByAccessibilityId("tbx_ma").SendKeys(Convert.ToString(pass));
            //tbx_pass1
            drive.FindElementByAccessibilityId("txb_pass1").SendKeys("binh123@");
            //tbx_pass2
            drive.FindElementByAccessibilityId("tbx_pass2").SendKeys("binh123@");
            drive.FindElementByAccessibilityId("btn_success").Click();
            Thread.Sleep(2000);
            WindowsElement sucs = drive.FindElementByAccessibilityId("65535");
            actual = sucs.Text;
            thongBao.Click();
            Assert.AreEqual("Cập nhật thành công!", actual);

        }

    }
}
