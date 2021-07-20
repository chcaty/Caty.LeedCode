using Plat.Answer.Tree.Model;

namespace Plat.Answer.Tree
{
    public static class InvertExtension
    {
        /// <summary>
        /// 翻转一棵二叉树。
        /// 示例：
        /// 输入：
        ///     4
        ///   /   \
        ///  2     7
        /// / \   / \
        ///1   3 6   9
        /// 
        ///输出：
        ///     4
        ///   /   \
        ///  7     2
        /// / \   / \
        ///9   6 3   1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;
            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;
            InvertTree(root.Left);
            InvertTree(root.Right);
            return root;
        }
    }
}