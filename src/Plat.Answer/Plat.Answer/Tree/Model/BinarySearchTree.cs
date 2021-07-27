namespace Plat.Answer.Tree.Model
{
    public class BinarySearchTree
    {
        public TreeNode Tree;

        public TreeNode Find(int data)
        {
            var p = Tree;
            while (p != null)
            {
                if (data < p.Val) p = p.Left;
                else if (data > p.Val) p = p.Right;
                else return p;
            }

            return null;
        }

        public void Insert(int data)
        {
            if (Tree == null)
            {
                Tree = new TreeNode(data);
                return;
            }

            var p = Tree;
            while (p != null)
            {
                if (data > p.Val)
                {
                    if (p.Right == null)
                    {
                        p.Right = new TreeNode(data);
                        return;
                    }
                    p = p.Right;
                }
                else
                {
                    if (p.Left == null)
                    {
                        p.Left = new TreeNode(data);
                        return;
                    }
                    p = p.Left;
                }
            }
        }

        public void Delete(int data)
        {
            var p = Tree;
            TreeNode pp = null;
            while (p != null && p.Val != data)
            {
                pp = p;
                p = data > p.Val ? p.Right : p.Left;
            }
            if (p == null) return;
            if (p.Left != null && p.Right != null)
            {
                var minP = p.Right;
                var minPP = p;
                while (minP.Left != null)
                {
                    minPP = minP;
                    minP = minP.Left;
                }

                p.Val = minP.Val;
                p = minP;
                pp = minPP;
            }

            TreeNode child;
            if (p.Left != null) child = p.Left;
            else if (p.Right != null) child = p.Right;
            else child = null;

            if (pp == null) Tree = child;
            else if (pp.Left == p) pp.Left = child;
            else pp.Right = child;
        }
    }
}