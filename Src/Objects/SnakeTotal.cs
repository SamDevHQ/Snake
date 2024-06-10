using Snake.Src.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src.Objects
{
    public class SnakeTotal : GameObject
    {
        public float SpeedFactor { get; set; }
        public int Length { get; set; }
        public List<SnakeBody> bodies { get; set; } = new List<SnakeBody>();
        public SnakeHead snakeHead { get; set; } = new SnakeHead(8, 4);
        public Boolean onApple { get; set; } = false;
        public SnakeTotal()
        {
            this.SpeedFactor = 12;
            this.Length = 1;

            for (int i = Length; i >0; i--)
            {
                addSnakeBodys(snakeHead.X - i, snakeHead.Y);
            }
        }

        public override void Render(Graphics graphics)
        {
            snakeHead.Render(graphics);
            foreach (SnakeBody body in bodies)
            {
                body.Render(graphics);
            }
        }
        private float stackedDelta;
        public override void Update(float deltatime)
        {
            stackedDelta += deltatime * SpeedFactor;
            if (stackedDelta >= 1)
            {          
                if(onApple == false)
                {
                bodies.RemoveAt(bodies.Count()-1);
                } else 
                {
                    onApple = false;
                }
                addSnakeBodys(snakeHead.X, snakeHead.Y);
                snakeHead.Update(deltatime);

                stackedDelta = 0;
            }

        }
    public void addSnakeBodys(int x, int y)
    {
        SnakeBody snakeBody = new SnakeBody(x, y);
            bodies.Insert(0, snakeBody);
           
        }
    }

}
