using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class SnakeBody
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Direction Direction { get; set; }
        public float SpeedFactor { get; set; }

        public SnakeBody(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.SpeedFactor = 5;
        }

        public void Render(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.FromArgb(0, 255, 0));
            graphics.FillRectangle(brush, X * 50 - 50, Y * 50 - 50, 50, 50);
        }
    }
}
