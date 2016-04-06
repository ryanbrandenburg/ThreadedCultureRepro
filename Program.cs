using System;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().Wait();
        }
        
        static async Task MainAsync()
        {
            CultureInfo.CurrentCulture = new CultureInfo("fr");
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"ThreadId: {threadId} CurrentCulture: {CultureInfo.CurrentCulture}.");
            await Task.Delay(500);
            threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"ThreadId: {threadId} CurrentCulture: {CultureInfo.CurrentCulture}.");
        }
    }
}
