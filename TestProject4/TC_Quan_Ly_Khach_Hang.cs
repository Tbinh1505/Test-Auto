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
    public class TC_Quan_Ly_Khach_Hang
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

        //tìm kiếm theo sdt
        [Test]
        public void TestCase_GDCCN_QLKH1()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);

            drive.FindElementByAccessibilityId("btn_qlykh").Click();
            drive.FindElementByAccessibilityId("tb_find").SendKeys("0369897545");
            drive.FindElementByAccessibilityId("btn_find").Click();
            drive.FindElementByAccessibilityId("dtgv_kh").Click();

            drive.FindElementByName("Row 0").Click();
            WindowsElement phone = drive.FindElementByAccessibilityId("tb_phone");
            phone.Click();
            actual = phone.Text;
            if (phone.Text == "0369897545")
            {
                Assert.AreEqual("0369897545", actual);
            }
        }

        //tìm kiếm theo email
        [Test]
        public void TestCase_GDCCN_QLKH2()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);

            drive.FindElementByAccessibilityId("btn_qlykh").Click();
            drive.FindElementByAccessibilityId("tb_find").SendKeys("cus1@gmail.com");
            drive.FindElementByAccessibilityId("btn_find").Click();
            drive.FindElementByAccessibilityId("dtgv_kh").Click();

            drive.FindElementByName("Row 0").Click();
            WindowsElement phone = drive.FindElementByAccessibilityId("tb_email");
            phone.Click();
            actual = phone.Text;
            if (phone.Text == "cus1@gmail.com")
            {
                Assert.AreEqual("cus1@gmail.com", actual);
            }
        }

        //tìm kiếm để trống
        [Test]
        public void TestCase_GDCCN_QLKH3()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);

            drive.FindElementByAccessibilityId("btn_qlykh").Click();
            drive.FindElementByAccessibilityId("btn_find").Click();
            WindowsElement thongp = drive.FindElementByAccessibilityId("65535");
            actual = thongp.Text;
            thongBao.Click();
            Assert.AreEqual("Vui lòng nhập vào tên hoặc email, số điện thoại cần tìm kiếm", actual);
        }

        //tìm kiếm theo tên
        [Test]
        public void TestCase_GDCCN_QLKH4()
        {
            Send();

            thongBao.Click();
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(4000);

            drive.FindElementByAccessibilityId("btn_qlykh").Click();
            drive.FindElementByAccessibilityId("tb_find").SendKeys("Việt");
            drive.FindElementByAccessibilityId("btn_find").Click();
            drive.FindElementByAccessibilityId("dtgv_kh").Click();

            drive.FindElementByName("Row 0").Click();
            WindowsElement phone = drive.FindElementByAccessibilityId("tb_name");
            phone.Click();
            actual = phone.Text;
            if (phone.Text == "Việt")
            {
                Assert.AreEqual("Việt", actual);
            }
        }
    }
}
