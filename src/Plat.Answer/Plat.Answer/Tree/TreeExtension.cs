using Plat.Answer.Tree.Model;

namespace Plat.Answer.Tree
{
    public static class TreeExtension
    {
        private static int _ans;
        private static int _rootvalue;

        /// <summary>
        /// 二叉树中第二小的节点
        /// 给定一个非空特殊的二叉树，每个节点都是正数，并且每个节点的子节点数量只能为 2 或 0。如果一个节点有两个子节点的话，那么该节点的值等于两个子节点中较小的一个。
        /// 更正式地说，root.val = min(root.left.val, root.right.val) 总成立。
        /// 给出这样的一个二叉树，你需要输出所有节点中的第二小的值。如果第二小的值不存在的话，输出 -1 。
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindSecondMinimumValue(TreeNode root)
        {
            _ans = -1;
            _rootvalue = root.Val;
            DFS(root);
            return _ans;
        }

        public static void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (_ans != -1 && node.Val >= _ans)
            {
                return;
            }
            if (node.Val > _rootvalue)
            {
                _ans = node.Val;
            }
            DFS(node.Left);
            DFS(node.Right);
        }
    }
}