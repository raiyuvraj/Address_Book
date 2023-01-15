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
        }
    }
}