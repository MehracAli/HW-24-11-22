using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._2
{
    internal static class Contain
    {
        public static bool CustomContain(this string sentence, string search)
        {

            #region SentenceComparison
            if (search.Equals(sentence) || search.Equals(sentence.ToLower()))
            {
                return true;
            }
            #endregion

            #region WordComparison
            string[] SentenceArr = sentence.Split();

            foreach (string word in SentenceArr)
            {
                if (search.Equals(word) || search.Equals(word.ToLower()))
                {
                    return true;
                }
                else if (word.EndsWith(search) || word.StartsWith(search))
                {
                    return true;
                }
            }

            #endregion

            return false;
        }
    }
}
