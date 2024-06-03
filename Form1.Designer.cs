using Snake.Src;

namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GameTimer = new System.Windows.Forms.Timer(components);
            InnerFrame = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)InnerFrame).BeginInit();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Interval = 60;
            // 
            // InnerFrame
            // 
            InnerFrame.BackColor = SystemColors.ActiveCaption;
            InnerFrame.Dock = DockStyle.Fill;
            InnerFrame.Location = new Point(0, 0);
            InnerFrame.Name = "InnerFrame";
            InnerFrame.Size = new Size(800, 450);
            InnerFrame.TabIndex = 0;
            InnerFrame.TabStop = false;
            InnerFrame.LoadCompleted += InnerFrame_LoadCompleted;
            InnerFrame.Paint += Game.InnerFrame_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InnerFrame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)InnerFrame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Timer GameTimer;
        private PictureBox InnerFrame;
    }
}
