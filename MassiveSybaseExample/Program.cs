using System.Threading;

namespace Massive.Sybase.Example
{
    class Program
    {
        static void Main(string[] args)
        {
           var users = DB.Current.Query("select * from user_info");

           System.Console.WriteLine("Massive Results...");
           Thread.Sleep(4000);
           
            foreach (var u in users)
           {
               System.Console.WriteLine(u.user_id);
           }

            System.Console.WriteLine("Done!");
            System.Console.ReadKey();
        }
    }
}
