using PasswordVerifier;

try
{
    //Verify("qwe123");
    //Verify(null);
    //Verify("");
    //Verify("Qwe123");
    //Verify("jdfdfsdjffj1");
    //Verify("SDNFKSDFKSDKSD1");
    //  Verify("24456456165616443");
    Verify.VerifyPassword("Password123");
    
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}