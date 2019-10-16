using System;

class Node<T>{
    public T data { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    
    public Node<T> Parent { get; set; }

    private Node(){}

    public Node(T data){
        this.data = data;
        this.Left = null;
        this.Right = null;
        this.Parent = null;
    }

}