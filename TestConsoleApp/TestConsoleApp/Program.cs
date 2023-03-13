using TestConsoleApp;
using TestDomeSolutions;

Test obj = new();
Tuple<int, int>? indices1 = obj.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
Tuple<int, int>? indices2 = obj.FindTwoSum2(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
Tuple<int, int>? indices3 = obj.FindTwoSum3(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);

Console.WriteLine(indices1);
Console.WriteLine(indices2);
Console.WriteLine(indices3);


/******************************************************************************/
Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);

/******************************************************************************/

string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia