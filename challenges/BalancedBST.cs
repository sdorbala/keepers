using challenges.DataStructures;
/* 
    Given a sorted array, convert it into a height-balanced binary search tree.
*/

namespace challenges.DCP {
    public static class BalancedBST {
        public static TreeNode BuildTree(int[] array) {
            TreeNode root = new TreeNode();
            buildTree(root, array, 0, array.Length - 1);
            return root;
        }
        private static TreeNode buildTree(TreeNode node, int[] array, int begin, int end) {
            if (begin > end)
                return null;
            node.Value = array[(begin + end) / 2];
            if (end - begin > 0) { // whether to create left child or not
                node.Left = new TreeNode();
                buildTree(node.Left, array, begin, ((begin + end) / 2) - 1);
            }
            if (end - begin > 1) { // whether to create right child or not
                node.Right = new TreeNode();
                buildTree(node.Right, array, ((begin + end) / 2) + 1, end);
            }
            return node;
        }
    }
}
