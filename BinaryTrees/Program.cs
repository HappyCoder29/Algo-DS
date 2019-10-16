using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.root = CreateTree();
            Node<int> a = tree.root.Left;
            Node<int> b = tree.root.Right;

            int level = tree.Getlevel(6);



            Console.WriteLine("Hello World!");
        }

        static Node<int> CreateTree(){
            Node<int> root= new Node<int>(1);

            root.Left = new Node<int>(2);
            root.Right = new Node<int>(3);


            root.Left.Left = new Node<int>(4);
            root.Left.Right = new Node<int>(5);
            root.Right.Left = new Node<int>(6);
            root.Right.Right = new Node<int>(7);

            root.Left.Left.Left = new Node<int>(8);
            root.Left.Left.Right = new Node<int>(9);
            root.Right.Left.Left = new Node<int>(10);
            root.Right.Left.Right = new Node<int>(11);



            return root;



        }


    }
}
