using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSBOOK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Addressbook book = new Addressbook();
            book.CreateContact();
            while (true)
            {
                Console.WriteLine("1.Create Contact\n2.DisplayContact\n3.EditContact\n4.Delete Contact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book.CreateContact();
                        break;
                    case 2:
                        book.DisplayContact();
                        break;
                    case 3:
                        book.EditContact();
                        break;
                    case 4:
                        book.DeleteContact();
                        break;
                }

            }
        }
    }
}