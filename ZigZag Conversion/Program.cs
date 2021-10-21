using System;
using System.Collections.Generic;

namespace ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
            Console.WriteLine(Convert("PAYPALISHIRING", 4));
            Console.WriteLine(Convert("A", 1));
        }

        static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            int a = numRows + numRows - 1;
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, s[0].ToString());
            int row = 1;
            string result = "";
            for (int i = 1, j = 1; i < s.Length; i++, j++)
            {
                if (j > a / 2)
                    row--;
                else row++;
                list[row] = list.GetValueOrDefault(row, "") + s[i];

                if (j == a - 1)
                {
                    row = 1;
                    j = 0;
                }

            }
            for (int i = 1; i <= numRows; i++)
            {
                result += list.GetValueOrDefault(i, "");
            }
            return result;
        }
    }
}
