using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = {100, 80, 60, 70, 60, 75, 85};
            CalculateStockSpan(prices);
            CalculateStockSpanNotOptimized(prices);
            List<Interval> list = new List<Interval>();

            list.Add(new Interval(10,12));
            list.Add(new Interval(2,7));
            list.Add(new Interval(9,23));
            list.Add(new Interval(1,3));
            MergeIntervals(list);

           // listCar.Sort();
            // SortByMiles sortMiles = new SortByMiles();
            // listCar.Sort(sortMiles);

            //SortByEnd sort = new SortByEnd();
            //list.Sort(sort);
            //list.Sort();
            

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            int count = stack.Count();
            Console.WriteLine("Hello World!");
        }

        static void CalculateStockSpan(int[] prices){
            if(prices.Length == 0 )
                return;
            
            int[] arr = new int[prices.Length];

            arr[0] = 1;
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            for(int i = 1; i < prices.Length; i ++){

                while(stack.Count() > 0 && prices[stack.Peek()] <= prices[i]){
                    stack.Pop();
                }
                if(stack.Count() == 0){
                    //everythign before this was smaller
                    arr[i] = i + 1;

                }
                else{
                    arr[i] =  i - stack.Peek();
                }
                stack.Push(i);
            }

            for(int i = 0 ; i < arr.Length; i ++){
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();


        }


        static void CalculateStockSpanNotOptimized(int[] prices){
            int[] arr = new int[prices.Length];
            arr[0] = 1;

            for(int i = 1 ; i < prices.Length; i ++){
                if(i == prices.Length -1){
                    Console.WriteLine();
                }
                int indexLow = 0;
                for(int j = i-1; j >0 ; j--){
                    if(prices[j] > prices[i]){
                        indexLow = j;
                        break;
                    }
                }
                arr[i] = i - indexLow;
            }

            for(int i = 0 ; i < arr.Length; i ++){
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();

        }

        static void MergeIntervals(List<Interval> list){

            if(list.Count <= 1)
                return;

            list.Sort();

            Stack<Interval> stack = new Stack<Interval>();

            stack.Push(list[0]);

            for(int i = 0 ; i < list.Count ; i ++){
                Interval top = stack.Peek();

                if(top.end < list[i].start){
                    stack.Push(list[i]);
                }
                else if(top.end > list[i].end){
                    continue;

                }
                else if(top.end > list[i].start){
                    stack.Pop();
                    stack.Push(new Interval(top.start, list[i].end));
                }
            }

            while(stack.Count() != 0){
                Interval test = stack.Pop();
                Console.WriteLine("[" + test.start + ", " + test.end + "]");
            }
        }
    }
}
