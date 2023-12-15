using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TestStack.White.UIItems.WindowItems;

namespace TestProject4
{
    [TestFixture]
    public class TC_Doi_Mat_Khau
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
        Actions acc;
        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");//gọi winappdrive

            options.AddAdditionalCapability("app", @"C:\Users\ASUS\source\repos\DuAn1\bin\Debug\net6.0-windows\GUI.exe");//đường dẫn đến app cần test

            drive = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            System.Threading.Thread.Sleep(2000);
            acc = new Actions(drive);
        }

        [TearDown]
        public void ExistTest()
        {
            drive.Quit();
        }
        
        void sendNhanVien()//đăng nhập vào tài khoản nhân viên
        {
            taiKhoan.SendKeys("luyenlv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
        }

        void sendCus()//đăng nhập vào tài khoản khách
        {
            taiKhoan.SendKeys("vpnbi7389@gmail.com");
            matKhau.SendKeys("binh@12345");
            dangNhap.Click();
        }

        //Thông tin tài khoản
        [Test]
        public void TestCase_GDCCN_HT_ĐMK1()
        {
            //thao tác
            sendNhanVien();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement heThong = drive.FindElementByName("Hệ thống");
            heThong.Click();
            WindowsElement dkm = drive.FindElementByName("Đổi mật khẩu");
            dkm.Click();
            Thread.Sleep(1000);
            drive.FindElementByAccessibilityId("tbx_passOld").SendKeys("1");
            drive.FindElementByAccessibilityId("tbx_passNew").SendKeys("binh@2003");
            drive.FindElementByAccessibilityId("tbx_passReNew").SendKeys("binh@2003");
            drive.FindElementByAccessibilityId("btn_doiMK").Click();
            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            Thread.Sleep(2000);
            drive.FindElementByAccessibilityId("2").Click();
            drive.FindElementByAccessibilityId("btn_Out").Click();
            Assert.AreEqual("Đổi mật khẩu thành công", actual);
        }


        [Test]
        public void TestCase_GDCCN_HT_ĐMK2()
        {

            //thao tác
            sendCus();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement nguoiDung = drive.FindElementByName("Người dùng");
            nguoiDung.Click();

            WindowsElement dkm = drive.FindElementByName("Đổi mật khẩu");
            dkm.Click();

            Thread.Sleep(1000);

            drive.FindElementByAccessibilityId("tbx_passOld").SendKeys("binh@12345");
            drive.FindElementByAccessibilityId("tbx_passNew").SendKeys("binh2003@");
            drive.FindElementByAccessibilityId("tbx_passReNew").SendKeys("binh2003@");

            drive.FindElementByAccessibilityId("btn_doiMK").Click();
            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            Thread.Sleep(2000);
            drive.FindElementByAccessibilityId("2").Click();
            drive.FindElementByAccessibilityId("btn_Out").Click();
            Assert.AreEqual("Đổi mật khẩu thành công!", actual);
        }


        [Test]
        public void TestCase_GDCCN_HT_ĐMK3()
        {
            //thao tác
            sendCus();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement nguoiDung = drive.FindElementByName("Người dùng");
            nguoiDung.Click();
            WindowsElement dkm = drive.FindElementByName("Đổi mật khẩu");
            dkm.Click();
            Thread.Sleep(1000);
            drive.FindElementByAccessibilityId("tbx_passOld").SendKeys("binh20031@");
            drive.FindElementByAccessibilityId("tbx_passNew").SendKeys("binh@12345");
            drive.FindElementByAccessibilityId("tbx_passReNew").SendKeys("binh@12345");

            drive.FindElementByAccessibilityId("btn_doiMK").Click();
            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            Thread.Sleep(2000);
            drive.FindElementByAccessibilityId("2").Click();
            drive.FindElementByAccessibilityId("btn_Out").Click();
            Assert.AreEqual("Mật khẩu không được quá 6 kí tự", actual);
        }


    }
}
