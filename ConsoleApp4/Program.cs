using System;
using System.Collections;
using System.Runtime;
using System.Runtime.Remoting;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            list.Add("january");
            list.Add("february");
            list.Add("March");
            list.Add("April");
            list.Add("May");
            list.Add("June");
            list.Add("July");
            list.Add("August");
            list.Add("september");
            list.Add("October");
            list.Add("December");
            
            //show index 2 in arraylist
            Console.WriteLine(list[2]);
            
            // show all months
            for(int items = 0; items < list.Count ; items++)
            {
                Console.WriteLine(list[items]);
            }
            
            // show index 5
            Console.WriteLine(list[5]);

            //insert in first index
            list.Insert(0,"Moja");
            Console.WriteLine(list[0]);
            
            // verify if August exist in arraylist
            Console.WriteLine(list.Contains("August"));
            
            
            //remove object position 3
            list.RemoveAt(2);
            
            // remove object position 7 and modify it & loop to show all objects
            list.RemoveAt(7);
            list.Insert(7,"Aouut");
            for (int i = 0; i < list.Count; i++)
            {
                
                
                Console.WriteLine(list[i]);
                
                
            }
            
            //8- search by elements
            Console.WriteLine(list.Contains("October"));
            
            // 9 - Sort Objects in ArrayList
            
            for (int i = 0; i < list.Count ; i++)
            {
                
                Console.WriteLine(list[i]);
                
                
                
                
            }
            
            Console.WriteLine("=======================");
            
            
            list.Sort();
            for (int item = 0; item < list.Count; item++)
            {
                Console.WriteLine(list[item]);
                
            }
            
            Console.WriteLine("====================================");
            
            ArrayList copylist = new ArrayList();
            
           
           
            copylist = (ArrayList)list.Clone(); 
            



            for (int item = 0; item < copylist.Count; item++)
            {
                Console.WriteLine(copylist[item]);
            }









        }
        
        
        
    }
}