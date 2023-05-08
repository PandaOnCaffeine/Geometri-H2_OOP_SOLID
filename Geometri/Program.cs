using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rektangel square1 = new Rektangel(2,2);
            //Console.WriteLine($"Square1 Perimeter {square1.GetPerimeter()}");
            //Console.WriteLine($"Square1 Area {square1.GetArea()}");
            Square s1 = new Square(4);
            s1.GetResult();

            Trapez t1 = new Trapez(10,9,8,9);
            t1.GetResult();

            Rektangel r1 = new Rektangel(10,18);
            r1.GetResult();

            Parallelogram p1 = new Parallelogram(20,2,13);
            p1.GetResult();

            RetVinkelTriangel tri1 = new RetVinkelTriangel(15, 18, 10.1);
            tri1.GetResult();

            Console.ReadLine();
        }
    }
}
