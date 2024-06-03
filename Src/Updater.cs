using static Snake.Src.Objects.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Src.Objects;

namespace Snake.Src
{
    public class Updater
    {
        #region Ctor & Fields

        #endregion

        public void Update(float deltaTime)
        {
            foreach (GameObject go in Game.ObjectManager.GetObjects())
            {
                go.Update(deltaTime);
            }
        }
    }
}
