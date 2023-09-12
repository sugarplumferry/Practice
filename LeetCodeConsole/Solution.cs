using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeConsole.inteface;

namespace LeetCodeConsole
{
    public class Solution : ISolution
    {
        public int MinDeletions(string s)
        {
            int deletions = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if(dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                    dic[c] = 1;
            }

            HashSet<int> set = new HashSet<int>();
            foreach (var value in dic.Values)
            {
                int freq = value;
                while(freq > 0 && set.Contains(freq))
                {
                    freq--;
                    deletions++;
                }
                set.Add(freq);


            }
            return deletions;
            

            

        }

    }
}