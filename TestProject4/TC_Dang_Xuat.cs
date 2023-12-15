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
    public class TC_Dang_Xuat
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

        //Kiểm tra đăng xuất ở lại
        [Test]
        public void TestCase_GDCCN_HT_ĐX1()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            thongBao.Click();
            //đi vào form trong
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement heThong = drive.FindElementByName("Hệ thống");
            heThong.Click();
            WindowsElement dangXuat = drive.FindElementByName("Đăng xuất");
            dangXuat.Click();
            WindowsElement no = drive.FindElementByAccessibilityId("7");
            no.Click();
            Thread.Sleep(1000);
            drive.SwitchTo().Window(drive.WindowHandles.First());
            Assert.AreEqual("Giao diện các chức năng", drive.Title);
            drive.CloseApp();
        }

        //Kiểm tra đăng xuất thành công hay không
        [Test]
        public void TestCase_GDCCN_HT_ĐX2()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            thongBao.Click();
            //chờ form sau xuất hiện
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            WindowsElement heThong = drive.FindElementByName("Hệ thống");
            heThong.Click();
            WindowsElement dangXuat = drive.FindElementByName("Đăng xuất");
            dangXuat.Click();
            WindowsElement yes = drive.FindElementByAccessibilityId("6");
            yes.Click();
            WebDriverWait wait2 = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            Thread.Sleep(1000);
            drive.SwitchTo().Window(drive.WindowHandles.First());
            //Assert.AreEqual("Đăng nhập", drive.Title);
            Assert.AreEqual("Đăng nhập", drive.Title);
            drive.CloseApp();
        }

    }
}
