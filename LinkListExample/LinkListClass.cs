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




}