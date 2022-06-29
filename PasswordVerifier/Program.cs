// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;


void Verify(string password)

{
    if (string.IsNullOrEmpty(password))
        throw new Exception("Password is Null or Empty");
    var hasNumber = new Regex(@"[0-9]");
    var hasLowerChar = new Regex(@"[a-z]");
    var hasUpperChar = new Regex(@"[A-Z]");
    var hasMinimum8Chars = new Regex(@".{8,}");

    //var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password) && hasLowerChar.IsMatch(password);
    
        if (!hasNumber.IsMatch(password))
            throw new Exception("Password Does Not Contain Number");
        if (!hasUpperChar.IsMatch(password))
            throw new Exception("Password Does Not Contain Upper Case Characters");
        if (!hasMinimum8Chars.IsMatch(password))
            throw new Exception("Password Does Not Contain Minimum of 8 Characters");
        if (!hasLowerChar.IsMatch(password))
            throw new Exception("Password Does Not Contain Lower Case Characters");
    //if (isValidated)
    Console.WriteLine("Password validated");    
}
try
{
    //Verify("qwe123");
    //Verify(null);
    //Verify("");
    //Verify("Qwe123");
    //Verify("jdfdfsdjffj1");
    //Verify("SDNFKSDFKSDKSD1");
    //  Verify("24456456165616443");
    Verify("Password123");
    
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}