using System;
using Queue;

public class Program{
    public static void Main(string[] args)
    {
        //creating the queue
       CustomQueue<int> customQueue=new CustomQueue<int>();
       //Adding Elements to the queue
       customQueue.EnQueue(1);
       customQueue.EnQueue(2);
       customQueue.EnQueue(3);
       customQueue.EnQueue(4);

       customQueue.EnQueue(5);

        //Iterating to the object
       foreach(int i  in customQueue ){
        System.Console.Write(i + " ");
       }
       //peeking the first Element in Queue
       System.Console.WriteLine(customQueue.Peek());
       customQueue.EnQueue(5);
       //Reoving the first Element and diplaying
       customQueue.Dequeue();
    }
}
