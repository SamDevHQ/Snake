using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class Apple
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Apple(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Render(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            graphics.FillRectangle(brush, X * 50 - 50, Y * 50 - 50, 50, 50);
        }
    }
}
