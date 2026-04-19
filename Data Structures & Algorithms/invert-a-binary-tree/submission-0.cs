/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        Preorder(root);
        return root;
    }

    private void Preorder(TreeNode node) {
        if(node is null)
            return;

        var curr = node.left;
        node.left = node.right;
        node.right = curr;

        Preorder(node.left);
        Preorder(node.right);
    }
}
