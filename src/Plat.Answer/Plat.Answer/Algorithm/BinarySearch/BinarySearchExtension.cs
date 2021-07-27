namespace Plat.Answer.Algorithm.BinarySearch
{
    public static class BinarySearchExtension
    {
        /// <summary>
        /// 最简单的二分查找算法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BsSearch(int[] a, int n, int value)
        {
            var low = 0;
            var high = n - 1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                if (a[mid] == value)
                {
                    return mid;
                }
                else if (a[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// 二分查找变体一 查找第一个值等于给定值的元素
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BsSearchFirstEqual(int[] a, int n, int value)
        {
            var low = 0;
            var high = n - 1;
            while (low <= high)
            {
                var mid = low + ((high - low) >> 1);
                if (a[mid] > value)
                {
                    high = mid - 1;
                }
                else if (a[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    if (mid == 0 || a[mid - 1] != value)
                        return mid;
                    high = mid - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 二分查找变体二 查找最后一个值等于给定值的元素
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BsSearchLastEqual(int[] a, int n, int value)
        {
            var low = 0;
            var high = n - 1;
            while (low <= high)
            {
                var mid = low + ((high - low) >> 1);
                if (a[mid] > value)
                {
                    high = mid - 1;
                }
                else if (a[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    if (mid == n - 1 || a[mid + 1] != value)
                        return mid;
                    low = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 二分查找变体三 查找第一个大于等于给定值的元素
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BsSearchFirstEqualOrGreater(int[] a, int n, int value)
        {
            var low = 0;
            var high = n - 1;
            while (low <= high)
            {
                var mid = low + ((high - low) >> 1);
                if (a[mid] >= value)
                {
                    if (mid == 0 || a[mid - 1] < value)
                    {
                        return mid;
                    }

                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 二分查找变体四 查找最后一个小于等于给定值的元素
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BsSearchLastEqualOrLess(int[] a, int n, int value)
        {
            var low = 0;
            var high = n - 1;
            while (low <= high)
            {
                var mid = low + ((high - low) >> 1);
                if (a[mid] <= value)
                {
                    if (mid == n - 1 || a[mid + 1] > value)
                    {
                        return mid;
                    }
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}