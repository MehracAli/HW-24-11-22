using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._2
{
    internal static class Split
    {
        public static string[] CustomSplit(this string sentence, char symbol = ' ')
        {
            string str = "";
            string[] arr = new string[0];

            for (int i=0; i<sentence.Length; i++)
            {
                if (sentence[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length+1);
                    arr[arr.Length - 1] = str;
                    str = string.Empty;
                }
                else
                {
                    str+= sentence[i];
                }
            }

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;

            return arr;
        }
            
    }
}
