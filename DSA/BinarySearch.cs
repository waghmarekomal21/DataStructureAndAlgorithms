using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class BinarySearch
    {
        public void Search(string filepath)
        {
            string data = File.ReadAllText(filepath);
            string[] words = data.Split(",");
            Console.WriteLine("Enter Words to Search");
            string search = Console.ReadLine();
            foreach (var item in words)
            {
                if (search.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("Words Found");
                    return;
                }
            }
            Console.WriteLine("Words not Found");
        }
    }
}