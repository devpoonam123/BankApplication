using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanType loanType = new LoanType();

            UserAccount.display();
            List<UserAccount> listuAc = new List<UserAccount>();
            UserAccount userAccount;
            int choice = 0;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        userAccount = new UserAccount();
                        Console.WriteLine("Please Enter your name");
                        userAccount.name = Console.ReadLine();
                        Console.WriteLine("Please Enter your Gender");
                        userAccount.gender = Console.ReadLine();
                        Console.WriteLine("Please Enter your Date of Birth");
                        userAccount.dateOfBirth = Console.ReadLine();
                        Random random = new Random();
                        int num = random.Next();
                        userAccount.account = num;
                        listuAc.Add(userAccount);
                        Console.Clear();
                        if (string.Compare("female", userAccount.gender, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            Console.WriteLine("Ms/Miss" + " " + userAccount.name + " " + "your account is created");
                        }
                        else if (string.Compare("male", userAccount.gender, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            Console.WriteLine("Mr" + " " + userAccount.name + "  " + "your account is created");
                        }
                        Console.WriteLine("Your account Number is :" + "  " + userAccount.account);
                        Console.WriteLine("Available balance is " + userAccount.avilableBalance);
                        Console.WriteLine(" name |  Gender  |   Dob  | Account number | ");
                        foreach (var us in listuAc)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine(String.Format("{0} | {1} | {2} | {3} |", us.name, us.gender, us.dateOfBirth, us.account));
                            Console.WriteLine("--------------------------------");

                        }
                        UserAccount.display();
                        break;

                    case 2:
                        Console.WriteLine("Please Enter Your Account Number");
                        double ac = Convert.ToDouble(Console.ReadLine());
                        UserAccount u = listuAc.SingleOrDefault(m => m.account == ac);
                        if (u != null)
                        {
                            Console.WriteLine("your current balance is" + " " + u.avilableBalance);
                        }
                        UserAccount.display();
                        break;

                    case 3:
                        Console.WriteLine("Please Enter Your Account Number");
                        double accno = Convert.ToDouble(Console.ReadLine());
                        UserAccount ua = listuAc.SingleOrDefault(m => m.account == accno);
                        if (ua != null)
                        {
                            Console.WriteLine("please enter amount which do you want deposite");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            double totalamount = (amount + ua.avilableBalance);
                            ua.avilableBalance = totalamount;
                           // totalamount = (totalamount + amount);
                            Console.WriteLine("Your total balance is :" + "  " + totalamount);
                            UserAccount.display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("please enter your account number");
                        double accNumber = Convert.ToDouble(Console.ReadLine());
                        UserAccount usera = listuAc.SingleOrDefault(m => m.account == accNumber);
                        if (usera != null)
                        {
                            Console.WriteLine("please enter amount which do you want Withdraw");
                            double withdamount = Convert.ToDouble(Console.ReadLine());
                            if (withdamount > usera.avilableBalance)
                            {
                                Console.WriteLine(" Sorry you have in sufficient balance your total balance is : " + " " + usera.avilableBalance);
                                Console.WriteLine("Do you want to continue please---- Press yes Else no ");
                                string c = Console.ReadLine();
                                switch (c)
                                {
                                    case "no":
                                        UserAccount.display();
                                            break;

                                    case "yes":
                                        Console.WriteLine("please enter your withdrawal amount");
                                        withdamount = Convert.ToDouble(Console.ReadLine());
                                        double ta = (usera.avilableBalance - withdamount);
                                        Console.WriteLine("Now Your total balance is :" + "  " + ta);

                                        break;
                                }
                            }
                            else
                            {
                                double ta = (usera.avilableBalance - withdamount);
                                Console.WriteLine("Now Your total balance is :" + "  " + ta);
                            }
                            UserAccount.display();
                        }
                        break;


                    case 5:
                        loanType.show();
                        int choose = 0;
                        do
                        {
                            choose = Convert.ToInt32(Console.ReadLine().Trim());
                            switch (choose)
                            {
                                case 1:
                                    Console.WriteLine("Welecome to Car Loan");
                                    
                                    loanType.Loans("Car");
                                    loanType.show();
                                    break;

                                case 2:
                                    Console.WriteLine("Welecome to Haome Loan");

                                    loanType.Loans("Home");
                                    loanType.show();
                                    break;

                                case 3:
                                    Console.WriteLine("Welecome to Personal Loan");
                                    loanType.Loans("personal");
                                    loanType.show();
                                    break;

                                default:
                                    Console.WriteLine("Sorry you Chooses wrong ");
                                    break;

                            }
                        } while (choose >= 3||choose<=3);
                        
                        
                       
                       
                        break;
                }
            } while (choice < 5);

            Console.ReadLine();


        }
    }
}
