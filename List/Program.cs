using System;
using System.ComponentModel.DataAnnotations;

namespace List;
public class Program
{
    public static void Main(string[] args)
    {
        //creating the list
        CustomList<int> numberList = new CustomList<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(98);
         //creating the second list
        CustomList<int> secondList=new CustomList<int>(){43,54};
        numberList.AddRange(secondList);
        System.Console.WriteLine("Capacity of list is:"+numberList.Capacity);
        System.Console.WriteLine("count now is:"+numberList.Count);
        //Inserting the number
        numberList.Insert(1,44);

        foreach(int i in numberList){
            System.Console.Write(i + " ");
        }
        //check the value is present or not in given in list
        bool result=numberList.Contains(40);
        int position=numberList.IndexOf(20);
        numberList.Insert(2,30);
        numberList.RemoveAt(2);
        //remove the element
        bool temp=numberList.Remove(40);
        //reversing the list
        numberList.Reverse();
        //sorting the list
        numberList.Sort();
       
    }
}
