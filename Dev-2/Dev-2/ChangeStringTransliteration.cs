using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev_2
{
    class ChangeStringTransliteration
    {
        /// <summary>
        /// convert string to lowercase
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return converted string <param> to lowercase</returns>
        private bool StringToLowerCase (ref String str)
        {
            String temporaryString = str;
            try
            {
                str = str.ToLower();
            } catch
            {
                throw new Exception("Can't convert <String> to lower case");
            }
            return true;
        }
        /// <summary>
        /// check if string contain cyrillic letters
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// return true if string contain only cyrillic letters
        /// return false if string conatain any other letters
        /// </returns>
        private bool IsCyrillic (String str)
        {
            foreach (char i in str)
            {
                if (char.IsLetter(i) && (!Enumerable.Range(1072, 1103).Contains(i)))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// check if string contain latin letters
        /// </summary>
        /// <param name="str"></param>
        /// <returns>
        /// return true if string contain only Latin letters
        /// return false if string conatain any other letters
        /// </returns>
        private bool IsLatin (String str)
        {
            foreach (char i in str)
            {
                if (char.IsLetter(i) && (!Enumerable.Range(97, 122).Contains(i)))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Autodect which alphabet string contain 
        /// change transliteraton of string <param>
        /// </summary>
        /// <param name="str"></param>
        /// <returns>return transliterated string</returns>
        public String ChangeTransliteration(String str)
        {
            String temporaryString = String.Empty;
            temporaryString = str;
            try
            {
                StringToLowerCase(ref temporaryString);

                if (IsCyrillic(temporaryString))
                {
                    CyrillicToTransliteration(ref temporaryString);
                }
                else if (IsLatin(temporaryString))
                {
                    LatinToTransliteration(ref temporaryString);
                }
                else
                {
                    Console.WriteLine("The initial sting conains russian and english symbols");
                }
                return temporaryString;
            }
            catch 
            {
                throw new Exception("Can't translit this tring");
            }
        }
        /// <summary>
        /// replace each element in string ,using the dictionary
        /// </summary>
        /// <param name="str">reference on string</param>
        private  void CyrillicToTransliteration (ref String str)
        {
            StringBuilder temporaryString = new StringBuilder();
            temporaryString.Append(str);

            Dictionary<String, String> CyrillicTransliterations = new Dictionary<String, String>
            {
                ["а"] = "a",
                ["б"] = "b",
                ["в"] = "v",
                ["г"] = "g",
                ["д"] = "d",
                ["е"] = "e",
                ["ё"] = "yo",
                ["ж"] = "zh",
                ["з"] = "z",
                ["и"] = "i",
                ["й"] = "y",
                ["к"] = "k",
                ["л"] = "l",
                ["м"] = "m",
                ["н"] = "n",
                ["о"] = "o",
                ["п"] = "p",
                ["р"] = "r",
                ["с"] = "s",
                ["т"] = "t",
                ["у"] = "u",
                ["ф"] = "f",
                ["х"] = "kh",
                ["ц"] = "ts",
                ["ч"] = "ch",
                ["ш"] = "sh",
                ["щ"] = "sch",
                ["ъ"] = String.Empty,
                ["ы"] = "y",
                ["ь"] = String.Empty,
                ["э"] = "e",
                ["ю"] = "yu",
                ["я"] = "ya"
            };

            foreach (string i in CyrillicTransliterations.Keys)
            {
                temporaryString.Replace(i, CyrillicTransliterations[i]);
            }
            str = temporaryString.ToString();

        }
        /// <summary>
        /// replace each element in string ,using the dictionary
        /// </summary>
        /// <param name="str">reference on string</param>
        private void LatinToTransliteration (ref String str)
        {
            StringBuilder temporaryString = new StringBuilder();
            temporaryString.Append(str);

            Dictionary<String, String> LatinTransliterations = new Dictionary<String, String>
            {
                ["sch"] = "щ",
                ["sh"] = "ш",
                ["ts"] = "ц",
                ["yu"] = "ю",
                ["ya"] = "я",
                ["kh"] = "х",
                ["ch"] = "ч",
                ["a"] = "а",
                ["b"] = "б",
                ["c"] = String.Empty,
                ["d"] = "д",
                ["e"] = "е",
                ["f"] = "ф",
                ["g"] = "г",
                ["h"] = "х",
                ["i"] = "и",
                ["j"] = String.Empty,
                ["k"] = "к",
                ["l"] = "л",
                ["m"] = "м",
                ["n"] = "н",
                ["o"] = "о",
                ["p"] = "п",
                ["q"] = String.Empty,
                ["r"] = "р",
                ["s"] = "с",
                ["t"] = "т",
                ["u"] = "у",
                ["v"] = "в",
                ["w"] = String.Empty,
                ["x"] = String.Empty,
                ["y"] = "ы",
                ["z"] = "з"
            };

            foreach (string i in LatinTransliterations.Keys)
            {
                temporaryString.Replace(i, LatinTransliterations[i]);
            }
            str = temporaryString.ToString();
        }
    }
}
