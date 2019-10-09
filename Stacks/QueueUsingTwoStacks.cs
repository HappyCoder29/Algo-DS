using System;

class QueueUsingTwoStacks{

    Stack<int> s1, s2;

    public void Enqueue(int x){
        s1.Push(x);
    }

    public int DeQueue(){
        if(s1.Count() == 0 )
            return int.MinValue;
        
        while(s1.Count() > 0){
            s2.Push(s1.Pop());
        }
        int retVal = s2.Pop();

         while(s2.Count() > 0){
            s1.Push(s2.Pop());
        }
        return retVal;

    }
}