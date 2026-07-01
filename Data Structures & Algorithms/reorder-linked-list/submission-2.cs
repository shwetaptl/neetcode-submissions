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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        //reverse half list 
        ListNode curr = slow.next;
        slow.next = null; // last element set next null
        ListNode prev = null;
        
        while(curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        //Reorder list
        ListNode first = head;
        ListNode second = prev;
        
        
        while(first != null && second != null)
        {
            ListNode firstNext = first.next;
            ListNode secondNext = second.next;
            first.next = second;
            second.next = firstNext;
            first = firstNext;
            second = secondNext;
        }
    }
}
