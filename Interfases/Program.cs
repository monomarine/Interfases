namespace Interfases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("иванов иван");
            //Console.WriteLine(person);

            //person.AddMoney(10000);
            //Console.WriteLine(person);

            //person.DecMoney(5000);
            //Console.WriteLine(person);

            BankAccount ba1 = new BankAccount("5468796565987351");
            ba1.Lock();

            IPurse[] purses = {person, ba1};

            foreach (IPurse purse in purses) 
            {
                purse.AddMoney(1000);
                Console.WriteLine(purse);
                purse.DecMoney(500);
                Console.WriteLine(purse);
                Console.WriteLine();
            }

        }

    }
}
