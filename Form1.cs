using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample2_WinForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, LabelBean> mapCoordinates = new Dictionary<string, LabelBean>();
        //current Label was choosen
        LabelBean curLabelBean;
        //original width, height Window
        float oldWidthSize = 1f;
        float oldHeightSize = 1f;
        //stop paint event again
        bool isLoad = true;
        //TODO Tets, can remove
        int colWidthDefault = 85;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangleAsLabel(Graphics graphics, string text, int x, int y, int w, int h, Color textColor, Color borderColor, Color backgroundColor, int rotate, int col)
        {
            Pen pen = new Pen(borderColor, 6.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);
            SolidBrush sbText = new SolidBrush(textColor);

            Rectangle myRectangle = new Rectangle(x, y, w, h);
            //draw rectangle
            graphics.DrawRectangle(pen, myRectangle);
            //draw background
            graphics.FillRectangle(sb, x, y, w, h);
            float fontSize = 10;

            //draw text
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            SizeF stringSize = new SizeF();
            string fontName = "sans-serif";
            Font font = new Font(fontName, fontSize);
            stringSize = graphics.MeasureString(text, font);

            float strXPos = x;
            float strYPos = y;
            if (rotate != 0)
            {
                drawFormat.Alignment = StringAlignment.Near;
                drawFormat.LineAlignment = StringAlignment.Near;
                //cal font size
                while (stringSize.Width > h)
                {
                    fontSize -= 0.5f;
                    font = new Font(fontName, fontSize);
                    stringSize = graphics.MeasureString(text, font);
                }
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

        private void displayPosition(int x, int y, bool isClick)
        {
            Bitmap bmp = new Bitmap(700, 250);
            Graphics graphics = Graphics.FromImage(bmp);
            LabelBean lbChoose = null;
            int xPos = 0;
            int yPos = 0;
            int width = 0;
            int height = 0;
            float deltaX = (pictureBox1.Size.Width / oldWidthSize);
            float deltaY = (pictureBox1.Size.Height / oldHeightSize);

            foreach (var label in mapCoordinates)
            {
                string position = label.Key;
                LabelBean labelBean = label.Value;

                int[] positions = CommonFunction.getValuesAsPair(position);
                xPos = positions[0];
                yPos = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                width = sizes[0];
                height = sizes[1];

                //check current pointer is belong to label
                bool isOut = checkPointerIsOutLabels(x, y, deltaX, deltaY, labelBean);
                if (isOut == true)
                {
                    //drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black,
                    //    labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                    //TODO Test can remove
                    drawRectangleAsLabel(graphics, labelBean.Text, xPos, yPos, width, height, labelBean.TextCorlor, Color.Black, 
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
                    //TODO Test, can remove
                    drawRectangleAsLabel(graphics, lbChoose.Text, xPos + lbChoose.Col * colWidthDefault, yPos, width, height,
                        lbChoose.TextCorlor, borderColor, lbChoose.BackgroundCorlor, lbChoose.Rotate, lbChoose.Col);
                }
                drawDataForDisplaying(bmp);
                return;
            }
        }
        private bool checkPointerIsOutLabels(int Ox, int Oy, float deltaX, float deltaY, LabelBean label)
        {
            int[] positions = CommonFunction.getValuesAsPair(label.Position);
            int xPos = positions[0];
            //TODO Test, can remove
            xPos += label.Col * colWidthDefault;
            int yPos = positions[1];
            int[] sizes = CommonFunction.getValuesAsPair(label.Size);
            int width = sizes[0];
            int height = sizes[1];

            //calculate delta for pointer was choosen to be belong to on old coordinates
            float newX = xPos * deltaX;
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
            //pictureBox2.Image = bmp;
            //pictureBox1.Image = pictureBox2.Image;
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            if (isLoad == false)
            {
                return;
            }
            isLoad = false;

            //TODO Test
            //Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            //Bitmap bmp = new Bitmap(700, 250);
            //Graphics graphics = Graphics.FromImage(bmp);
            Graphics graphics = this.CreateGraphics();
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
                drawRectangleAsLabel(graphics, labelBean.Text, x + labelBean.Col * colWidthDefault, y, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                //drawDataForDisplaying(bmp);
                //TODO Tets, can remove
                //mapCoordinates.Add(labelBean.Position, labelBean);
                mapCoordinates.Add(x + labelBean.Col * colWidthDefault + ", " + y, labelBean);
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

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Size size = this.Size;
            Graphics graphics = this.CreateGraphics();

            mapCoordinates = new Dictionary<string, LabelBean>();
            List<LabelBean> labelBeans = CommonFunction.getListLabel();
            float deltaX = (pictureBox1.Size.Width / oldWidthSize);
            float deltaY = (pictureBox1.Size.Height / oldHeightSize);
            foreach (LabelBean labelBean in labelBeans)
            {
                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                int x = positions[0];
                int y = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                int width = sizes[0];
                int height = sizes[1];

                float newX = x * deltaX;
                float newY = y * deltaY;
                float newWidth = width * deltaX;
                float newHeight = height * deltaY;

                x = (int)(newX * (x + labelBean.Col * colWidthDefault));
                //y = 

                drawRectangleAsLabel(graphics, labelBean.Text, x, y, width, height, labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
            }
            graphics.Dispose();
        }
    }
}
