using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<PointF> Points = new List<PointF>();
            DrawApplication DrawTriangle = new Triangle();
            DrawTriangle.RunApplication(Points);
            DrawApplication DrawSquare = new Square();
            DrawSquare.RunApplication(Points);
            DrawApplication DrawCircle = new Circle();
            DrawCircle.RunApplication(Points);
            Console.ReadLine();
        }
    }
}
