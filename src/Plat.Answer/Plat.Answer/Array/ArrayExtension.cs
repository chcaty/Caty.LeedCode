using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Plat.Answer.Array
{
    public static class ArrayExtension
    {
        /// <summary>
        /// 数组中最大数对和的最小值
        /// 一个数对 (a,b) 的 数对和 等于 a + b 。最大数对和 是一个数对数组中最大的 数对和 。
        /// 比方说，如果我们有数对(1,5) ，(2,3) 和(4,4)，最大数对和 为 max(1+5, 2+3, 4+4) = max(6, 5, 8) = 8 。
        /// 给你一个长度为 偶数 n 的数组 nums ，请你将 nums 中的元素分成 n / 2 个数对，使得：
        /// nums 中每个元素 恰好 在 一个 数对中，且最大数对和 的值 最小 。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinPairSum(int[] nums)
        {
            var max = 0;
            System.Array.Sort(nums);
            for (var i = 0; i < nums.Length / 2; i++)
            {
                var sum = nums[i] + nums[nums.Length - 1 - i];
                max = sum > max ? sum : max;
            }
            return max;
        }

        /// <summary>
        /// 搜索插入位置
        /// 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
        /// 请必须使用时间复杂度为 O(log n) 的算法。
        /// 示例 1:
        /// 输入: nums = [1,3,5,6], target = 5
        /// 输出: 2
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + ((right - left) / 2);
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return left;
        }

        /// <summary>
        /// 检查是否区域内所有整数都被覆盖
        /// 给你一个二维整数数组 ranges 和两个整数 left 和 right 。每个 ranges[i] = [starti, endi] 表示一个从 starti 到 endi 的 闭区间 。
        /// 如果闭区间[left, right] 内每个整数都被 ranges 中 至少一个 区间覆盖，那么请你返回 true ，否则返回 false 。
        /// 已知区间 ranges[i] = [starti, endi] ，如果整数 x 满足 starti <= x <= endi ，那么我们称整数x 被覆盖了。
        /// </summary>
        /// <param name="ranges"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool IsCovered(int[][] ranges, int left, int right)
        {
            var list = new List<int>();
            for (var i = left; i <= right; i++)
            {
                list.Add(i);
            }
            for (var i = 0; i < ranges.Length; i++)
            {
                var tmpLeft = ranges[i][0];
                var tmpRight = ranges[i][1];
                for (var j = tmpLeft; j <= tmpRight; j++)
                {
                    if (list.Contains(j))
                    {
                        list.Remove(j);
                    }
                }
            }
            return !list.Any();
        }

        /// <summary>
        /// 存在重复元素
        /// 给定一个整数数组，判断是否存在重复元素。
        /// 如果存在一值在数组中出现至少两次，函数返回 true 。如果数组中每个元素都不相同，则返回 false 。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            System.Array.Sort(nums);
            var hash = new Hashtable();
            for (var i = 0; i < nums.Length / 2; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    return true;
                }

                hash.Add(nums[i], nums[i]);
                if (hash.Contains(nums[nums.Length - 1 - i]))
                {
                    return true;
                }

                hash.Add(nums[nums.Length - 1 - i], nums[nums.Length - 1 - i]);
            }
            return false;
        }

        /// <summary>
        /// 最大子序和
        /// 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int pre = 0, maxAns = nums[0];
            foreach (var x in nums)
            {
                pre = Math.Max(pre + x, x);
                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;
        }
    }
}