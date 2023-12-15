using _2_BUS.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Test_Validate
{
        [TestFixture]
        public class ValidateTests
        {

            [Test]
            public void Check_Test()
            {
                Validate validate = new Validate();
            }

            [Test]
            public void CheckEmail_ShouldReturnTrue_WhenValidEmail()
            {
                // Arrange
                var validator = new Validate();
                var validEmail = "loitruong3123@gmail.com";

                // Act
                var result = validator.checkEmail(validEmail);

                // Assert
                Assert.IsTrue(result);
            }
            [Test]
            public void CheckPhoneNumber()
            {
                var validator = new Validate();
                var validNumber = "0828698564";
                var resurlt = validator.checkPhoneNumber(validNumber);
                Assert.IsTrue(resurlt);
            }
            [Test]
            public void CheckPhoneNumber_False()
            {
                var validator = new Validate();
                var invalidNumber = "addmdom42121";
                var resurlt = validator.checkPhoneNumber(invalidNumber);
                Assert.IsFalse(resurlt);
            }
            [Test]
            public void checkName_True()
            {
                var validate = new Validate();
                var valiName = "name";
                var resurlt = validate.checkName(valiName);
                Assert.IsTrue(resurlt);
            }
            [Test]
            public void checkName_False()
            {
                var validate = new Validate();
                var invalidName = "ảấờễàạằệ";
                var resurlt = validate.checkName(invalidName);
                Assert.IsFalse(resurlt);
            }

            // Tương tự, thêm các bài kiểm thử cho các phương thức khác trong Validate class

            [Test]
            public void RandomCode_ShouldReturnCodeWithSixDigits()
            {
                // Arrange
                var validator = new Validate();

                // Act
                var result = validator.randomCode();

                // Assert
                Assert.AreEqual(6, result.Length);
                Assert.IsTrue(int.TryParse(result, out _)); // Kiểm tra xem chuỗi có thể chuyển đổi thành số nguyên không
            }

            [Test]
            public void ReversePass_ShouldReverseAndEncryptPassword()
            {
                // Arrange
                var validator = new Validate();
                var originalPassword = "9236679<9;:AC?@BBAEELHIJIKRSMSRSYU[U[]XZa90121134120661132021732301771644839267138";

                // Act
                var reversedPassword = validator.ReversePass(originalPassword);

                // Assert
                Assert.AreNotEqual(originalPassword, reversedPassword);
                // Kiểm tra xem chuỗi có thể chuyển đổi thành số nguyên không (có thể thêm kiểm tra khác tùy vào yêu cầu)
               
                Assert.IsTrue(int.TryParse(reversedPassword, out _));
            }

            // Thêm các bài kiểm thử khác tùy thuộc vào yêu cầu của bạn
        }
}

