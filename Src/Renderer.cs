using Snake.Src.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.Src
{
    public class Renderer
    {
        public int GridSize = 50;
        public int GridRows = 20;
        public int GridColumns = 10;

        public void Render(Graphics e) 
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0));
            List<GameObject> list = Game.ObjectManager.GetObjects();

            //Grid rows
            Pen gridColor = new Pen(Color.FromArgb(128, 128, 128));
            for (int i = 0; i <= GridRows; i++) 
            {
                e.DrawLine(gridColor, i * 50, 0, i * 50, GridColumns * 50);
            }

            //Grid Columns
            for (int i = 0;i <= GridColumns; i++) 
            {
                e.DrawLine(gridColor, 0, i * 50, GridRows * 50, i * 50);
            }

            foreach (GameObject obj in list) 
            {
                obj.Render(e);
            }

        }
    }
}
