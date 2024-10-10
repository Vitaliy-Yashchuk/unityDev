using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle:Shape
    {
        float hight {  get; set; }
        float width { get; set; }
        public Rectangle(float hight, float width)
        {
            this.hight = hight;
            this.width = width;
            GetArea();
        }

        public override float GetArea()
        {
            float res = width * hight;
            Console.WriteLine($"Resault: {res}");
            return res;
        }
    }
}
