using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment5
{
    abstract class DrawApplication
    {
        protected IEnumerable<PointF> PointsCollection;
        public abstract void Draw();
        protected void EshtablishConnection()
        {
            Console.WriteLine("Eshtablishing Connection");
        }
        protected void OpenCanvas()
        {
            Console.WriteLine("Getting Canvas for Drawing");
        }
        protected void SetCordinates(IEnumerable<PointF> coOrdinates)
        {
            this.PointsCollection = coOrdinates;
        }
        protected void CloseCanvas()
        {
            Console.WriteLine("Closing Canvas");
        }
        protected void SaveDrawing()
        {
            Console.WriteLine("Saving Drawing");
        }
        protected void CloseConection()
        {
            Console.WriteLine("Closing Connection");
        }
        public void RunApplication (IEnumerable<PointF> coOrdinates)
        {
            EshtablishConnection();
            OpenCanvas();
            SetCordinates(coOrdinates);
            Draw();
            SaveDrawing();
            CloseCanvas();
            CloseConection();
        }
    }
}