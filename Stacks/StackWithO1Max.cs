using System;

class StackWithO1Max{
    Stack<int> main;
    Stack<int> temp;

    public StackWithO1Max(){
        main = new Stack<int>();
        temp = new Stack<int>();
    }

    public void Push(int data){
        if(main.Count() == 0){
            main.Push(data);
            temp.Push(data);
            return;
        }

        if(data >= temp.Peek() ){
            temp.Push(data);
        }
        main.Push(data);

    }

    public int Pop(){
        if(main.Peek() == temp.Peek())
            temp.Pop();
        
        return main.Pop();
    }

    public int Max(){
        return temp.Peek();
    }

}