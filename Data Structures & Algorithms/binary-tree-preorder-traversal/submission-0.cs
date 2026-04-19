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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        Preorder(root, result);
        return result;
    }

    private void Preorder(TreeNode node, List<int> result) {
        if(node is null)
            return;
        
        result.Add(node.val);
        Preorder(node.left,result);
        Preorder(node.right,result);
    }
}