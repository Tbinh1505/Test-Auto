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
    public class TC_TTTK
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
        
        void send()
        {
            taiKhoan.SendKeys("cus1@gmail.com");
            matKhau.SendKeys("1");
            dangNhap.Click();
        }

        //Thông tin tài khoản
        [Test]
        public void TestCase_TTTK1()
        {

            //thao tác
            send();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement nguoiDung = drive.FindElementByName("Người dùng");
            nguoiDung.Click();

            WindowsElement tttk = drive.FindElementByName("Thông tin tài khoản");
            tttk.Click();

            Thread.Sleep(1000);

            drive.FindElementByAccessibilityId("btn_sua").Click();

            drive.FindElementByAccessibilityId("tbx_hoTen").SendKeys("Nguyễn đức việt34");
            drive.FindElementByAccessibilityId("cbx_gt").Click();
            Thread.Sleep(1000);
            WindowsElement N= drive.FindElementByName("Nữ");
            acc.MoveToElement(N).Click().Perform();
            drive.FindElementByAccessibilityId("tbx_sdt").SendKeys("0923456789");
            drive.FindElementByAccessibilityId("tbx_diaChi").SendKeys("Yên Bái");

            drive.FindElementByAccessibilityId("btn_update").Click();

            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            Thread.Sleep(2000);
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Thông tin bạn nhập chưa đúng yêu cầu", actual);
        }

        //Thông tin tài khoản
        [Test]
        public void TestCase_TTTK2()
        {
            //thao tác
            send();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());

            WindowsElement nguoiDung = drive.FindElementByName("Người dùng");
            nguoiDung.Click();

            WindowsElement tttk = drive.FindElementByName("Thông tin tài khoản");
            tttk.Click();
            //drive.SwitchTo().Window(drive.WindowHandles.Last());
            Thread.Sleep(1000);
            drive.FindElementByAccessibilityId("btn_sua").Click();
            drive.FindElementByAccessibilityId("tbx_hoTen").SendKeys("Nguyễn đức việt");
            drive.FindElementByAccessibilityId("cbx_gt").Click();
            WindowsElement N = drive.FindElementByName("Nam");
            acc.MoveToElement(N).Click().Perform();
            drive.FindElementByAccessibilityId("tbx_sdt").SendKeys("092345678921");
            drive.FindElementByAccessibilityId("tbx_diaChi").SendKeys("Yên Bái");
            drive.FindElementByAccessibilityId("btn_update").Click();
            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            drive.FindElementByAccessibilityId("2").Click();
            Assert.AreEqual("Vui lòng nhập đúng số điện thoại", actual);
            drive.Close();
        }

        //Thông tin tài khoản
        [Test]
        public void TestCase_TTTK3()
        {
            //thao tác
            send();
            thongBao.Click();
            //chờ
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(1000));
            drive.SwitchTo().Window(drive.WindowHandles.Last());
            WindowsElement nguoiDung = drive.FindElementByName("Người dùng");
            nguoiDung.Click();
            WindowsElement tttk = drive.FindElementByName("Thông tin tài khoản");
            tttk.Click();
            Thread.Sleep(1000);
            drive.FindElementByAccessibilityId("btn_sua").Click();
            drive.FindElementByAccessibilityId("tbx_hoTen").SendKeys("Nguyễn đức việt");
            drive.FindElementByAccessibilityId("cbx_gt").Click();
            WindowsElement N = drive.FindElementByName("Nữ");
            acc.MoveToElement(N).Click().Perform();
            drive.FindElementByAccessibilityId("tbx_sdt").SendKeys("0923456789");
            drive.FindElementByAccessibilityId("tbx_diaChi").SendKeys("Yên Bái");
            drive.FindElementByAccessibilityId("btn_update").Click();
            WindowsElement er = drive.FindElementByAccessibilityId("65535");
            actual = er.Text;
            drive.FindElementByAccessibilityId("2").Click();
            drive.SwitchTo().Window(drive.WindowHandles.First());
            Assert.AreEqual("Cập nhật thành công!", actual);
        }
    }
}
