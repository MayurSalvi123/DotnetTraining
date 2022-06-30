using System.Text.RegularExpressions;

namespace PasswordVerifier
{
    public class Verify
    {
        private static readonly Regex hasNumber = new(@"[0-9]");
        private static readonly Regex hasLowerChar = new(@"[a-z]");
        private static readonly Regex hasUpperChar = new(@"[A-Z]");
        private static readonly Regex hasMinimumChars = new(@".{9,}");
        public static void VerifyPassword(string? password)
        {
            if (string.IsNullOrEmpty(password))
                throw new Exception("Password is Null or Empty");
            if (!hasMinimumChars.IsMatch(password))
                throw new Exception("Password Does Not Contain Minimum of 9 Characters");           
            if (!hasNumber.IsMatch(password))
                throw new Exception("Password Does Not Contain Number");
            if (!hasUpperChar.IsMatch(password))
                throw new Exception("Password Does Not Contain Upper Case Characters");
            if (!hasLowerChar.IsMatch(password))
                throw new Exception("Password Does Not Contain Lower Case Characters");
            Console.Write("Password validated");
        }
    }
}
