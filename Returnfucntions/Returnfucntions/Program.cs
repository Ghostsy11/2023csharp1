using System.Data;

namespace Returnfucntions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.geTallen());
            int whole = program.geTallen();
            Console.WriteLine(whole);
        }


        private int geTallen()
        {
            int num1 = 20;
            int num2 = 40;

            int sum = num1 + num2;
            return sum;

        }

    }
}