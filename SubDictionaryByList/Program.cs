/* Extracting Sub-Dictionaries by Using Specific List of Keys or List of Values */

using System;
using System.Linq;
using System.Collections.Generic;

namespace SubDictionaryByList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Data = new Dictionary<string, int>();

            Data.Add("Cat", 6);
            Data.Add("Bee", 8);
            Data.Add("Dog", 5);
            Data.Add("Ant", 7);

            // This is a Dictionary Example with 4 Elements and There is No Specific Order (Asc/Desc)


            Console.WriteLine("Full Key-Value Pairs of the Dictionary:\n");
            foreach (var item in Data)
            {
                Console.WriteLine(item.Key + " : " + item.Value);    // Printing Each Key-Value Pair
            }
            Console.WriteLine();


            List<string> byKey = new List<string>();       // List of Keys to Use for Extracting Key-Value Pairs from the Dictionary
            byKey.Add("Cat");
            byKey.Add("Ant");

            Dictionary<string, int> dataKey = new Dictionary<string, int>();    // Sub-Dictionary to Be Extracted by Key Comparisons

            // Extract Key-Value Pairs from the Dictionary Where the Keys are the Same with the Ones in the byKey List:
            dataKey = Data.Where(x => byKey.Contains(x.Key)).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("\nKey-Based Extraction & OrderBy Keys:\n");
            foreach (var item in dataKey)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine();


            List<int> byValue = new List<int>();          // List of Values to Use for Extracting Key-Value Pairs from the Dictionary
            byValue.Add(8);
            byValue.Add(5);

            Dictionary<string, int> dataValue = new Dictionary<string, int>(); // Sub-Dictionary to Be Extracted by Value Comparisons

            // Extract Key-Value Pairs from the Dictionary Where the Values are the Same with the Ones in the byValue List:
            dataValue = Data.Where(x => byValue.Contains(x.Value)).OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("\nValue-Based Extraction & OrderBy Values:\n");
            foreach (var item in dataValue)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine();


            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey();
            return;
        }
    }
}