using System;
namespace ATMAPPCONSOLE
{
    using System;
    using System.Collections.Generic;

    public class AtmOperationImpl : IAtmOperationInterf
    {
        ATM atm = new ATM();
        Dictionary<double, string> miniStatement = new Dictionary<double, string>();

        public void viewBalance()
        {
            Console.WriteLine("Available Balance is " + atm.getBalance());
        }

        public void withDrewAmount(double withdrawAmount)
        {
            if (withdrawAmount % 500 == 0)
            {
                if (withdrawAmount <= atm.getBalance())
                {
                    miniStatement.Add(withdrawAmount, "Amount withdrawn");
                    Console.WriteLine("Successfully withdrawn " + withdrawAmount);
                    atm.setBalance(atm.getBalance() - withdrawAmount);
                    viewBalance();
                }
                else
                {
                    Console.WriteLine("Insufficient balance !!");
                }
            }
            else
            {
                Console.WriteLine("Please enter the amount in multiple of 500 ");
            }
        }

        public void depositAmount(double depositAmount)
        {
            miniStatement.Add(depositAmount, "Amount Deposited");
            Console.WriteLine(depositAmount + " Deposited Successfully !!");
            atm.setBalance(atm.getBalance() + depositAmount);
            viewBalance();
        }

        public void viewMiniStatement()
        {
            foreach (KeyValuePair<double, string> m in miniStatement)
            {
                Console.WriteLine(m.Key + "" + m.Value);
            }
        }

        void IAtmOperationInterf.ViewBalance()
        {
            throw new NotImplementedException();
        }

        void IAtmOperationInterf.WithdrawAmount(double withdrawAmount)
        {
            throw new NotImplementedException();
        }

        void IAtmOperationInterf.DepositAmount(double depositAmount)
        {
            throw new NotImplementedException();
        }

        void IAtmOperationInterf.ViewMiniStatement()
        {
            throw new NotImplementedException();
        }
    }
}

