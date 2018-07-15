using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int score = 0;

        public Form1()
        {
            InitializeComponent();

            gameOverLbl.Visible = false;
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speedLeft;
            ball.Top += speedTop;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speedLeft += 2;
                speedTop += 2;
                speedTop = -speedTop;
                score += 1;
                scoreLabel.Text = score.ToString();
            }

            if(ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameOverLbl.Visible = true;
                Cursor.Show();

            }

            if (ball.Right >= playground.Right)
                speedLeft = -speedLeft;
            if (ball.Top <= playground.Top)
                speedTop = -speedTop;
            if (ball.Left <= playground.Left)
                speedLeft = -speedLeft;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speedLeft = 4;
                speedTop = 4;
                scoreLabel.Text = "0";
                score = 0;
                timer1.Enabled = true;
                gameOverLbl.Visible = false;
            }
        }
    }
}
