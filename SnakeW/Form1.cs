using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeW
{
    public partial class Form1 : Form
    {
        Snake snake;
        public Form1()
        {
            InitializeComponent();
            Text = "Snake";
            BackColor=Color.YellowGreen;
            Size = new Size(GameField.widthGameField * 16,GameField.heightGameField * 16);
            StartPosition = FormStartPosition.CenterScreen;
            initGame();
            
        }

        public void initGame()
        {
            snake = new Snake();

           Timer timer1 = createTimer();
            timer1.Start();
            
        }
        private Timer createTimer()
        {
            System.Windows.Forms.Timer timerKeepTrack = new System.Windows.Forms.Timer();
            timerKeepTrack.Interval = 1000;
            timerKeepTrack.Tick+= new EventHandler(moveSnake_Tick);
            
            return timerKeepTrack;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MoveSnake.moveDown(snake);
            MoveSnake.moveLeft(snake);
            Invalidate();

            //Graphics g = Graphics.FromHwnd(Handle);
            //g.DrawRectangle(SystemPens.ActiveBorder, new Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //const string HELLO_WORLD = "Hello World!!!";

            //SizeF messageSize = e.Graphics.MeasureString(HELLO_WORLD, Font);

            //PointF p = new PointF((ClientSize.Width - messageSize.Width) / 2, (ClientSize.Height - messageSize.Height) / 2);
            //PointF[] points = { new PointF(30, 30) , new PointF(60, 60), new PointF(30, 60), new PointF(60, 30) };
            //e.Graphics.DrawString(HELLO_WORLD, Font, SystemBrushes.WindowText, p);
            //// e.Graphics.DrawLine(SystemPens.WindowText, 10, 10, 20, 20);
            //e.Graphics.FillPolygon(SystemBrushes.Window, points);
            writeCellSnake(e);
            
        }

        private void writeCellSnake(PaintEventArgs e)
        {
            foreach (var item in snake.bodySnake)
            {
                PointF[] pointsOfSnake = { new PointF(item.X, item.Y),new PointF(item.X + 16, item.Y),new PointF(item.X+16, item.Y+16), new PointF(item.X , item.Y+16) };
                e.Graphics.FillPolygon(SystemBrushes.Window, pointsOfSnake);
            }
        }

        private void moveSnake_Tick(object sender, System.EventArgs e)
        {
            //foreach (var item in snake.bodySnake)
            //{
            //    item.X += 16;
            //    //item.Y += 16;
            //}
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if(e.KeyCod == e.KeyChar.)
            //button1.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               
            }
        }
    }
}
