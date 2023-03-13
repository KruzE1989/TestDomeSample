using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDomeSolutions
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            List<string> names = names1.ToList();
            foreach (string name in names2)
            {
                names.Add(name);
            }
            return names.Distinct().ToArray();
        }

    }
}
