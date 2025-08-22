using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Kivetel
{
    public class StorageFullException : Exception
    {
        public StorageFullException(string message) : base(message) { }
    }

    public class NoItemFoundException : Exception
    {
        public NoItemFoundException(string message) : base(message) { }
    }
}
