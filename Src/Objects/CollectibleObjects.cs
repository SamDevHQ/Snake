using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class CollectibleObjects : GameObject
    {
        public float SpeedFactor { get; set; }
        public Apple apple { get; set; } = new Apple(6, 6);

        public CollectibleObjects()
        {
            this.SpeedFactor = 1;
        }

        public override void Render(Graphics graphics)
        {
            apple.Render(graphics);
        }
        public override void Update(float deltatime)
        {
            if(Game.ObjectManager.snake.snakeHead.X == apple.X && Game.ObjectManager.snake.snakeHead.Y ==  apple.Y) 
            {
                RelocateApple();
                Game.ObjectManager.snake.onApple = true;
            }
        }
        public void RelocateApple()
        {
            Random rnd = new Random();

            int x = rnd.Next(1, Game.Renderer.GridRows + 1);
            int y = rnd.Next(1, Game.Renderer.GridColumns + 1);
            apple.X = x;
            apple.Y = y;
        }
    }

}
