namespace _10.EmployeeData
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Georgiev";
            byte age = 21;
            char gender = 'm';
            string personalID = "830611250742";
            int employeeNumber = 27569999;

            Console.WriteLine("Name: {0} {1}\nAge: {2}\nGender: {3}\nPesonal ID: {4}\nEmployee number: {5}", firstName, lastName, age, gender, personalID, employeeNumber);
        }                     
    }
}

// A marketing company wants to keep record of its employees.Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender(m or f)
// Personal ID number(e.g. 8306112507)
// Unique employee number(27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.