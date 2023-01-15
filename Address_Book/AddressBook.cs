using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSBOOK
{
    public class Addressbook
    {
        List<Contact> data = new List<Contact>();
        public void CreateContact()
        {
            Contact Contact = new Contact();
            Console.WriteLine("Enter FirstName");
            Contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            Contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            Contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            Contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            Contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            Contact.Phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter MailId");
            Contact.Email = Console.ReadLine();
            data.Add(Contact);

        }
        public void DisplayContact()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************Contact***********");
            Console.ResetColor();
            foreach (Contact records in data)
            {
                Console.WriteLine("Firstname - " + records.Firstname);
                Console.WriteLine("Lastname - " + records.Lastname);
                Console.WriteLine("Address - " + records.Address);
                Console.WriteLine("City - " + records.City);
                Console.WriteLine("State - " + records.State);
                Console.WriteLine("Zip - " + records.Zip);
                Console.WriteLine("PhoneNumber - " + records.Phone);
                Console.WriteLine("Email ID - " + records.Email);
            }
        }
    }
}