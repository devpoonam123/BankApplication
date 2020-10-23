using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
   public class UserAccount
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string dateOfBirth { get; set; }
        public double account { get; set; }
        public double avilableBalance { get; set; }

        public static  void  display()
        {

            Console.WriteLine("-------------Welecome to my BANK--------------------");
            Console.WriteLine("which service do you want ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1---open Account");
            Console.WriteLine("2---check your balance");
            Console.WriteLine("3---Deposit Amount");
            Console.WriteLine("4---Withdrawal Amount");
        }

    }
}
