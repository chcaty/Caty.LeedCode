using System;
using System.Collections.Generic;

namespace Plat.Answer.Hash
{
    public class HashExtension
    {
        /// <summary>
        /// 编写一种方法，对字符串数组进行排序，将所有变位词组合在一起。变位词是指字母相同，但排列不同的字符串。
        /// 示例:
        /// 输入: ["eat", "tea", "tan", "ate", "nat", "bat"],
        /// 输出:
        /// [
        ///   ["ate","eat","tea"],
        ///   ["nat","tan"],
        ///   ["bat"]
        /// ]
        /// 说明：
        ///   所有输入均为小写字母。
        ///   不考虑答案输出的顺序。
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // 由于互为变位词的两个字符串包含的字母相同，因此对两个字符串分别进行排序之后得到的字符串一定是相同的，故可以将排序之后的字符串作为哈希表的键
            var dictionary = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var array = str.ToCharArray();
                Array.Sort(array);
                var key = new string(array);
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key].Add(str);
                }
                else
                {
                    IList<string> list = new List<string> { str };
                    dictionary.Add(key, list);
                }
            }
            return new List<IList<string>>(dictionary.Values);
        }
    }
}