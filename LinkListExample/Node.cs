using System;

class Node{

    public int data { get; set; }
    public Node Next { get; set; }

    private Node(){}

    public Node(int data){
        this.data = data;
        this.Next = null;
    }
}