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
    public class TC_DangNhap
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
        public static AppiumOptions options;
        string actual;
        WindowsDriver<WindowsElement> drive;

        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");//gọi winappdrive
            options = new AppiumOptions();
            options.AddAdditionalCapability("app", @"C:\Users\ASUS\source\repos\DuAn1\bin\Debug\net6.0-windows\GUI.exe");//đường dẫn đến app cần test

            drive = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);

            System.Threading.Thread.Sleep(1000);
        }

        [TearDown]
        public void ExistTest()
        {
            drive.Quit();
        }

        //Chức năng đăng nhập
        //tài khoản mật khẩu trống
        //Hiện ra thông báo vui lòng không để trống email và mật khẩu
        [Test]
        public void TestCase_DN1()
        {
            taiKhoan.SendKeys("");
            matKhau.SendKeys("");
            dangNhap.Click();
            //act
            var expected = "Vui lòng không để trống email hoặc mật khẩu";

            WindowsElement thongpao = drive.FindElementByAccessibilityId("65535");
            
            actual = thongpao.Text;
            Thread.Sleep(1000);
            thongBao.Click();
            //assert
            Assert.AreEqual(expected, actual);
            drive.CloseApp();
        }

        //Đăng nhập thất bại!
        //Hiển thị thông báo email không đúng định dạng
        [Test]
        public void TestCase_DN2()
        {

            taiKhoan.SendKeys("admin");
            matKhau.SendKeys("");
            dangNhap.Click();

            //act
            var expected = "Email không đúng định dạng";

            WindowsElement thongPao = drive.FindElementByAccessibilityId("65535");

            actual = thongPao.Text;

            Thread.Sleep(1000);
            thongBao.Click();
            Assert.AreEqual(expected, actual);
            drive.CloseApp();
        }

        //Đăng nhập thành công!
        [Test]
        public void TestCase_DN3()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
            var expected = "Đăng nhập thành công"; // mong muốn
            WindowsElement thongpao = drive.FindElementByAccessibilityId("65535");
            //chuyển sang form giao diện các chức năng khi đăng nhập thành công
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(3000);
            Assert.AreEqual(expected, thongpao.Text);
            thongBao.Click();
        }

        //Đăng nhập thất bại!
        //Không được để trống email và mật khẩu phải có độ dài là 6
        [Test]
        public void TestCase_DN4()
        {
            //hành động
            taiKhoan.SendKeys("");
            matKhau.SendKeys("1");
            dangNhap.Click();

            //thông báo hiển thị mong muốn
            var expected = "Tài khoản không được để trống và mật khẩu phải có 6 kí tự";

            //lấy thông tin id thông báo
            WindowsElement thongpao = drive.FindElementByAccessibilityId("65535");
            string tho = thongpao.Text;
            Thread.Sleep(2000);
            thongBao.Click();
            //nếu thông báo giống nhau thì pass ngược lại thì fald
            Assert.AreEqual(expected, tho);
            drive.Quit();
        }

        ////Đăng nhập thất bại!
        //Mật khẩu không được quá 6 kí tự
        [Test]
        public void TestCase_DN5()
        {
            taiKhoan.SendKeys("halv@gmail.com");
            matKhau.SendKeys("1234567899");
            dangNhap.Click();

            WindowsElement thatBai = drive.FindElementByAccessibilityId("65535");

            string expteced = "Mật khẩu không được quá 6 kí tự";
            string actual = thatBai.Text;

            // thời gian chờ
            Thread.Sleep(2000);

            //tắt thông báo
            thongBao.Click();

            //asert nếu giống nhau thì pass ngược lại là fail
            Assert.AreEqual(expteced, actual);
            // Đóng ứng dụng
            drive.Quit();
        }
    }
}
