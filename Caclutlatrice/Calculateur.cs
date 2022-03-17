using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclutlatrice
{
    public class Calculateur
    {
        private static string _separateur = ",";

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
            string[] tabChaines = numbers.Split(_separateur[0]);
            int total = 0;
            foreach(string chaine in tabChaines)
            {
                total += GererNombreSimple(chaine);
            }
            return total;
        }
        private static bool PossedeUnDelimiteur(string numbers)
        {
            return numbers.Contains(_separateur);
        }
        private static bool EstVide(string numbers)
        {
            return numbers.Length == 0;
        }
    }
}
