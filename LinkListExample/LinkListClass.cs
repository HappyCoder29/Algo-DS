using System;

class LinkListClass{
    public Node head { get; set; }

    public LinkListClass(){
        head = null;
    }




    //Adds Node to the head of the Link List
    public void AddHeadNode(int data){
        Node add = new Node(data);
        add.Next = head;
        head = add;
    }

    // Adds Node to Tail of the link list
    public void AddNodeToTail(int data){
        Node add = new Node(data);
        
        // if head is null make add node as head and return
        if(head == null){
            head = add;
            return;
        }

        //create a temp node and traverse to last of the list
        // make last node point to add node and return
        Node temp = head;
        while(temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = add;

    }

    public void PrintLinkList(){
        // Make temp node point to head and then continue printing the node
        // till the temp node reaches null 
        Node temp = head;
        while(temp != null){
            Console.Write(temp.data + "->");
            temp = temp.Next;
        }
        Console.WriteLine("NULL");
    }

    public void ReverseList(){
        // If head is null or there is just one node, just return
        if(head == null || head.Next == null)
            return;
        
        // Tke 3 nodes back, mid and front
        Node back = null;
        Node mid = head;
        Node front = head.Next;

        // while front does not reach null break mid next and point to back
        // we are assuming there is no cycle
        while(front != null){
            mid.Next = back;
            back = mid;
            mid = front;
            front = front.Next;
        }

        // mid still points to null so point it to back and make head point to mid
        mid.Next = back;
        head = mid;
    }

    ]
}