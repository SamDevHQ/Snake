using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class GreenRect : GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GreenRect(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void Render(Graphics graphics)
        {
            Pen pen = new Pen(Color.FromArgb(0, 255, 0));
            graphics.DrawRectangle(pen, X * 50 + 12, Y * 50 + 12, 50/2, 50/2);
        }

        public override void Update(float deltatime)
        {
            
        }
    }
}
