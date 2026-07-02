/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
         if (head == null) return null;

        // Step 1: Clone each node and insert it after the original
        Node curr = head;
        while (curr != null) {
            Node newNode = new Node(curr.val);
            newNode.next = curr.next;
            curr.next = newNode;
            curr = newNode.next;
        }

        // Step 2: Assign random pointers for cloned nodes
        curr = head;
        while (curr != null) {
            if (curr.random != null)
                curr.next.random = curr.random.next;
            curr = curr.next.next;
        }

        // Step 3: Separate cloned list from original
        curr = head;
        Node cloneHead = head.next;
        Node copy = cloneHead;

        while (curr != null) {
            curr.next = curr.next.next;
            copy.next = copy.next != null ? copy.next.next : null;
            curr = curr.next;
            copy = copy.next;
        }

        return cloneHead;
    }
}
