using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class LoanType
    {
        List<LoanType> loanTypes = new List<LoanType>();
        public string loanTypename { get; set; }
        public double unit { get; set; }
        public double InterestRate { get; set; }
        public double loanNumber { get; set; }

        public List<LoanType> GetData()
        {

            LoanType loanType1 = new LoanType
            {
                loanTypename = "Car",
                InterestRate = 10,
                unit = 6,
            };

            LoanType loanType2 = new LoanType
            {
                loanTypename = "Home",
                InterestRate = 11,
                unit = 6,
            };

            LoanType loanType3 = new LoanType
            {
                loanTypename = "personal",
                InterestRate = 5,
                unit = 2,
            };
            loanTypes.Add(loanType1);
            loanTypes.Add(loanType2);
            loanTypes.Add(loanType3);
            return (loanTypes);

        }

        public void show()
        {
            Console.WriteLine("We our provided Three type of loan");
            Console.WriteLine("1----Car Loan");
            Console.WriteLine("2-----Home loan");
            Console.WriteLine("3-----Personal Loan");
        }

        public void Loans(string s)
        {
            Console.Write("How much amount do you want : ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your ctc");
            double usectc = Convert.ToDouble(Console.ReadLine());

            double CI = 0;
            loanTypes = (loanTypes == null || loanTypes.Count <= 0) ? GetData() : loanTypes;
            LoanType ln = loanTypes.SingleOrDefault(m => m.loanTypename.Equals(s));
            double cunit = 0;
            cunit = ln.unit * usectc;
            if (cunit >= principle)
            {


                Console.Write("Enter the Number of Years : ");
                double time = Convert.ToDouble(Console.ReadLine());
                CI = principle * Math.Pow((1 + ln.InterestRate / 100), time);
                Console.WriteLine("Your total Amount is " + " " + CI);
            }

            else
            {
                Console.WriteLine("Your are not eliglible");
                Console.WriteLine("Your are only eliglible for this amount" + " " + unit);
            }


        }
       
    }


}
