using PasswordVerifier;
using Xunit;

namespace PasswordVerifierTest
{
    public class PasswordVerifier_VerifyPasswordShould
    {
        [Fact]
        public void VerifyPassword_InputIsqwe123_ThrowsExceptionNoMinimum9Characters()
        {
            //act
            static void act() => Verify.VerifyPassword("qwe12345");
            Exception exception = Assert.Throws<Exception>(act);
            //assert
            Assert.Equal("Password Does Not Contain Minimum of 9 Characters", exception.Message);
        }
        [Fact]
        public void VerifyPassword_InputIsnull_ThrowsExceptionIsNullOrEmpty()
        {
            //act
            static void act() => Verify.VerifyPassword(null);
            Exception exception = Assert.Throws<Exception>(act);
            //assert
            Assert.Equal("Password is Null or Empty",exception.Message);
        }
        [Fact]
        public void VerifyPassword_InputIspassword123_ThrowsExceptionShouldContainOneUpperCaseCharacter()
        {
            //act
            static void act() => Verify.VerifyPassword("password123");
            Exception exception = Assert.Throws<Exception>(act);
            //assert
            Assert.Equal("Password Does Not Contain Upper Case Characters", exception.Message);

        }
        [Fact]
        public void VerifyPassword_InputIsPASSWORD123_ThrowsExceptionShouldContainOneLowerCaseCharacter()
        {
            //act
            static void act() => Verify.VerifyPassword("PASSWORD123");
            Exception exception = Assert.Throws<Exception>(act);
            //assert
            Assert.Equal("Password Does Not Contain Lower Case Characters", exception.Message);
        }
        [Fact]
        public void VerifyPassword_InputIsPassWordd_ThrowsExceptionShouldContainOneNumber()
        {
            //act
            static void act() => Verify.VerifyPassword("PassWordd");
            Exception exception = Assert.Throws<Exception>(act);
            //assert
            Assert.Equal("Password Does Not Contain Number", exception.Message);
        }
        [Fact]
        public void VerifyPassword_InputIsPassword123_ShouldConsoleWriteValidatedMessage()
        {
            //arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            //act
            Verify.VerifyPassword("Password123");
            //assert
            Assert.Equal("Password validated",stringWriter.ToString());
        }
    }
}