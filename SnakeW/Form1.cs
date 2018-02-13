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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics g = Graphics.FromHwnd(Handle);
            g.DrawRectangle(SystemPens.ActiveBorder, new Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20));
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

            
        }
        private void writeCellSnake()
        {
            foreach (var item in snake.bodySnake)
            {
                item.X[]
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
