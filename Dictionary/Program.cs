using System;
using Dictionary;

class Program{
    public static void Main(string[] args)
    {
        CustomDictionary<string,string> dictionary=new CustomDictionary<string,string>();
        dictionary.Add("SF3001","sakthi");
        dictionary.Add("SF3002","Ravi");
        dictionary.Add("SF3003","Baskar");
        dictionary.Add("SF3004","Mani");
        dictionary.Add("SF3005","Ganesh");
        foreach(KeyValue<string,string> data in dictionary){
            System.Console.WriteLine(data.Key +" "+ data.Value);
        }
        System.Console.WriteLine(dictionary["1"]);

        dictionary["SF3001"]="suresh";
        System.Console.WriteLine(dictionary["SF3001"]);
        
     
    
    }
}
