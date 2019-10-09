class Stack<T>{
    private Node<T> head;
    public Stack(){
        head = null;
    }

    public bool isEmpty(){
        return head == null;
    }

    public T Pop(){
        if( head == null)
            return default(T);
        T value = head.data;
        Node<T> temp = head;
        head = head.Next;
        temp = null;
        return value;

    }

    public Node<T> PopNode(){
        if( head == null)
            return null;
        Node<T> temp = head;
        head = head.Next;
        temp.Next  = null;
        return temp;
    }

    public void Push(T data){
        Node<T> add = new Node<T>(data);
        add.Next = head;
        head = add;

    }

    public T Peek(){
        if(head == null)
            return default(T);
        return head.data;
    }

    public Node<T> PeekNode(){
        if(head == null)
            return null;
        return head;
    }

    public int Count(){
        int count = 0;
        Node<T> temp = head;
        while(temp != null){
            count ++;
            temp = temp.Next;
        }
        return count;
    }
}