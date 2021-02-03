using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_form;

namespace sample2_WinForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, win_form.LabelBean> mapCoordinates = new Dictionary<string, LabelBean>();
        //current Label was choosen
        LabelBean curLabelBean;
        //stop paint event again
        int colMarginDefault = 85;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangleAsLabel(Graphics graphics, string text, int x, int y, int w, int h,
            Color textColor, Color borderColor, Color backgroundColor, int rotate, int col)
        {
            Pen pen = new Pen(borderColor, 6.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);
            SolidBrush sbText = new SolidBrush(textColor);

            Rectangle myRectangle = new Rectangle(x, y, w, h);
            //draw rectangle
            graphics.DrawRectangle(pen, myRectangle);
            //draw background
            graphics.FillRectangle(sb, x, y, w, h);
            float fontSize = 28;

            //draw text
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            SizeF stringSize = new SizeF();
            string fontName = "sans-serif";
            Font font = new Font(fontName, fontSize);
            stringSize = graphics.MeasureString(text, font);

            //get font size by text length
            float rectangleTextWidth = w;
            float rectangleTextHeight = h;
            if (rotate != 0)
            {
                rectangleTextWidth = h;
                rectangleTextHeight = w;
            }

            while (stringSize.Width >= rectangleTextWidth)
            {
                fontSize -= 0.5f;
                if (fontSize <= 0)
                {
                    font = new Font(fontName, 0.5f);
                    break;
                }
                font = new Font(fontName, fontSize);
                stringSize = graphics.MeasureString(text, font);
            }

            while (stringSize.Height >= rectangleTextHeight)
            {
                fontSize -= 0.5f;
                if (fontSize <= 0)
                {
                    font = new Font(fontName, 0.5f);
                    break;
                }
                font = new Font(fontName, fontSize);
                stringSize = graphics.MeasureString(text, font);
            }

            drawFormat.Alignment = StringAlignment.Far;
            drawFormat.LineAlignment = StringAlignment.Far;

            //rotate for text
            float strXPos = x + h + stringSize.Width / 2;
            float strYPos = y + w / 2;
            if (rotate != 0)
            {
                drawFormat.Alignment = StringAlignment.Near;
                drawFormat.LineAlignment = StringAlignment.Near;
                if (rotate == 270)
                {
                    graphics.TranslateTransform(x + w / 4, y + h);
                }
                else if (rotate == 180)
                {
                    //graphics.TranslateTransform(x + w / 4, y + h - 3);
                }
                else if (rotate == 90)
                {
                    graphics.TranslateTransform(x + w / 4 * 3, y + 3);
                }

                graphics.RotateTransform(rotate);

                strXPos = 0;
                strYPos = 0;
            }

            graphics.DrawString(text, font, sbText, strXPos, strYPos, drawFormat);

            graphics.ResetTransform();
            pen.Dispose();
            sb.Dispose();
            sbText.Dispose();
        }

        private void displayPosition(Graphics graphics, int x, int y, bool isClick)
        {
            //graphics.Clear(Color.White);
            Size sz = pictureBox1.ClientSize;
            Size oldSz = pictureBox2.ClientSize;

            LabelBean lbChoose = null;
            float xPos = 0;
            float yPos = 0;
            float width = 0;
            float height = 0;
            float deltaX = (float)sz.Width / (float)oldSz.Width;
            float deltaY = (float)sz.Height / (float)oldSz.Height;

            foreach (var label in mapCoordinates)
            {
                string position = label.Key;
                LabelBean labelBean = label.Value;

                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                xPos = positions[0];
                yPos = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                width = sizes[0];
                height = sizes[1];

                xPos *= deltaX;
                xPos += (labelBean.Col * colMarginDefault) * deltaX;
                yPos *= deltaY;
                width *= deltaX;
                height *= deltaY;

                //check current pointer is belong to label
                bool isOut = checkPointerIsOutLabels(x, y, deltaX, deltaY, labelBean);
                if (isOut == true)
                {
                    drawRectangleAsLabel(graphics, labelBean.Text, (int)xPos, (int)yPos, (int)width, (int)height, labelBean.TextCorlor, Color.Black,
                        labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                    continue;
                }
                lbChoose = labelBean;
            }

            if (lbChoose != null)
            {
                int[] positions = CommonFunction.getValuesAsPair(lbChoose.Position);
                xPos = positions[0];
                yPos = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(lbChoose.Size);
                width = sizes[0];
                height = sizes[1];

                xPos *= deltaX;
                xPos += (lbChoose.Col * colMarginDefault) * deltaX;
                yPos *= deltaY;
                width *= deltaX;
                height *= deltaY;

                if (isClick == true)
                {
                    //case: label pointer was choosen => do nothing
                    Color borderColor = Color.Black;
                    if (lbChoose == curLabelBean)
                    {
                        curLabelBean = null;
                    }
                    else
                    {
                        //case: label pointer different than label pointer was choosen => do something
                        borderColor = Color.Red;
                        curLabelBean = lbChoose;
                    }
                    drawRectangleAsLabel(graphics, lbChoose.Text, (int)xPos, (int)yPos, (int)width, (int)height,
                        lbChoose.TextCorlor, borderColor, lbChoose.BackgroundCorlor, lbChoose.Rotate, lbChoose.Col);
                }
                //drawDataForDisplaying(bmp);
                return;
            }
        }
        private bool checkPointerIsOutLabels(int Ox, int Oy, float deltaX, float deltaY, LabelBean label)
        {
            int[] positions = CommonFunction.getValuesAsPair(label.Position);
            int xPos = positions[0];
            int yPos = positions[1];
            int[] sizes = CommonFunction.getValuesAsPair(label.Size);
            int width = sizes[0];
            int height = sizes[1];

            //calculate delta for pointer was choosen to be belong to on old coordinates
            float newX = xPos * deltaX;
            newX += (label.Col * colMarginDefault) * deltaX;
            float newY = yPos * deltaY;
            float newWidth = newX + (width * deltaX);
            float newHeight = newY + (height * deltaY);

            //if out onyl one => not to be belong to label's old coordinates
            bool isOutX = Ox < newX || Ox > newWidth;
            bool isOutY = Oy < newY || Oy > newHeight;
            if (isOutX == true || isOutY == true)
            {
                return true;
            }
            return false;
        }

        private void drawDataForDisplaying(Bitmap bmp)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = null;
            if (e != null)
            {
                graphics = e.Graphics;
            }
            else
            {
                graphics = pictureBox1.CreateGraphics();
            }
            graphics.Clear(Color.White);
            Invalidate();
            Size sz = pictureBox1.ClientSize;
            Size oldSz = pictureBox2.ClientSize;

            mapCoordinates = new Dictionary<string, LabelBean>();
            List<LabelBean> labelBeans = CommonFunction.getListLabel();
            foreach (LabelBean labelBean in labelBeans)
            {
                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                float x = positions[0];
                float y = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                float width = sizes[0];
                float height = sizes[1];

                float deltaX = (float)sz.Width / (float)oldSz.Width;
                float deltaY = (float)sz.Height / (float)oldSz.Height;

                float oldX = x;
                x *= deltaX;
                x += (labelBean.Col * colMarginDefault) * deltaX;
                y *= deltaY;
                width *= deltaX;
                height *= deltaY;

                drawRectangleAsLabel(graphics, labelBean.Text, (int)x, (int)y, (int)width, (int)height,
                    labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                mapCoordinates.Add(oldX + labelBean.Col * colMarginDefault + ", " + y, labelBean);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            int x = p.X;
            int y = p.Y;
            Graphics graphics = pictureBox1.CreateGraphics();
            displayPosition(graphics, x, y, true);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1_Paint(sender, null);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
