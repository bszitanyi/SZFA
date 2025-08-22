using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Kivetel
{
    public class Storage
    {
        string[,] data;
        int counter;

        static Random r;

        static Storage()
        {
            r = new Random();
        }

        public Storage(int rows, int columns)
        {
            data = new string[rows, columns];
        }

        public void AddItem(string item)
        {
            if (counter < data.Length)
            {
                int i = -1;
                int j = -1;
                do
                {
                    i = r.Next(0, data.GetLength(0));
                    j = r.Next(0, data.GetLength(1));
                } while (data[i, j] != null);
                data[i, j] = item;
                counter++;
            }
            else 
            {
                throw new StorageFullException("The storage was full");
            }
        }

        public string GetItem(string item) 
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] == item)
                    {
                        data[i, j] = null;
                        counter--;
                        return $"{i},{j}";
                    }
                }
            }
            throw new NoItemFoundException($"No item called {item} was in the storage");
        }

        public string GetItem(int i, int j)
        {
            string item = data[i, j];
            if (item != null)
            {
                data[i, j] = null;
                counter--;
                return item;
            }
            throw new NoItemFoundException($"The shelf at {i},{j} was empty");
        }

    }
}
