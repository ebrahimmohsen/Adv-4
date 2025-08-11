using System.Collections;

namespace Adv_4
{
    internal class Program
    {
        #region Q1 Count Frequency of Each Element
        static void CountFrequencies(int[] arr)
        {
            var freq = new Dictionary<int, int>();
            foreach (int num in arr)
                if (freq.ContainsKey(num)) freq[num]++;
                else freq[num] = 1;

            foreach (var kv in freq)
                Console.WriteLine($"{kv.Key} : {kv.Value}");

        }
        #endregion

        #region Q2 Find Key with Highest Value
        static string GetKeyWithHighestValue(Hashtable table)
        {
            string maxKey = null;
            int maxValue = int.MinValue;

            foreach (DictionaryEntry entry in table)
            {
                int value = (int)entry.Value;
                if (value > maxValue)
                {
                    maxValue = value;
                    maxKey = (string)entry.Key;
                }
            }
            return maxKey;
        }
        #endregion

        #region Q3 Find Keys for Specific TargetValue
        static void FindKeysForValue(Hashtable table, string targetValue)
        {
            bool found = false;
            foreach (DictionaryEntry entry in table)
            {
                if ((string)entry.Value == targetValue)
                {
                    Console.WriteLine(entry.Key);
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Key not found");
        }
        #endregion

        #region Q4 Group Anagrams
        static List<List<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                string sorted = new string(s.OrderBy(c => c).ToArray());
                if (!dict.ContainsKey(sorted))
                    dict[sorted] = new List<string>();
                dict[sorted].Add(s);
            }
            return dict.Values.ToList();
        }
        #endregion

        #region Q5 Check if Array Contains Duplicates
        static bool ContainsDuplicates(int[] arr)
        {
            return arr.Length != arr.Distinct().Count();
        }
        #endregion

        #region Q8 Find Missing Numbers from 1 to N
        static List<int> FindMissingNumbers(int[] arr, int N)
        {
            var set = new HashSet<int>(arr);
            var missing = new List<int>();
            for (int i = 1; i <= N; i++)
                if (!set.Contains(i)) missing.Add(i);
            return missing;
        }
        #endregion

        #region Q9 Unique Values with HashSet
        static HashSet<int> GetUniqueValues(List<int> nums)
        {
            return new HashSet<int>(nums);
        }
        #endregion

        #region Q10  Swap Keys and Values in Hashtable
        static Hashtable SwapKeysAndValues(Hashtable table)
        {
            var swapped = new Hashtable();
            foreach (DictionaryEntry entry in table)
                swapped[entry.Value] = entry.Key;
            return swapped;
        }
        #endregion

        #region Q11  Union of Two Sets
        static HashSet<int> UnionSets(HashSet<int> set1, HashSet<int> set2)
        {
            var union = new HashSet<int>(set1);
            union.UnionWith(set2);
            return union;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1 Count Frequency of Each Element
            int[] arrQ1 = { 1, 2, 2, 3, 1, 4 };
            CountFrequencies(arrQ1);
            #endregion

            #region Q2 Find Key with Highest Value
            Hashtable tableQ2 = new Hashtable()
            {
                { "A", 5 },
                { "B", 10 },
                { "C", 7 }
            };
            #endregion

            #region Q3 Find Keys for Specific TargetValue
            Hashtable tableQ3 = new Hashtable()
            {
                { "key1", "apple" },
                { "key2", "banana" },
                { "key3", "apple" }
            };
            FindKeysForValue(tableQ3, "apple");
            #endregion

            #region Q4 Group Anagrams
            string[] strsQ4 = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var grouped = GroupAnagrams(strsQ4);
            foreach (var group in grouped)
                Console.WriteLine($"[{string.Join(", ", group)}]");
            #endregion

            #region Q5 Check if Array Contains Duplicates
            int[] arrQ5 = { 1, 2, 3, 1 };
            Console.WriteLine("Contains duplicates: " + ContainsDuplicates(arrQ5));
            #endregion

            #region Q6 SortedDictionary for Students
            var students = new SortedDictionary<int, string>();
            students.Add(101, "Ahmed");
            students.Add(103, "Laila");
            students[102] = "Omar";
            students.Remove(103);
            Console.WriteLine("Student 101: " + students[101]);
            #endregion

            #region Q7 Employee Directory with SortedList
            var employees = new SortedList<int, string>();
            employees.Add(3, "Ali");
            employees.Add(1, "Sara");
            employees.Add(2, "Hana");
            foreach (var emp in employees)
                Console.WriteLine($"{emp.Key} : {emp.Value}");
            #endregion

            #region Q8 Find Missing Numbers from 1 to N
            int[] arrQ8 = { 2, 3, 7, 4, 9 };
            var missing = FindMissingNumbers(arrQ8, 10);
            Console.WriteLine("Missing: " + string.Join(", ", missing));
            #endregion

            #region Q9 Unique Values with HashSet
            var numsQ9 = new List<int> { 1, 2, 2, 3, 4, 4 };
            var unique = GetUniqueValues(numsQ9);
            Console.WriteLine("Unique: " + string.Join(", ", unique));
            #endregion

            #region Q10 Swap Keys and Values in Hashtable
            Hashtable tableQ10 = new Hashtable()
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 3 }
            };
            var swapped = SwapKeysAndValues(tableQ10);
            foreach (DictionaryEntry entry in swapped)
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            #endregion

            #region Q11
            static HashSet<int> UnionSets(HashSet<int> set1, HashSet<int> set2)
            {
                var union = new HashSet<int>(set1);
                union.UnionWith(set2);
                return union;
            }
            #endregion
        }
    }
}

