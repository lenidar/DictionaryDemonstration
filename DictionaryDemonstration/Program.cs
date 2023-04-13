using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> grades = new Dictionary<string, double>();
            // Key - subject
            // Value - grade for the subject

            // ways to add to the dictionary
            grades.Add("PE", 99);
            grades["Rizal"] = 95;
            grades["Writing"] = -4;
            // Note: If the key already exists in the dictionary, the old value is overwritten

            if(grades.ContainsKey("Programming 2"))
            {
                Console.WriteLine(grades["Programming 2"]);
            }
            else
            {
                Console.WriteLine("No Grade in Programming 2");
            }
            Console.WriteLine(grades["PE"]);
            Console.WriteLine();

            grades["PE"] = -1;

            foreach(KeyValuePair<string, double> kvp in grades)
            {
                Console.Write(kvp.Key + " - ");
                if(kvp.Value == -1)
                    Console.WriteLine("INC");
                else if (kvp.Value == -4)
                    Console.WriteLine("FDA");
                else
                    Console.WriteLine(kvp.Value);
            }

            //foreach(string keys in grades.Keys)
            //{
            //    Console.Write(keys + " - ");
            //    if (grades[keys] == -4)
            //        Console.WriteLine("FDA");
            //    else
            //        Console.WriteLine(grades[keys]);
            //}

            Console.ReadKey();
        }
    }
}
