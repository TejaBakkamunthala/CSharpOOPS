using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountEncapsulation
{
    class BankAccount
    {
        private int accountBalance;
        public int depositAmount;
        public int withdrawAmount;
        public int accountBalancee

        {
          get { return accountBalance; }

            set
            {
                if (value > 0)
                {
                    accountBalance = value;
                    Console.WriteLine("Account Balance" +accountBalance );
                    Console.ReadKey();

                  
                }

                else
                {
                    Console.WriteLine("Account balance  should be in positive ");
                }

            }


        }


        public void deposit()
        {

            
            if (depositAmount > 0)
            {
                accountBalance = accountBalance + depositAmount;
                Console.WriteLine(" Amount Deposit "+depositAmount);
                Console.WriteLine("After Deposit");
                Console.WriteLine("Total Account Balance " + accountBalance);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Amount deposit should be in positive");
                Console.ReadKey();
            }
        }


        public void withDraw()
        {
            if(withdrawAmount>0 && accountBalance != 0)
            {
                accountBalance = accountBalance - withdrawAmount;
                Console.WriteLine("With Draw Amount " + withdrawAmount);
                Console.WriteLine("After With Draw");
                Console.WriteLine("Total Account Balance " + accountBalance);
                Console.ReadKey();
                 


            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {

            BankAccount ba = new BankAccount();
            ba.accountBalancee =100;
            
            //Console.WriteLine(ba.accountBalancee);
            Console.ReadKey();
            ba.depositAmount = 200;
            ba.deposit();
            //Console.WriteLine("Deposit Amount " + ba.depositAmount);

            ba.withdrawAmount = 100;
            ba.withDraw();
            Console.ReadKey();

           
        }
    }
}


