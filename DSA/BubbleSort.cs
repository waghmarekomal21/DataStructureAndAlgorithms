using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class BubbleSort
    {
        public void Sort(string filepath)
        {
            int count = 0;
            string data = File.ReadAllText(filepath);
            string[] words = data.Split(",");
            int[] arr = new int[words.Length];
            for (int j = 0; j < words.Length; j++)
            {
                arr[j] = Convert.ToInt32(words[j]);
            }
            for (int i = 0; i <= words.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    count = count + 1;
                    if (arr[j] > (arr[j + 1]))
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorted Array : ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }

    }
}