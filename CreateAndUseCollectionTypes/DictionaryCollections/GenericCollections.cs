using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class GenericCollections
    {
        public static void Collecitor()
        {
            Dictionary<int, string> countryLookUp = new Dictionary<int, string>();

            countryLookUp.Add(44, "United Kingdom");
            countryLookUp[33] = "France";
            countryLookUp[31] = "Netherlands";
            countryLookUp.Add(55, "Brazil");

            Console.WriteLine("The code 33 is for {0}", countryLookUp[33]);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> country in countryLookUp)
            {
                int code = country.Key;
                string name = country.Value;
                Console.WriteLine("The code {0} is for {1}", code, name);
            }
        }
    }
}
