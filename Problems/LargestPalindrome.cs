using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class LargestPalindrome
    {

        public string Solution(string s)
        {

            int stringLength = s.Length;
            if (stringLength <= 1) return s;
            int start = 0;
            int maxLength = 1;

            for (int i = 0; i < stringLength; i++)
            {
                for (int j = 0; j <= 1; j++)
                {

                    int low = i;
                    int high = i + j;

                    while (low >= 0 && high < stringLength && s[low] == s[high])
                    {

                        if (high - low + 1 > maxLength)
                        {
                            start = low;
                            maxLength = high - low + 1;
                        }

                        low--;
                        high++;

                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}
