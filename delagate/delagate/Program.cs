using System;

namespace delagate
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkClass worker1 = new WorkClass();
            worker1.DoWork(Callback);
        }
        static void Callback(int i)
        {
            Console.WriteLine(i);
        }

    }
    class WorkClass
    {
        public delegate void CallbackDelegate(int x);
        public void DoWork(CallbackDelegate callbackdelegate)
        {
            for (int i = 0; i < 999999; i++)
            {
                callbackdelegate(i);
            }
        }

    }
}
