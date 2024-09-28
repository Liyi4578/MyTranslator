using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyTanslator.utils
{
    internal static class MyUtils
    {
        public static void CountEngAndChineseChacter(string text,
            out int engCount, out int chineseCount)
        {
            engCount = 0;
            chineseCount = 0;
            foreach (char c in text)
            {
                if (Regex.IsMatch(c.ToString(), "[\u4e00-\u9fa5]"))
                {
                    chineseCount++;
                }
                else if (Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
                {
                    engCount++;
                }
            }
        }

        public static int CountEngChacter(string text)
        {
            return Regex.Matches(text, "\\s+").Count + 1;
        }

        public static int CountChineseChacter(string text)
        {
            var num = 0;
            var regex = new Regex("^[\\u4E00-\\u9FA5]{0,}$");
            for (var i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i].ToString()))
                {
                    num++;
                }
            }
            return num;
        }
    }
}
