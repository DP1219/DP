using System;
namespace dp
{
 public class Dp
 {
   public staic Void Main()
   {
    		int a;
            string ename;
            Console.WriteLine("Enter Your Name:");
            ename = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations Mr/Ms {0}  on your {1} th Birthday", ename, a);
            Console.ReadKey();

     }
   }
}