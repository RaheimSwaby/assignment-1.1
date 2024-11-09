using System.Runtime.CompilerServices;

namespace practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            do
            {
                Console.WriteLine("enter first number");
                num1 = Convert.ToDouble(Console.ReadLine());

                if (num1 == 0)
                {
                    Console.WriteLine("number must be greater than 0 try again");
                }
            }
            while (num1 == 0);
            Console.WriteLine("Enter your second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("these number are equal");
            }
            if (num1 != num2)
            {
                Console.WriteLine("these numbers are not equal");
            }
           

                    
                
            
             
                
            
        }
    }
}
