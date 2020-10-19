using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName_with_valid_input()
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidateFirstName("Srujana");
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateFirstName_with_invalid_input()
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidateFirstName("srujana");
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        [TestMethod]
        public void ValidateLastName_with_valid_input()
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidateLastName("Valavala");
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateLastName_with_invalid_input()
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidateLastName("V");
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }

        [TestMethod]
        public void ValidateEmail_with_valid_input()
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidateEmail("srujana.vv1@gmail.com.in");
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateEmail_with_invalid_input()
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidateEmail("abc-100@gmail.com.in.au");
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }


        }

        [TestMethod]
        public void ValidateMobNo_with_valid_input()
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidateMobNo("91 1234567890");
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateMobNo_with_invalid_input()
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidateMobNo("221078");
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }

        [TestMethod]
        public void ValidatePassword_with_valid_input()
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidatePassword("Abcd@123");
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidatePassword_with_invalid_input()
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidatePassword("abcd1234");
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void Validate_Multiple_Email_Enteries_for_valid_input(string email)
        {
            //Arrange
            UserDetailsValidator validator = new UserDetailsValidator();
            bool expected = true;
            //Act
            bool result = validator.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Validate_Multiple_Email_Enteries_for_invalid_input(string email)
        {
            try
            {
                UserDetailsValidator validator = new UserDetailsValidator();
                bool result = validator.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }
    }
}
