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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head == null || left == right ) return head;

        ListNode dummy = new ListNode(0, head);

        ListNode prev = dummy;
        for(int i = 0; i < left-1;i++) {
            prev = prev.next;
        }

        ListNode sublistHead = prev.next;
        ListNode sublistTail = sublistHead;

        for(int i = 0; i < right - left; i++) {
            sublistTail = sublistTail.next;
        }

        ListNode nextNode = sublistTail.next;
        sublistTail.next = null;

        ListNode reversedSublist = ReverseList(sublistHead);
        prev.next = reversedSublist;

        sublistHead.next = nextNode;

        return dummy.next;
    }

    private ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}