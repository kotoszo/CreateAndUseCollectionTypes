using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class ListCollection
    {
        public static void ListCollectio()
        {
            // With hashtable
            Console.WriteLine("-------------------HashTable------------------------");
            CultureInfo culInfo = CultureInfo.InvariantCulture;
            Hashtable list = new Hashtable(new CaseInsensitiveHashCodeProvider(culInfo), new CaseInsensitiveComparer(culInfo));
            list["Estados Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            // Show the results 
            Console.WriteLine(list["españa"]);
            Console.WriteLine(list["CANADÁ"]);
            Console.WriteLine("------------------Dictionary-----------------------");

            // with dictionary
            var comparer = StringComparer.OrdinalIgnoreCase;
            Dictionary<string, string> lel = new Dictionary<string, string>(comparer);
            lel["Estados Unidos"] = "United States of America";
            lel["Canadá"] = "Canada";
            lel["España"] = "Spain";

            // Show the results 
            Console.WriteLine(lel["españa"]);
            Console.WriteLine(lel["CANADÁ"]);
        }
    }
}
