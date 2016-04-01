namespace _02.CompanyInfo
{
    using System;

    public class CompanyInfo
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            faxNumber = faxNumber == string.Empty ? "(no fax)" : faxNumber;
            string webSite = Console.ReadLine();
            string managerFirstname = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", 
                name, address, phoneNumber, faxNumber, webSite, managerFirstname, managerLastName, managerAge, managerPhone);

            //// input                               output
            //// 
            //// Telerik Academy                     Telerik Academy
            //// 31 Al.Malinov, Sofia                Address: 231 Al.Malinov, Sofia
            //// + 359 888 55 55 555                 Tel. + 359 888 55 55 555
            ////                                     Fax: (no fax)
            //// http://telerikacademy.com/          Web site: http://telerikacademy.com/
            //// Nikolay                             Manager: Nikolay Kostov (age: 25, t
            //// Kostov
            //// 25
            //// + 359 2 981 981                                             
        }
    }
}

// A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints 
// it back on the console.