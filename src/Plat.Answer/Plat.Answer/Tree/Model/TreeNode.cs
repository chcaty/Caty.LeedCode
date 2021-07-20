namespace Plat.Answer.Tree.Model
{
    public class TreeNode
    {
        /// <summary>
        /// 值
        /// </summary>
        public int Val;

        /// <summary>
        /// 左节点
        /// </summary>
        public TreeNode Left;

        /// <summary>
        /// 右节点
        /// </summary>
        public TreeNode Right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
        }
    }
}