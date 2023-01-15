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

            bool addcontact = true;
            while(addcontact)
            {
                book.CreateContact();
                Console.WriteLine("Do you want to add more contact? (Y/N): ");
                string ans = Console.ReadLine();
                if(ans == "N" || ans== "Y") 
                {
                    addcontact= false;
                }

            }
            book.DisplayContact();
        }
    }
}