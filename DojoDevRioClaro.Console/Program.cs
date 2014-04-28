using DojoDevRioClaro.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoDevRioClaro.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var resultado = LibFizzBuzz.VerifiqueFizzBuzz(i);
                System.Console.WriteLine("Resultado: "+resultado);
            }
            System.Console.ReadKey();
        }
    }
}