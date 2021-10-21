using System;
using System.Collections.Generic;

namespace ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
        }

        static string Convert(string s, int numRows)
        {
            int a = numRows + numRows - 1;
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1,s[0].ToString());
            int row = 2;
            string result = "";
            for (int i = 1; i < s.Length; i++)
            {
                list[row] = list.GetValueOrDefault(row, "") + s[i];
                if (row > (a / 2) + 1)
                    row--;
                else row++;
                if (row == a - 1)
                {
                    row = 2;
                    a += a;
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
