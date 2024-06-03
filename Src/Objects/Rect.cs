using Microsoft.VisualBasic.FileIO;
using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.Src.Objects
{
    public class Rect : GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        public float SpeedFactor { get; set; }


        public Rect(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.SpeedFactor = 5;
        }

        public override void Render(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 0, 0));
            graphics.FillRectangle(brush, X * 50 - 50, Y * 50 - 50, 50, 50);
            graphics.DrawString($"{X}, {Y}", new Font(FontFamily.GenericMonospace, 14), Brushes.Black, new PointF (X * 50 - 50, Y * 50 -50));
        }

        private float stackedDelta;
        public override void Update(float deltatime)
        {
            stackedDelta += deltatime * SpeedFactor;
            if (stackedDelta >= 1) 
            {
                if(Direction == Direction.RIGHT) 
                { 
                    X += 1; 
                    if (X >= Game.Renderer.GridRows)
                    {
                        Direction = Direction.LEFT;
                    }
                }
                else if(Direction == Direction.LEFT)
                {
                    X-= 1;
                    if (X <= 1)
                    {
                        Direction = Direction.RIGHT;
                    }
                }
                else if(Direction == Direction.DOWN)
                {
                    Y += 1;
                    if (Y >= Game.Renderer.GridColumns)
                    {
                        Direction = Direction.UP; 
                    }
                }
                else if(Direction == Direction.UP)
                {
                    Y -= 1;
                    if(Y <= 1)
                    {
                        Direction = Direction.DOWN;
                    }
                }

                stackedDelta = 0;
            }
            
        }
    }
}
