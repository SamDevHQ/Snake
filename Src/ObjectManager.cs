using Snake.Src.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src
{
    public class ObjectManager
    {
        public List<GameObject> List { get; set; }
        public SnakeTotal snake { get; set; }
        public CollectibleObjects collectible { get; set; }

        public ObjectManager() 
        {
            List = new List<GameObject>();
        }

        public List<GameObject> GetObjects()
        {
            return List;
        }

        public void AddObjects(GameObject rect)
        {
            List.Add(rect);
        }

        public void Initialize()
        {
            collectible = new CollectibleObjects();
            snake = new SnakeTotal();
            this.AddObjects(collectible);
            this.AddObjects(snake);
        }
    }
}
