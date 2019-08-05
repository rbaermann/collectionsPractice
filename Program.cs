using System;
using System.Collections.Generic;


namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arr practice
            int[] numArr = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArr = {"Tim","Martin","Nikki","Sara"};
            string[] boolArr = new string[10];
            string True = "true";
            string False = "false";
            for(int i = 0; i < boolArr.Length; i++){
                if(i % 2 == 0){
                    boolArr[i] = True;
                }
                else{
                    boolArr[i] = False;
                }
            }
            Console.WriteLine(numArr[5]);
            Console.WriteLine(nameArr[1]);
            Console.WriteLine(boolArr[9]);

            // List practice
            List<string> iceCream = new List<string>();
            iceCream.Add("vanilla");
            iceCream.Add("chocolate");
            iceCream.Add("strawberry");
            iceCream.Add("coffee");
            iceCream.Add("rocky road");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove(iceCream[2]);
            Console.WriteLine(iceCream.Count);

            //Dict practice
            Dictionary<string, string> favIceCream = new Dictionary<string, string>();
            Random rand = new Random();
            for(int i = 0; i < nameArr.Length; i++){
                int j = rand.Next(4);
                favIceCream.Add(nameArr[i], iceCream[j]);
            }
            foreach(KeyValuePair<string, string> entry in favIceCream){
                Console.WriteLine(entry.Key + "'s favorite ice cream is " + entry.Value);
            }
        }
    }
}
