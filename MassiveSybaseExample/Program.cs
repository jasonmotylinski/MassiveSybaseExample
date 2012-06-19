using System.Threading;

namespace Massive.Sybase.Example
{
    class Program
    {
        static void Main(string[] args)
        {
           var results = DB.Current.Query("select * from <tablename>");

           System.Console.WriteLine("Massive Results...");
           Thread.Sleep(1000);
           
            foreach (var r in results)
           {
               System.Console.WriteLine(r.<col_name>);
           }

            System.Console.WriteLine("Done!");
            System.Console.ReadKey();
        }
    }
}
