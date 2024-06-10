using Snake.Src.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.Src
{
    public static class Game
    {
        public static Form1 Frame { get; set; }
        public static PictureBox InnerFrame => Frame.Controls["InnerFrame"] as PictureBox;
        public static Renderer Renderer { get; set; }
        public static ObjectManager ObjectManager { get; set; }
        public static GameLoop GameLoop { get; set; }
        public static Updater Updater { get; set; }
        public static InputManager InputManager { get; set; }
        public static void Initialize(Form1 form)
        {
            Frame = form;
            Frame.Name = "Snake";
            //Frame.FormBorderStyle = FormBorderStyle.None;
            //Frame.WindowState = FormWindowState.Maximized;
            Renderer = new Renderer();
            ObjectManager = new ObjectManager();
            ObjectManager.Initialize();
            GameLoop = new GameLoop();
            Updater = new Updater();
            InputManager = new InputManager();
        }

        public static void ElementClick(object sender, EventArgs e)
        {
           
        }

        static int x = 20;

        public static void InnerFrame_Paint(object sender, PaintEventArgs e)
        {

            if (!GameLoop.Running)
                return;
            Graphics Graphics = e.Graphics;
            x++;
            Renderer.Render(Graphics);
        }
    }
}
