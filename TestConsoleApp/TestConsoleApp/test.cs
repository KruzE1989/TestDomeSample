using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Test
    {
        public Tuple<int, int>? FindTwoSum(IList<int> list, int targetSum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] + list[j] == targetSum)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            return null;
        }

        public Tuple<int, int>? FindTwoSum2(IList<int> list, int targetSum)
        {
            if (list.Count < 2)
            {
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                int val = targetSum - list[i];
                if (list.Contains(val) && list.IndexOf(val) != i)
                {
                    return new Tuple<int, int>(i, list.IndexOf(val));
                }
            }

            return null;
        }

        public Tuple<int, int>? FindTwoSum3(IList<int> list, int targetSum)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                var needed = targetSum - list[i];
                if (hs.Contains(needed))
                {
                    return Tuple.Create(list.IndexOf(needed), i);
                }
                hs.Add(list[i]);
            }
            return null;
        }

    }
}
