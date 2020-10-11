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
    }
}
