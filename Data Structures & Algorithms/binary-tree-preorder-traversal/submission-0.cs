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
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;

        while (cur != null || stack.Count > 0) {
            if (cur != null) {
                res.Add(cur.val);
                stack.Push(cur.right);
                cur = cur.left;
            } else {
                cur = stack.Pop();
            }
        }

        return res;
    }
}