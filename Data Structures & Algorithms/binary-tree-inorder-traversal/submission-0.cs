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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        DFS(root,result);

        return result;
    }

    void DFS(TreeNode node, List<int> result){
        if(node != null) {

            DFS(node.left, result);
            result.Add(node.val);
            DFS(node.right,result);
        }
    }
}