/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head is null)
            return head;

        ListNode prev = head; // 0
        ListNode curr = head.next; // 1, 2, 3
        prev.next = null;

        while(curr != null) {
            var next = curr.next; // 2,3
            curr.next = prev; // 1,0
            prev = curr; // 1,0
            curr = next; // 2,3
        }

        return prev;
    }
}
