using System;
using System.Runtime.InteropServices;
using Stack;

public class program{

    public static void Main(string[] args)
    {
        //Creating Stack
        CustomStack<string> customStack=new CustomStack<string>();
        //push the element into stacks
        customStack.Push("one");
        customStack.Push("Two");
        customStack.Push("Three");
        customStack.Push("Foue");
        //peeking last added element
        System.Console.WriteLine(customStack.peek());
        //removing the element
        System.Console.WriteLine(customStack.pop());
          
    }
}