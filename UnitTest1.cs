using UserRegistration;

namespace UserValidatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Validate()
        {
            //Arrange
            string firstName = "Sagar";
            string lastName = "Shahu";
            string email = "shahu@gmail.com";
            string mobile = "6254892";
            string password = "pass123";
            string expectedOutput = "HAPPY";
            UserValidator e1 = new UserValidator();

            //Act
            string actualOutput = e1.validate(firstName, lastName, email, mobile, password);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }
            
    }
}