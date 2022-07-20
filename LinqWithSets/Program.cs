using static System.Console;

string[] cohort1 = new[] { "Rachel", "Gareth", "Jonathan", "George" };
string[] cohort2 = new[] { "Jack", "Stephen", "Daniel", "Jack", "Jared" };
string[] cohort3 = new[] { "Declan", "Jack", "Jack", "Jasmine", "Conor" };

Output(cohort1, "Cohort 1");
Output(cohort2, "Cohort 2");
Output(cohort3, "Cohort 3");

Output(cohort2.Distinct(), "cohort2.Distinct()");
// start at index 0 until index 2
Output(cohort2.DistinctBy(name => name.Substring(0, 2)), "cohort2.DistinctBy(name => name.Substring(0, 2)");
//  Union produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
Output(cohort2.Union(cohort3), "cohort2.Union(cohort3)");
// Concat concatenates two sequences.
Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3)");
// Intersect produces the set intersection of two sequences by using the default equality
//     comparer to compare values.
Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3)");
Output(cohort2.Except(cohort3), "cohort2.Except(cohort3)");
Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matched with {c2}"), "cohort1.Zip(cohort2)");

static void Output(IEnumerable<string> cohort, string descriptoin = "")
{
    if (!string.IsNullOrEmpty(descriptoin))
    {
        WriteLine(descriptoin);
    }
    Write("");
    WriteLine(string.Join(", ", cohort.ToArray()));
    WriteLine();
}