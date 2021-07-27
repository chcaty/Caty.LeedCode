using System;

namespace Plat.Answer.Algorithm.SlidingWindow
{
     public static class SlidingWindowsExtension
    {
        /// <summary>
        /// 最高频元素的频数
        /// 元素的 频数 是该元素在一个数组中出现的次数。
        /// 给你一个整数数组 nums 和一个整数 k 。在一步操作中，你可以选择 nums 的一个下标，并将该下标对应元素的值增加 1 。
        /// 执行最多 k 次操作后，返回数组中最高频元素的 最大可能频数 。
        /// 示例 1：
        ///   输入：nums = [1,2,4], k = 5
        ///   输出：3
        ///   解释：对第一个元素执行 3 次递增操作，对第二个元素执 2 次递增操作，此时 nums = [4, 4, 4] 。
        ///   4 是数组中最高频元素，频数是 3 。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxFrequency(int[] nums, int k)
        {
            // 排序加滑动窗口
            System.Array.Sort(nums);
            var n = nums.Length;
            long total = 0;
            int l = 0, res = 1;
            for (var r = 1; r < n; ++r)
            {
                total += (long)(nums[r] - nums[r - 1]) * (r - l);
                while (total > k)
                {
                    total -= nums[r] - nums[l];
                    ++l;
                }
                res = Math.Max(res, r - l + 1);
            }
            return res;
        }
    }
}
