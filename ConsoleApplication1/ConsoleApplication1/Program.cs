using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine line = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine line3 = new HorizontalLine(0, 78, 24, '-');
            VerttikalLine line2 = new VerttikalLine(0, 24, 0, '|');
            VerttikalLine line1 = new VerttikalLine(0, 24, 78, '|');
            line2.Draw();
            line1.Draw();
            line.Draw();
            line3.Draw();
            
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            
                                 
        }
    }
}
