using Snake.Src;
using Snake.Src.Objects;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Game.Initialize(this);
            //this.GameTimer.Enabled = true;
            //this.KeyDown += objectManager.Form1_KeyDown;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            Game.InputManager.Form1_KeyDown(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game.GameLoop.Start();
        }

        private void InnerFrame_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
        }
    }
}
