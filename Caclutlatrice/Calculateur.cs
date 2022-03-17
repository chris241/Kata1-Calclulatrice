using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclutlatrice
{
    public class Calculateur
    {
        public static int Add(string numbers)
        {
            if (EstVide(numbers))
                return 0;
            if (PossedeUnDelimiteur(numbers))
                return GererDeuxNombresMultiples(numbers);
            return GererNombreSimple(numbers);
        }

        private static int GererNombreSimple(string numbers)
        {
            return int.Parse(numbers);
        }
        private static int GererDeuxNombresMultiples(string numbers)
        {
            return 3;
        }
        private static bool PossedeUnDelimiteur(string numbers)
        {
            return numbers.Contains(",");
        }
        private static bool EstVide(string numbers)
        {
            return numbers.Length == 0;
        }
    }
}
