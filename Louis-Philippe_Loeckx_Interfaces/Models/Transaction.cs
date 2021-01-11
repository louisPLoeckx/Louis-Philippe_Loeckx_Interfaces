using System;

namespace Louis_Philippe_Loeckx_Interfaces.Models
{
    public class Transaction : Bank, Itransaction
    {
        //private int count;
        private readonly string _code;
        private readonly string _date;
        private readonly string _amount;
        private double _commision;

        public double GetAMount()
        {
            double amount = double.Parse(_amount);

            if (amount > 100)
            {
                _commision = (amount * 0.5)/100;
                amount = amount + _commision;
                Console.WriteLine($"You will be charged with an extra commision: {_commision}");
                return amount;
            }
            else
            {
                Console.WriteLine("Your account will NOT be charged");
                return amount;
            }
        }

        public string ShowBankName()
        {
            return BankName;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"{ShowBankName()} \nAdress: {Adress}");
            Console.WriteLine($"Transaction: {_code}");
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Amount: {_amount}");
        }

        public Transaction(string code, string date, string amount)
        {
            _code = code;
            _date = date;
            _amount = amount;
        }
    }
}
