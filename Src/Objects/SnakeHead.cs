using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class SnakeHead
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; } = Direction.RIGHT;

        public SnakeHead(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Render(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 255));
            graphics.FillRectangle(brush, X * 50 - 50, Y * 50 - 50, 50, 50);
            graphics.DrawString($"{X}, {Y}", new Font(FontFamily.GenericMonospace, 14), Brushes.Black, new PointF(X * 50 - 50, Y * 50 - 50));
        }

        public void Update(float deltatime)
        {
            switch (Direction)
            {
                case Direction.UP:
                    Y -= 1;
                    if (Y <= 0)
                    {
                        Game.GameLoop.Rendering = false;
                    }
                    break;
                case Direction.DOWN:
                    Y += 1;
                    if (Y >= Game.Renderer.GridColumns + 1)
                    {
                        Game.GameLoop.Rendering = false;
                    }
                    break;
                case Direction.LEFT:
                    X -= 1;
                    if (X <= 0)
                    {
                        Game.GameLoop.Rendering = false;
                    }
                    break;
                case Direction.RIGHT:
                    X += 1;
                    if (X >= Game.Renderer.GridRows + 1)
                    {
                        Game.GameLoop.Rendering = false;
                    }
                    break;
            }

            foreach (SnakeBody body in Game.ObjectManager.snake.bodies)
            {
                if (X == body.X && Y == body.Y)
                {
                    Game.GameLoop.Rendering = false;
                }
            }
        }
    }
}
