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
        float oldWidthSize = 1f;
        float oldHeightSize = 1f;
        bool isLoad = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangleAsLabel(Graphics graphics, string text, int x, int y, int w, int h, Color textColor, Color borderColor, Color backgroundColor, bool isVertical)
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
            if (isVertical == true)
            {
                fontSize = 7;
                //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;.
                drawFormat.Alignment = StringAlignment.Center;
                drawFormat.LineAlignment= StringAlignment.Center;
                //graphics.TranslateTransform(myRectangle.X, myRectangle.Y);
                //graphics.TranslateTransform(-17, 113);
                graphics.TranslateTransform(0, 0);
                graphics.RotateTransform(45);
            }

            graphics.DrawString(text, new Font("Arial", fontSize), sbText, x, y, drawFormat);

            graphics.ResetTransform();
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

                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                int xPos = positions[0];
                int yPos = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                int width = sizes[0];
                int height = sizes[1];

                bool isOut = checkPointerIsOutLabels(x, y, labelBean);
                if (isOut == true)
                {
                    drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                    continue;
                }

                if (isClick == true)
                {
                    if (labelBean == curLabelBean)
                    {
                        drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                        curLabelBean = null;
                    }
                    else
                    {
                        drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Red, labelBean.BackgroundCorlor, labelBean.isVertical);
                        if (curLabelBean != null)
                        {
                            drawLabel(graphics, curLabelBean);
                        }
                        curLabelBean = labelBean;
                    }
                    pictureBox2.Image = bmp;
                    pictureBox1.Image = pictureBox2.Image;
                    continue;
                }

                if (labelBean == curLabelBeanHover)
                {
                    drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
                    curLabelBeanHover = null;
                }
                else
                {
                    drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, Color.Green, labelBean.isVertical);
                    if (curLabelBeanHover != null)
                    {
                        drawLabel(graphics, curLabelBeanHover);
                    }
                    curLabelBeanHover = labelBean;
                }
                pictureBox2.Image = bmp;
                pictureBox1.Image = pictureBox2.Image;
            }
        }

        private bool checkPointerIsOutLabels(int Ox, int Oy, LabelBean label)
        {
            int[] positions = CommonFunction.getValuesAsPair(label.Position);
            int xPos = positions[0];
            int yPos = positions[1];
            int[] sizes = CommonFunction.getValuesAsPair(label.Size);
            int width = sizes[0];
            int height = sizes[1];

            float deltaX = (pictureBox1.Size.Width / oldWidthSize);
            float deltaY = (pictureBox1.Size.Height / oldHeightSize);
            float newX = xPos * deltaX;
            float newY = yPos * deltaY;
            float newWidth = newX + (width * deltaX);
            float newHeight = newY + (height * deltaY);

            bool isOutX = Ox < newX || Ox > newWidth;
            bool isOutY = Oy < newY || Oy > newHeight;
            if (isOutX == true || isOutY == true)
            {
                return true;
            }
            return false;
        }

        private void drawLabel(Graphics graphics, LabelBean labelBean)
        {
            int[] curPositions = CommonFunction.getValuesAsPair(labelBean.Position);
            int xCurPos = curPositions[0];
            int yCurPos = curPositions[1];
            int[] curSizes = CommonFunction.getValuesAsPair(labelBean.Size);
            int curWidth = curSizes[0];
            int curHeight = curSizes[1];
            drawRectangleAsLabel(graphics, labelBean.Text, xCurPos, yCurPos, curWidth, curHeight, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
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
                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                int x = positions[0];
                int y = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                int width = sizes[0];
                int height = sizes[1];
                drawRectangleAsLabel(graphics, labelBean.Text, x, y, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.isVertical);
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
