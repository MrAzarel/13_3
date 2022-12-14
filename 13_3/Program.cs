using System;
using System.Threading;
class Program
{
    public static int count = 0;
    static void Main(string[] args)
    {
        Thread thread = new Thread(Increment);
        Thread thread2 = new Thread(Increment);

        thread.Start();
        thread2.Start();    

        void Increment()
        {
            for (int i = 0; i < 10; i++)
            {
                count++;
            }          
        }

        Thread.Sleep(1000);
        Console.WriteLine(count);
    }
}
