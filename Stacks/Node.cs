using System;
class Node<T> {
    public T data;
    public Node<T> Next ;
    private Node(){}

    public Node(T data){
        this.data = data;
        this.Next = null;
    }
}
