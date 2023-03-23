using System;

class Program
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode sentinel = new ListNode();
        ListNode p1 = l1, p2 = l2, p3 = sentinel;
        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                AppendNode(ref p1, ref p3);
            }
            else
            {
                AppendNode(ref p2, ref p3);
            }
        }

        while (p1 != null)
        {
            AppendNode(ref p1, ref p3);
        }

        while (p2 != null)
        {
            AppendNode(ref p2, ref p3);
        }

        return sentinel.next;
    }

    private void AppendNode(ref ListNode src, ref ListNode dst)
    {
        ListNode t = new ListNode(src.val);
        dst.next = t;
        dst = dst.next;
        src = src.next;
    }
    static void Main()
    {
        ListNode l1 = [ 1, 2, 3, 4 ];
        ListNode l2 = [3, 5, 6, 7];
        Program p1 = new Program();
        p1.MergeTwoLists(l1, l2);
    }
}