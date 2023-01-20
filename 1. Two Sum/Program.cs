using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 4 };
            var res = TwoSum(nums, 6);

            foreach (var item in res)
             Console.WriteLine(item);

            Console.ReadKey();
        }

        //Array | O(n) time | O(n) space
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            return new int[2];
        }




    }
}
