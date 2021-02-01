using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace win_form
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        //float panelWidth = 1;
        //float panelHeight = 1;
        bool wasReturned = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (wasReturned == true)
            {
                return;
            }

            wasReturned = true;
            Graphics graphics = panel1.CreateGraphics();
            Size sz = panel1.ClientSize;
            //int xTemp = 10;
            //int yTemp = 10;
            //float increaseX = 1;
            //float increaseY = 1;
            //if (panelWidth != 1 && panelHeight != 1)
            //{
            //    increaseX = sz.Width / panelWidth;
            //    increaseY = sz.Height / panelHeight;
            //}

            drawRectangle(graphics, sz.Width / 2, sz.Height / 2, 30, 23, Color.Black, Color.Red, sz);
            //for (int i = 0; i < 10; i++)
            //{
            //    //drawRectangle(graphics, i * 5 + xTemp * increaseX, i * 5 + yTemp * increaseY, 20 * increaseX, 13 * increaseY, Color.Black, Color.Red, sz);
            //    //xTemp = i * 5 + xTemp;
            //    //yTemp = i * 5 + yTemp;
            //}
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //Point p = new Point(e.X, e.Y);
            //x = p.X;
            //y = p.Y;
            //panel1.Invalidate();
        }

        private void drawRectangle(Graphics graphics, int x, int y, int w, int h, Color borderColor, Color backgroundColor, Size sz)
        {
            Pen pen = new Pen(borderColor, 6.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);

            Rectangle myRectangle = new Rectangle(x, y, w, h);
            graphics.DrawRectangle(pen, myRectangle);
            graphics.FillRectangle(sb, x, y, w, h);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            
            //Graphics graphics = panel1.CreateGraphics();
            //Size sz = panel1.ClientSize;
            //int xTemp = 10;
            //int yTemp = 10;
            //float increaseX = 1;
            //float increaseY = 1;
            //if (panelWidth != 1 && panelHeight != 1)
            //{
            //    increaseX = sz.Width / panelWidth;
            //    increaseY = sz.Height / panelHeight;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    drawRectangle(graphics, i * 5 + xTemp * increaseX, i * 5 + yTemp * increaseY, 20 * increaseX, 13 * increaseY, Color.Black, Color.Red, sz);
            //    xTemp = i * 5 + xTemp;
            //    yTemp = i * 5 + yTemp;
            //}
            //Graphics graphics = panel1.CreateGraphics();
            //Size sz = panel1.ClientSize;
            //drawRectangle(graphics, sz.Width / 2, sz.Height / 2, 30, 23, Color.Black, Color.Red, sz);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }
    }
}
