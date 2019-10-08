using System;

namespace LinkListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListClass ll = new LinkListClass();
            ll.AddHeadNode(1);
            ll.AddNodeToTail(5);
            ll.AddNodeToTail(7);
            ll.AddNodeToTail(-1);
            ll.AddNodeToTail(3);
            ll.PrintLinkList();
            ll.ReverseList();
            ll.PrintLinkList();


        }
    }
}
