using Louis_Philippe_Loeckx_Interfaces.Models;

namespace Louis_Philippe_Loeckx_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new string('-', 50);
            Transaction firstTransaction = new Transaction("0001", "30/12/2019", "50");
            Transaction SecondTransaction = new Transaction("0002", "30/12/2019", "376");

            firstTransaction.ShowTransaction();
            firstTransaction.GetAMount();

            System.Console.WriteLine(line);

            SecondTransaction.ShowTransaction();
            SecondTransaction.GetAMount();
        }
    }
}
