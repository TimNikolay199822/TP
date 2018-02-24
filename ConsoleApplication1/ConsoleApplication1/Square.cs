using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Square");
            Console.WriteLine("*****");
            Console.WriteLine("*   *");
            Console.WriteLine("*   *");
            Console.WriteLine("*   *");
            Console.WriteLine("*****");
            Console.WriteLine();
        }
    }

}
