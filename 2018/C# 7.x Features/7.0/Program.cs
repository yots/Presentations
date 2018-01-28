using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._0
{
    class Program
    {
        static void Main(string[] args)
        {

            var currentExample = Examples.OutVariable2;


            #region OutVariable1
            if (currentExample == Examples.OutVariable1)
            {

                int result;
                string answer = "42";

                if (int.TryParse(answer, out result))
                    Console.WriteLine($"The answer to the ultimate question of life, the universe and everything is {result}!");
                else
                    Console.WriteLine("Nope");

            }
            #endregion


            #region OutVariable2

            if (currentExample == Examples.OutVariable2)
            {
                string answer2 = "42";

                //Console.WriteLine(result2);

                if (int.TryParse(answer2, out var result2))
                    Console.WriteLine($"The answer to the ultimate question of life, the universe and everything is {result2}!");
                else
                    Console.WriteLine("Nope");


                Console.WriteLine($"Result: {result2}");
            }

            #endregion



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public enum Examples
    {
        OutVariable1,
        OutVariable2
    }

}
