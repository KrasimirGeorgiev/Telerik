namespace _11.BankAccountData
{
    using System;

    public class BankAccountData
    {
        public static void Main()
        {
            string firstName = "Gosho";
            string middleName = "Petrov";
            string lastName = "Georgiev";
            decimal balance = 342.33333M;
            string bankName = "DSK";
            string iban = "asdkjh7asdf9gag";
            string firstCreditCardNumber = "34566654123";
            string secondCreditCardNumber = "09875687478";
            string thirdCreditCardNumber = "7654987652";

            Console.WriteLine("Name: {0} {1} {2}\nBalance: {3:F2}\nBank name: {4}\nIBAN: {5}\nFirst credit card number: {6}\nSecond credit card number: {7}\nThird credit card number: {8}", firstName, middleName, lastName, balance, bankName, iban, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        }
    }
}

// A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name,
// IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account 
// using the appropriate data types and descriptive names.