using System;

namespace delagate
{
    class Program
    {
        //delegate
        public delegate void CallbackDelegateString(string msg);

        static void Main(string[] args)
        {
            //objekt 
            WorkClass worker1 = new WorkClass();
            //vyvolání objektu s Callback funkcí
            worker1.DoWork(CallbackFunciton);

            //přiřadíme k "CallbackDelegateString" jméno a funkci
            CallbackDelegateString callbackstring = DelegateStringFunction;
            //vyvoláme callback
            callbackstring("mrdko");
        }

        //vypíše i 
        static void CallbackFunciton(int i)
        {
            Console.WriteLine(i);
        }
        //vypíše message
        static void DelegateStringFunction(string message)
        {
            Console.WriteLine(message);
        }
    }
    class WorkClass
    {
        //delegate
        public delegate void CallbackDelegate(int x);

        public void DoWork(CallbackDelegate callback)
        {
            // for loop (nějaká práce)
            for (int i = 0; i <= 9999; i++)
            {
                //
                callback(i);
            }
        }
    }
}
