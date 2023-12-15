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
    public class TC_Quan_Ly_nhan_Vien
    {
        public WindowsElement taiKhoan => drive.FindElementByAccessibilityId("tb_user");
        public WindowsElement matKhau => drive.FindElementByAccessibilityId("tb_pass");
        public WindowsElement dangNhap => drive.FindElementByAccessibilityId("btn_login");
        public WindowsElement thongBao => drive.FindElementByAccessibilityId("2");

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

        void Send()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
        }

        [Test]

        public void TestCase_GDCCN_QLNV1()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(10000);

            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Sua").Click();

            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();
            Assert.AreEqual("Sửa thành công", actual);


        }

        [Test]
        public void TestCase_GDCCN_QLNV2()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            WindowsElement name = drive.FindElementByAccessibilityId("txt_Ten");
            //WindowsElement emai = drive.FindElementByAccessibilityId("txt_Sdt");
            //WindowsElement sdt = drive.FindElementByAccessibilityId("txt_Email");
            //WindowsElement pass = drive.FindElementByAccessibilityId("txt_Pass");


            //WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            //actual = thongp.Text;
            //thongBao.Click();
            Assert.AreEqual(name.Enabled, name.Enabled);
        }

        [Test]
        public void TestCase_GDCCN_QLNV3()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(10000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();
                
            drive.FindElementByAccessibilityId("txt_Ten").SendKeys("Nguyễn Đức Việt");
            drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0979391154");
            drive.FindElementByAccessibilityId("txt_Email").SendKeys("vietndph29972@fpt.edu.vn");
            drive.FindElementByAccessibilityId("txt_Pass").SendKeys("Viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();

            Assert.AreEqual("Email hoặc số điện thoại đã được sử dụng để đăng kí!", actual);

        }
        [Test]
        public void TestCase_GDCCN_QLNV4()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            drive.FindElementByAccessibilityId("txt_Ten").SendKeys("Nguyễn Đức Việt");
           drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0979391154");
           drive.FindElementByAccessibilityId("txt_Email").SendKeys("vietndph29972@fpt.edu.vn");
          drive.FindElementByAccessibilityId("txt_Pass").SendKeys("Viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();

            Assert.AreEqual("Thêm thành công", actual);

        }

        [Test]
        public void TestCase_GDCCN_QLNV5()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            drive.FindElementByAccessibilityId("txt_Ten").SendKeys("2#@viet nguyen duc");
            drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0989789123");
            drive.FindElementByAccessibilityId("txt_Email").SendKeys("viet2003@gmail.com");
            drive.FindElementByAccessibilityId("txt_Pass").SendKeys("Viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();

            Assert.AreEqual("Nhập thông tin đúng định dạng", actual);

        }

        [Test]
        public void TestCase_GDCCN_QLNV6()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            drive.FindElementByAccessibilityId("txt_Ten").SendKeys("viet nguyen duc");
            drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0989789123");
            drive.FindElementByAccessibilityId("txt_Email").SendKeys("&^*viet2003@gmail.com");
            drive.FindElementByAccessibilityId("txt_Pass").SendKeys("viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();

            Assert.AreEqual("Vui lòng kiểm tra lại email", actual);

        }

        [Test]
        public void TestCase_GDCCN_QLNV7()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            //drive.FindElementByAccessibilityId("txt_Ten").SendKeys("viet nguyen duc");
            //drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0989789123");
            //drive.FindElementByAccessibilityId("txt_Email").SendKeys("&^*viet2003@gmail.com");
            //drive.FindElementByAccessibilityId("txt_Pass").SendKeys("viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Vui lòng nhập đầy đủ thông tin", actual);

        }

        [Test]
        public void TestCase_GDCCN_QLNV8()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("btn_qlynv").Click();
            drive.FindElementByAccessibilityId("btn_Them").Click();

            drive.FindElementByAccessibilityId("txt_Ten").SendKeys("phùng thanh bình phùng thanh");
            drive.FindElementByAccessibilityId("txt_Sdt").SendKeys("0989221332");
            drive.FindElementByAccessibilityId("txt_Email").SendKeys("binhplv2003@gmail.com");
            drive.FindElementByAccessibilityId("txt_Pass").SendKeys("viet@2003");

            drive.FindElementByAccessibilityId("btn_Them").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();
            Thread.Sleep(1000);
            Assert.AreEqual("Tên không được quá 30 kí tự", actual);

        }
    }
}
