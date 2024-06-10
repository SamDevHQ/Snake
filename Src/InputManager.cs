using Snake.Src.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src
{
    public class InputManager
    {
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if(Game.ObjectManager.snake.snakeHead.Direction != Enums.Direction.DOWN)
                {
                    Game.ObjectManager.snake.snakeHead.Direction = Enums.Direction.UP;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (Game.ObjectManager.snake.snakeHead.Direction != Enums.Direction.RIGHT)
                {
                    Game.ObjectManager.snake.snakeHead.Direction = Enums.Direction.LEFT;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (Game.ObjectManager.snake.snakeHead.Direction != Enums.Direction.UP)
                {
                    Game.ObjectManager.snake.snakeHead.Direction = Enums.Direction.DOWN;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (Game.ObjectManager.snake.snakeHead.Direction != Enums.Direction.LEFT)
                {
                    Game.ObjectManager.snake.snakeHead.Direction = Enums.Direction.RIGHT;
                }
            }
        }
    }
}
