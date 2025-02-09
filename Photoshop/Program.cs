using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photoshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (typeof(Polygon).BaseType != typeof(Figure))
                throw new Exception("класс Polygon должен быть наследовал от Figure");

            Polygon polygon = new Polygon();
            polygon.Layer = 0;
            polygon.EdgeThickness = 2.4;
            polygon.EdgeColor = "красный";
            polygon.FillColor = "белый";
            polygon.Points = new List<Point>() {
    new Point() {
        X_Position = 5.6,
        Y_Position = 3.4
    }, new Point(){
        X_Position = 6.7,
        Y_Position = 2.4
    }, new Point() {
        X_Position = 5.1,
        Y_Position = 2.4
    },new Point() {
        X_Position = 2.2,
        Y_Position = 7.1
    }
};
            foreach (Point p in polygon.Points)
            {
                Console.WriteLine($"X:{p.X_Position} Y:{p.Y_Position}");
            }
            Console.WriteLine($"Слой:{polygon.Layer}, Цвет границ:{polygon.EdgeColor}, Толщина границ:{polygon.EdgeThickness}, Цвет заливки:{polygon.FillColor}");
            //X:5.6 Y:3.4
            //X:6.7 Y:2.4
            //X:5.1 Y:2.4
            //X:2.2 Y:7.1
            //Слой:0, Цвет границ:красный, Толщина границ:2.4, Цвет заливки:белый
        }
        public static void ShowVerticalEdges(Edge[] edges)
        {
            foreach (Edge edge in edges)
            {
                if(edge.FirstPoint.X_Position == edge.SecondPoint.X_Position)
                {
                    double x = edge.FirstPoint.X_Position;
                    double y = edge.FirstPoint.Y_Position;
                    double x1 = edge.SecondPoint.X_Position;
                    double y1 = edge.SecondPoint.Y_Position;
                    Console.WriteLine($"{x} {y} {x1} {y1}");
                }
            }
        }
    }
}
