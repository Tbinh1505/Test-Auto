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
    public class TC_Them_May_Bay
    {
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

        void SendKey()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            thongBao.Click();
        }
        //Thêm máy bay
        //trống dữ liệu
        [Test]
        public void TestCase_GDCCN_TMB1()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            thongBao.Click();

            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement btnPlane = drive.FindElementByAccessibilityId("btn_addPlane");
            btnPlane.Click();

            WindowsElement btn_add = drive.FindElementByAccessibilityId("btn_add");
            btn_add.Click();

            WindowsElement thongBaox = drive.FindElementByAccessibilityId("65535");
            actual = thongBaox.Text;

            Thread.Sleep(3000);
            WindowsElement CloseBox = drive.FindElementByAccessibilityId("2");
            CloseBox.Click();

            Assert.AreEqual("Vui lòng nhập đầy đủ thông tin", actual);
        }

        //thêm dữ liệu
        [Test]
        public void TestCase_GDCCN_TMB2()
        {
            Actions acc = new Actions(drive);
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement btnPlane = drive.FindElementByAccessibilityId("btn_addPlane");
            btnPlane.Click();

            drive.FindElementByAccessibilityId("txt_PlaneCode").SendKeys("Plane_20");

            drive.FindElementByAccessibilityId("txt_NamePlane").SendKeys("TikiLazada");

            drive.FindElementByAccessibilityId("cmb_totalSeats").Click();

            //chọn số ghế là 30
            WindowsElement seat30 = drive.FindElementByName("50");
            acc.MoveToElement(seat30).Click().Perform();

            drive.FindElementByAccessibilityId("btn_add").Click();

            WindowsElement thongBaox = drive.FindElementByAccessibilityId("65535");
            actual = thongBaox.Text;
            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Thêm thành công", actual);
        }

        //Sửa dữ liệu
        [Test]
        public void TestCase_GDCCN_TMB3()
        {
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement btnPlane = drive.FindElementByAccessibilityId("btn_addPlane");
            btnPlane.Click();

            drive.FindElementByAccessibilityId("dgv_dataPlane").Click();
            drive.FindElementByName("Row 9").Click();

            drive.FindElementByAccessibilityId("txt_NamePlane").SendKeys("TikiLazada5678");
            drive.FindElementByAccessibilityId("btn_update").Click();

            WindowsElement thongBaox = drive.FindElementByAccessibilityId("65535");
            actual = thongBaox.Text;

            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("2").Click();

            Assert.AreEqual("Sửa thành công", actual);
        }

        //Để trống dữ liệu ô tên máy bay và cập nhật
        [Test]
        public void TestCase_GDCCN_TMB4()
        {
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement btnPlane = drive.FindElementByAccessibilityId("btn_addPlane");
            btnPlane.Click();
            drive.FindElementByAccessibilityId("dgv_dataPlane").Click();
            //drive.FindElementByName("4219723089").Click();
            drive.FindElementByName("Row 8").Click();
            drive.FindElementByAccessibilityId("txt_NamePlane").SendKeys("MH-777");

            drive.FindElementByAccessibilityId("btn_update").Click();

            WindowsElement thongBaox = drive.FindElementByAccessibilityId("65535");
            actual = thongBaox.Text;

            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("2").Click();

            Assert.AreEqual("Sửa thành công", actual);
        }

        //Để trống dữ liệu ô mã máy bay và cập nhật
        [Test]
        public void TestCase_GDCCN_TMB5()
        {
            SendKey();

            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement btnPlane = drive.FindElementByAccessibilityId("btn_addPlane");
            btnPlane.Click();


            drive.FindElementByAccessibilityId("dgv_dataPlane").Click();
            //drive.FindElementByName("4219723089").Click();
            drive.FindElementByName("Row 8").Click();

            //điền thông tin vào ô mã máy bay
            //drive.FindElementByAccessibilityId("txt_PlaneCode").SendKeys("Plane_11");

            //xóa thông tin ô tên máy bay
            drive.FindElementByAccessibilityId("txt_PlaneCode").Clear();

            //ấn vào ô chọn số ghế
            //drive.FindElementByAccessibilityId("cmb_totalSeats").Click();

            //chọn số ghế là 30
            //drive.FindElementByName("30").Click();
            drive.FindElementByAccessibilityId("btn_update").Click();

            WindowsElement thongBaox = drive.FindElementByAccessibilityId("65535");
            actual = thongBaox.Text;

            Thread.Sleep(3000);
            drive.FindElementByAccessibilityId("2").Click();

            Assert.AreEqual("Vui lòng nhập mã máy bay", actual);
        }
    }
}
