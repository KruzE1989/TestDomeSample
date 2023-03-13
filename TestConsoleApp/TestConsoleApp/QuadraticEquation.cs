using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            //var inner = (b * b) - (4 * a * c);
            //var rootpart = Math.Sqrt(inner);
            //var denom = 2 * a;
            //var num1 = (-b) + rootpart;
            //var num2 = (-b) - rootpart;
            //var root1 = num1/denom;
            //var root2 = num2/denom;

            double root1 = ((-b) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            double root2 = ((-b) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            return Tuple.Create(root1, root2);
        }
    }
}
