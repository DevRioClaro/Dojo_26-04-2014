using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoDevRioClaro.Lib
{
    public class LibFizzBuzz
    {
        public static string VerifiqueFizzBuzz(int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0) 
                return "FizzBuzz";
            
            if (numero % 3 == 0)
                return "Fizz";
            
            if (numero % 5 == 0)
                return "Buzz";
            
            return numero.ToString();

        }
    }
}
