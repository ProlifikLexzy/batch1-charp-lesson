using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.HelloWorld.Delegates
{
    public class EmailNotification<T>
    {
        public void SendSingleMessage(string message)
        {
            Console.WriteLine("Single {0}", message);
        }

        public static void SingleBulkMessage(T message)
        {
            Console.WriteLine("Bulk {0}", message);
        }
    }
}
