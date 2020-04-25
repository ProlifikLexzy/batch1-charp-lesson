using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.HelloWorld.Delegates
{
    public delegate string NotificationDelegate(string message);
    public delegate void NotificationDelegate<T>(T message) where T:class;
}
