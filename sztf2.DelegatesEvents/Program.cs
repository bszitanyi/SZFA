using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sztf2.DelegatesEvents
{
    internal class Program
    {
        /*public class MyStorage : Storage
        {
            public override void ItemDeleted(int index)
            {
                Console.WriteLine($"Elem törölve a/az {index}. helyről.");
            }

            public override void ItemInserted(int index)
            {
                
                Console.WriteLine($"Elem elhelyezve a/az {index}. helyre");
            }
        }

        public class MyDisplay : IStorageDisplay
        {
            public void ItemDeleted(int index)
            {
                Console.WriteLine($"Elem törölve a/az {index}. helyről.");
            }

            public void ItemInserted(int index)
            {
                Console.WriteLine($"Elem elhelyezve a/az {index}. helyre");
            }
        }*/

        static void ItemInsetedEvent(int index)
        {
            Console.WriteLine($"Elem elhelyezve a/az {index}. helyre");
        }

        static void ItemDeletedEvent(int index)
        {
            Console.WriteLine($"Elem törölve a/az {index}. helyről.");
        }

        public delegate void ToConsole(string text);

        public ToConsole Writer;

        static void TodayMessage(string message)
        { 
            Console.WriteLine(message);
        }

        static void TomorrowMessage(string message)
        { 
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.ItemInserted += ItemInsetedEvent;
            storage.ItemDeleted += ItemDeletedEvent;

            storage.AddItem("Alma");
            storage.AddItem("Körte");
            storage.AddItem("Bélgázszippantó kézi kalapácsot");

            storage.DeleteItem("Körte");

            Action<string> kiiro = message => Console.WriteLine(message);
            Action<string> masikkiiro = a => Console.WriteLine("asd");

            
            
        }

        //Sorozatszámítás tétele delegáltakkal
        public int Summation(int initialValue, Func<int, int, int> operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException();
            }
            int result = initialValue;
            foreach (int item in array)
            {
                result = operation(result, item);
            }
            return result;
        }
    }
}
