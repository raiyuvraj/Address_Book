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
        public int NumberOfContact { get; set; }
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
            Console.WriteLine("Enter PhoneN umber");
            Contact.Phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter MailId");
            Contact.Email = Console.ReadLine();
            data.Add(Contact);
            NumberOfContact++;
            DisplayContact(); 

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
        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("Enter Firstname to edit: ");
            string Firstname =  Console.ReadLine();

           foreach(var record in data)
            {
                if(record.Firstname == Firstname)
                {
                    Console.WriteLine(Firstname+ "is exist");

                    Console.WriteLine("To edit details enter " + "\n1.LastName\n2.Address\n3.City\n4.State\n5.Zip\n6.PhoneNumber\n7.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Enter lastname: ");
                            string newlastname = Console.ReadLine();
                            record.Lastname = newlastname;
                            break;
                        case 2:
                            Console.WriteLine("Enter New Address:");
                            string newaddress = Console.ReadLine();
                            record.Address = newaddress;
                            break;
                            case 3:
                            Console.WriteLine("Enter New City: ");
                            string newcity = Console.ReadLine();
                            record.City = newcity;
                            break;
                            case 4:
                            Console.WriteLine("Enter New State:");
                            string newstate = Console.ReadLine();
                            record.State = newstate;
                            break;
                            case 5:
                            Console.WriteLine("Enter New Zip Code: ");
                            int newzip = Convert.ToInt32(Console.ReadLine());
                            record.Zip = newzip;
                            break;
                            case 6:
                            Console.WriteLine("Enter New Phone Number:");
                            long newno = Convert.ToInt64(Console.ReadLine());
                            record.Phone = newno;
                            break;
                            case 7:
                            Console.WriteLine("Enter New Email: ");
                            string newemail = Console.ReadLine();
                            record.Email = newemail;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Name Does Not Exist.");
                }
            }
        }
        public void DeleteContact()
        {
            int i = 0;
            Console.WriteLine("Enter Firstname to edit: ");
            string Firstname = Console.ReadLine();

            foreach(var record in data)
            {
                if(record.Firstname == Firstname)
                {
                    data.Remove(record);
                    Console.WriteLine("Contact Deleted Successfully.");
                    break;
                }
                else
                {
                    Console.WriteLine("Name Does not exist.");
                }
            }
        }

    }
}