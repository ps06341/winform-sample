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
        Dictionary<string, LabelBean> mapCoordinates = new Dictionary<string, LabelBean>();
        LabelBean curLabelBean;
        LabelBean curLabelBeanHover;
        int oldWidthSize = 1;
        int oldHeightSize = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangle(Graphics graphics, string text, int x, int y, int w, int h, Color textColor, Color borderColor, Color backgroundColor, bool isVertical)
        {
            Pen pen = new Pen(borderColor, 6.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);
            SolidBrush sbText = new SolidBrush(textColor);

            Rectangle myRectangle = new Rectangle(x, y, w, h);
            //draw rectangle
            graphics.DrawRectangle(pen, myRectangle);
            //draw background
            graphics.FillRectangle(sb, x, y, w, h);
            int fontSize = 10;

            //draw text
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            if (isVertical == false)
            {
                fontSize = 7;
                drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                //drawFormat.Alignment = StringAlignment.Center;
                //graphics.TranslateTransform(myRectangle.X, myRectangle.Y);
                //graphics.RotateTransform(-90);
            }

            graphics.DrawString(text, new Font("Arial", fontSize), sbText, x, y, drawFormat);

            //graphics.ResetTransform();
            pen.Dispose();
            sb.Dispose();
            sbText.Dispose();
        }

        private void displayPosition(int x, int y, bool isClick)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            foreach (var label in mapCoordinates)
            {
                string position = label.Key;
                LabelBean labelBean = label.Value;

                int[] positions = CommonFunction.getValuePosition(position);
                int xPos = positions[0];
                int yPos = positions[1];
                int[] sizes = CommonFunction.getValuePosition(labelBean.Size);
                int width = sizes[0];
                int height = sizes[1];

                int newX = xPos * (pictureBox1.Size.Width / oldWidthSize);
                int newY = yPos * (pictureBox1.Size.Height / oldHeightSize);
                int newWidth = newX + (width * (pictureBox1.Size.Width / oldWidthSize));
                int newHeight = newY + (height * (pictureBox1.Size.Height / oldHeightSize));

                bool isOutX = x < newX && x > newWidth;
                bool isOutY = y < newY && y > newHeight;
                if (isOutX == true && isOutY == true)
                {
                    drawRectangle(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                    continue;
                }

                if (isClick == true)
                {
                    if (labelBean == curLabelBean)
                    {
                        drawRectangle(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                        curLabelBean = null;
                    }
                    else
                    {
                        drawRectangle(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Red, labelBean.BackgroundCorlor, labelBean.isVertical);
                        if (curLabelBean != null)
                        {
                            int[] curPositions = CommonFunction.getValuePosition(curLabelBean.Position);
                            int xCurPos = curPositions[0];
                            int yCurPos = curPositions[1];
                            int[] curSizes = CommonFunction.getValuePosition(curLabelBean.Size);
                            int curWidth = curSizes[0];
                            int curHeight = curSizes[1];
                            drawRectangle(graphics, curLabelBean.Text, xCurPos, yCurPos, curWidth, curHeight, curLabelBean.TextCorlor, Color.Black, curLabelBean.BackgroundCorlor, curLabelBean.isVertical);
                        }
                        curLabelBean = labelBean;
                    }
                    pictureBox2.Image = bmp;
                    pictureBox1.Image = pictureBox2.Image;
                    continue;
                }

                if (labelBean == curLabelBeanHover)
                {
                    drawRectangle(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                    curLabelBeanHover = null;
                }
                else
                {
                    drawRectangle(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, Color.Green, labelBean.isVertical);
                    if (curLabelBeanHover != null)
                    {
                        int[] curPositions = CommonFunction.getValuePosition(curLabelBeanHover.Position);
                        int xCurPos = curPositions[0];
                        int yCurPos = curPositions[1];
                        int[] curSizes = CommonFunction.getValuePosition(curLabelBeanHover.Size);
                        int curWidth = curSizes[0];
                        int curHeight = curSizes[1];
                        drawRectangle(graphics, curLabelBeanHover.Text, xCurPos, yCurPos, curWidth, curHeight, curLabelBeanHover.TextCorlor, Color.Black, curLabelBeanHover.BackgroundCorlor, curLabelBeanHover.isVertical);
                    }
                    curLabelBeanHover = labelBean;
                }
            }
        }

        bool isLoad = true;
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            if (isLoad == false)
            {
                return;
            }
            isLoad = false;

            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Size sz = pictureBox2.ClientSize;
            oldWidthSize = sz.Width;
            oldHeightSize = sz.Height;

            mapCoordinates = new Dictionary<string, LabelBean>();
            List<LabelBean> labelBeans = CommonFunction.getListLabel();
            foreach (LabelBean labelBean in labelBeans)
            {
                int[] positions = CommonFunction.getValuePosition(labelBean.Position);
                int x = positions[0];
                int y = positions[1];
                int[] sizes = CommonFunction.getValuePosition(labelBean.Size);
                int width = sizes[0];
                int height = sizes[1];
                drawRectangle(graphics, labelBean.Text, x, y, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                pictureBox2.Image = bmp;
                pictureBox1.Image = pictureBox2.Image;
                mapCoordinates.Add(labelBean.Position, labelBean);
            }
            graphics.Dispose();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            int x = p.X;
            int y = p.Y;
            displayPosition(x, y, true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
