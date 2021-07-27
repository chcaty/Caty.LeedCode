namespace Plat.Answer.Sort
{
    public static class SortExtension
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        public static void BubbleSort(int[] a, int n)
        {
            if (n <= 1) return;
            for (var i = 0; i < n; ++i)
            {
                // 提前退出冒泡循环的标志位
                var flag = false;
                for (var j = 0; j < n - i - 1; ++j)
                {
                    if (a[j] <= a[j + 1]) continue;
                    var tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                    // 表示有数据交换
                    flag = true;
                }
                // 没有数据交换，提前退出
                if (!flag) break;
            }
        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        public static void InsertionSort(int[] a, int n)
        {
            if (n <= 1) return;
            for (var i = 1; i < n; ++i)
            {
                var value = a[i];
                var j = i - 1;
                // 查找插入的位置
                for (; j >= 0; --j)
                {
                    if (a[j] > value)
                    {
                        a[j + 1] = a[j]; // 数据移动
                    }
                    else
                    {
                        break;
                    }
                }
                a[j + 1] = value; // 插入数据
            }
        }
        
        /// <summary>
        /// 计数排序
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        public static void CountingSort(int[] a, int n)
        {
            if (n <= 1) return;
            // 查找数组中数据的范围
            var max = a[0];
            for (var i = 1; i < n; ++i)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            var c = new int[max + 1]; // 申请一个计数数组c，下标大小[0,max]
            for (var i = 0; i <= max; ++i)
            {
                c[i] = 0;
            }
            // 计算每个元素的个数，放入c中
            for (var i = 0; i < n; ++i)
            {
                c[a[i]]++;
            }
            // 依次累加
            for (var i = 1; i <= max; ++i)
            {
                c[i] = c[i - 1] + c[i];
            }
            // 临时数组r，存储排序之后的结果
            var r = new int[n];
            // 计算排序的关键步骤，有点难理解
            for (var i = n - 1; i >= 0; --i)
            {
                var index = c[a[i]] - 1;
                r[index] = a[i];
                c[a[i]]--;
            }
            // 将结果拷贝给a数组
            for (var i = 0; i < n; ++i)
            {
                a[i] = r[i];
            }
        }
    }
}