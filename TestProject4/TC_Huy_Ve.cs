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
    public class TC_Huy_Ve
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
            taiKhoan.SendKeys("cus1@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
        }

        //Qua thoi han huy ve
        [Test]
        public void TestCase_GDTC_QLVD1()
        {
            Send();
            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("guna2Button2").Click();
            drive.FindElementByAccessibilityId("11").Click(); // CHO ID TỪ BÊN HỦY VÉ VÀO

            //drive.FindElementByAccessibilityId("6").Click();
            WindowsElement s = drive.FindElementByAccessibilityId("65535");// cửa sổ thông báo hiển thị
            actual = s.Text;
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Quá thời hạn hủy vé", actual);
        }

        //Huy ve thanh cong
        [Test]
        public void TestCase_GDTC_QLVD2()
        {
            Send();
            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);
            drive.FindElementByAccessibilityId("guna2Button2").Click();
            drive.FindElementByName("Hủy vé").Click(); //cho id nút cần hủy vào đây
            WindowsElement s = drive.FindElementByAccessibilityId("65535");
            string er = s.Text;
            if (s.Text != "Quá thời hạn hủy vé")
            {
                drive.FindElementByAccessibilityId("6").Click();
                WindowsElement s2 = drive.FindElementByAccessibilityId("65535");
                actual = s2.Text;
                drive.FindElementByAccessibilityId("2").Click();
                Assert.AreEqual("Hủy vé thành công", actual);
            }
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Quá thời hạn hủy vé", er);

        }
    }
}
