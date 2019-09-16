using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();
            // creeat a class that listens for when the list is changed
            EventListener listener = new EventListener(list);


            list.Add("hello");
            list.Add("world");

            for (int i = 0; i < list.arraySize; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Clear();
            listener.Detatch();

            

            Console.ReadKey();
        }
    }
}
