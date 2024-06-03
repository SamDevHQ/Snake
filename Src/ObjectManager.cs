using Snake.Src.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Src
{
    public class ObjectManager
    {
        public Rect rect1 { get; set; }
        private List<GameObject> List { get; set; }
       
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
            rect1 = new Rect(4, 4);
            this.AddObjects(rect1);
        }
    }
}
