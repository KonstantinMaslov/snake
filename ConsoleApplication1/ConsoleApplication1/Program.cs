using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(1, 10, 8, '-');
            line.Draw();
            VerttikalLine line1 = new VerttikalLine(1, 10, 11, '|');
            line1.Draw();

            Console.ReadLine();
                                 
        }
    }
}
