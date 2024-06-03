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
                Game.ObjectManager.rect1.Direction = Enums.Direction.UP;
            }
            if (e.KeyCode == Keys.A)
            {
                Game.ObjectManager.rect1.Direction = Enums.Direction.LEFT;
            }
            if (e.KeyCode == Keys.S)
            {
                Game.ObjectManager.rect1.Direction = Enums.Direction.DOWN;
            }
            if (e.KeyCode == Keys.D)
            {
                Game.ObjectManager.rect1.Direction = Enums.Direction.RIGHT;
            }
        }
    }
}
