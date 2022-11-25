using System;
using System.Reflection;

namespace GrandChildLib
{
    public class GrandChild
    {
        public GrandChild()
        {

        }

        public void Call()
        {
            Console.WriteLine($"GrandChild.Call(){Assembly.GetExecutingAssembly().GetName().Version}");
        }
    }
}
