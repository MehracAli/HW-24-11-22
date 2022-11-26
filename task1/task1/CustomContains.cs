using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal static class CustomContains
    {
        public static bool CustomContain(this string sentence, string search)
        {
            char[] SentenceChars = sentence.ToCharArray();
            char[] SearchChars = search.ToCharArray();

            foreach (char SentenceCharacters in SentenceChars)
            {
                SentenceCharacters.ToString().ToLower();

                foreach(char SearchCharacters in SearchChars)
                {
                    SearchCharacters.ToString().ToLower();

                    if(SearchCharacters == SentenceCharacters)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
