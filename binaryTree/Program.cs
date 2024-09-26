namespace binaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Binary Tree adalah struktur data hierarkis di mana setiap node memiliki paling banyak dua anak,
            // biasanya disebut sebagai anak kiri dan kanan.

            BinaryTree tree = new BinaryTree();
            tree.root = new TreeNode(1);
            tree.root.left = new TreeNode(2);
            tree.root.right = new TreeNode(3);
            tree.root.left.left = new TreeNode(4);
            tree.root.left.right = new TreeNode(5);

            // Traversing in-order

            tree.InOrder(tree.root);
        }
    }

    public class TreeNode
    {
        public int value;
        public TreeNode left, right;

        public TreeNode(int value)
        {
            this.value = value;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode root;

        public void InOrder(TreeNode node)
        {
            if (node == null) return;

            InOrder(node.left);
            Console.WriteLine(node.value);
            InOrder(node.right);
        }
    }
}
