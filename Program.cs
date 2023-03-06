using System;
using System.Text.RegularExpressions;
using UserRegistration;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            EmailValidator e1 = new EmailValidator();
            e1.validate("sagar", "shahu", "shahu@gmail.com", "555666", "pass123");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
