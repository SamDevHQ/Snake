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
    public class Rect
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
            //bodies = new List<Body>();
            //for(int i = 0; i < length; i++)
            //{
            //    Body body = new Body(3, 3);
            //    bodies.Add(body);
            //}
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
                switch (Direction)
                {
                    case Direction.UP:
                        Y -= 1;
                        if (Y <= 1)
                        {
                            Direction = Direction.DOWN;
                        }
                        break;
                    case Direction.DOWN:
                        Y += 1;
                        if (Y >= Game.Renderer.GridColumns)
                        {
                            Direction = Direction.UP;
                        }
                        break;
                    case Direction.LEFT:
                        X -= 1;
                        if (X <= 1)
                        {
                            Direction = Direction.RIGHT;
                        }
                        break;
                    case Direction.RIGHT:
                        X += 1;
                        if (X >= Game.Renderer.GridRows)
                        {
                            Direction = Direction.LEFT;
                        }
                        break;
                }
                stackedDelta = 0;
            }

        }
    }
}
