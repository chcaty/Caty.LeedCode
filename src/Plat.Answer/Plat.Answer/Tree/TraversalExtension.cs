using Plat.Answer.Tree.Model;
using System.Collections.Generic;

namespace Plat.Answer.Tree
{
    public static class TraversalExtension
    {
        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            list.Add(root.Val);
            list.AddRange(PreorderTraversal(root.Left));
            list.AddRange(PreorderTraversal(root.Right));
            return list;
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            list.AddRange(InorderTraversal(root.Left));
            list.Add(root.Val);
            list.AddRange(InorderTraversal(root.Right));
            return list;
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            list.AddRange(PostorderTraversal(root.Left));
            list.AddRange(PostorderTraversal(root.Right));
            list.Add(root.Val);
            return list;
        }
    }
}