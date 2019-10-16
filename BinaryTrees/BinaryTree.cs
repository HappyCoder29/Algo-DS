using System;
using System.Collections.Generic;

class BinaryTree<T>{
    public Node<T> root { get; set; }

    public BinaryTree(){
        root = null;
    }

    public void PreOrder(){
        PreOrder(root);
        Console.WriteLine();
    }
    public void PreOrder(Node<T> node){
        if(node != null){
            Console.Write(node.data + " ,");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public void PostOrder(){
        PostOrder(root);
        Console.WriteLine();
    }
    public void PostOrder(Node<T> node){
        if(node != null){
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.data + " ,");
        }
    }

    public void InOrder(){
        InOrder(root);
        Console.WriteLine();
    }
    public void InOrder(Node<T> node){
        if(node != null){
            InOrder(node.Left);
            Console.Write(node.data + " ,");
            InOrder(node.Right);
        }
    }

    public int Size(){
        return Size(root);
    }
    public int Size(Node<T> node){
        if(node == null)
            return 0;

        return Size(node.Left) + 1 + Size(node.Right);
    }

    public int Height(){
        return Height(root);
    }
    private int Height(Node<T> node){
        if(node == null)
            return 0;
        int left = Height(node.Left);
        int right = Height(node.Right);

        return 1 + Math.Max(left, right );
        
    }

    public void LevelOrder(){
        if(root == null)
            return;
        
        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while(queue.Count != 0){
            Node<T> node = queue.Dequeue();
            if(node != null){
                Console.Write(node.data + " ,");
                if(node.Left != null)
                    queue.Enqueue(node.Left);
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }else{
                Console.WriteLine();
                if(queue.Count == 0)
                    break;
                queue.Enqueue(null);
                
            }
        }

    }

    public void PrintLeftView(){
        if(root == null)
            return;
        
        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        bool printed = false;

        while(queue.Count != 0){
            Node<T> node = queue.Dequeue();
            if(node != null){
                if(! printed){
                    Console.Write(node.data + " ,");
                    printed = true;
                }
                
                if(node.Left != null)
                    queue.Enqueue(node.Left);
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }else{
                Console.WriteLine();
                printed = false;
                if(queue.Count == 0)
                    break;
                queue.Enqueue(null);
                
            }
        }

    }

    public void PrintRightView(){
        if(root == null)
            return;
        
        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        Node<T> lastval = null;

        while(queue.Count != 0){
            Node<T> node = queue.Dequeue();
            if(node != null){
                
                lastval = node;
                //Console.Write(node.data + " ,");
                
                
                if(node.Left != null)
                    queue.Enqueue(node.Left);
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }else{
                Console.Write(lastval.data + " ,");
                Console.WriteLine();
                if(queue.Count == 0)
                    break;
                queue.Enqueue(null);
                
            }
        }

    }


    public void PrintZigZag(){
        if(root == null)
            return;
        
        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        bool print = true;
        Stack<Node<T>> stack = new Stack<Node<T>>();

        while(queue.Count != 0){
            Node<T> node = queue.Dequeue();
            if(node != null){
                if(print)
                    Console.Write(node.data + " ,");
                else
                    stack.Push(node);
                
                if(node.Left != null)
                    queue.Enqueue(node.Left);
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }else{
                print = !print;
                while(stack.Count != 0){
                    Console.Write(stack.Pop().data + " ,");
                }
                Console.WriteLine();
                if(queue.Count == 0)
                    break;
                queue.Enqueue(null);
                
            }
        }
        while(stack.Count != 0){
            Console.Write(stack.Pop().data + " ,");
        }
    }

    public void PrintLeaves(){
        PrintLeaves(root);
        Console.WriteLine();
    }
    public void PrintLeaves(Node<T> node){
        if(node != null){
            if(node.Left == null && node.Right == null)
                Console.Write(node.data + " ,");
            PrintLeaves(node.Left);
            PrintLeaves(node.Right);
        }
        
    }

    public void PrintPerimeter(){
        Stack<Node<T>> stack = new Stack<Node<T>>();
        PrintPerimeter(root, 0, 0, stack);
        while(stack.Count != 0){
            Console.Write(stack.Pop().data + " ,");
        }
        Console.WriteLine();

    }
    public void PrintPerimeter(Node<T> node, int left, int right, Stack<Node<T>> stack){
        if(node != null){

            int l = left;
            int r = right;
            // ROOT NODE
            if(right == 0 && left == 0 ){
                Console.Write(node.data + " ,");
            }
            if(right == 0 && left != 0){
                // left side
                Console.Write(node.data + " ,");
            }
            else if(right != 0 && left == 0){
                // right side
                stack.Push(node);
                //Console.Write(node.data + " ,");
            }
            else if(node.Left == null && node.Right == null){
                // leaf nodes
                Console.Write(node.data + " ,");
            }

            PrintPerimeter(node.Left, l + 1, right, stack);
            PrintPerimeter(node.Right, l , right + 1, stack);
        }
        
    }

    public void PrintAtlevel(int k){
        PrintAtlevel(root, k);
    }
    public void PrintAtlevel(Node<T> node, int k){
        if(node == null)
            return;
        
        if( k == 1 ){
            Console.WriteLine(node.data);
            return;
        }
        PrintAtlevel(node.Left, k-1);
        PrintAtlevel(node.Right, k-1);
    }

    public int Diameter(){
        return Diameter(root);
    }

    private int Diameter(Node<T> node){
        if(node == null)
            return 0;

        int lHeight = Height(node.Left);
        int rHeight = Height(node.Right);

        int lDiameter = Diameter(node.Left);
        int rDiameter = Diameter(node.Right);

        return Math.Max( (lHeight + rHeight +1), Math.Max(lDiameter, rDiameter) );
        
    }

    public bool AreSiblings(Node<T> a, Node<T> b){
        return AreSiblings(root, a, b);
    }


    private bool AreSiblings(Node<T> node, Node<T> a, Node<T> b){
        if(node == null)
            return false;

        return (    node.Left == a && node.Right == b ||
                    node.Left ==b && node.Right == a ||
                    AreSiblings(node.Left, a, b) || 
                    AreSiblings(node.Right, a, b) 
                );
    }

    public Node<T> LCA(Node<T> A, Node<T> B){
        HashSet<Node<T>> set = new HashSet<Node<T>>();

        set.Add(A);
        set.Add(B);
        Node<T> currA = A;
        Node<T> currB = B;
        while(currA.Parent != null || currB.Parent != null){
            if(set.Contains(currA.Parent))
                return currA.Parent;
            if(set.Contains(currB.Parent))
                return currB.Parent;
            set.Add(currA);
            set.Add(currB);

            currA = currA.Parent;
            currB = currB.Parent;
        }
        return null;
    }

    public bool Isomorphic(Node<T> node1, Node<T> node2){
        if(node1 == null && node2 == null)
            return true;
        
        if(node1 == null || node2 == null){
            return false;
        }

        return (    Isomorphic(node1.Left, node2.Left) && 
                    Isomorphic(node1.Right, node2.Right)
                );


    }

    public int Getlevel(T data){
        return Getlevel(root, 1, data);
    }
    public int Getlevel(Node<T> node, int level, T data){
        if(node == null )
            return 0;
        
        if(node.data.Equals(data))
            return level;

        int downLevel  = Getlevel(node.Left , level +1, data);

        if(downLevel != 0)
            return downLevel;
        downLevel = Getlevel(node.Right, level + 1, data);

        return downLevel;

    }



}