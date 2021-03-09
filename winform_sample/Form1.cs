using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win_form;

namespace sample2_WinForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, object> mapCoordinatesChair = new Dictionary<string, object>();
        Dictionary<string, object> mapCoordinatesName = new Dictionary<string, object>();
        //current Label was choosen
        LabelBean curLabelBean;
        //stop paint event again
        int colMarginDefault = 85;
        int heightLabelNameDefault = 20;
        int curY = -1;
        bool isDraw = true;
        bool canRestoreSize = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangleAsChair(Graphics graphics, string text, int x, int y, int w, int h,
            Color textColor, Color borderColor, Color backgroundColor, int rotate, int col)
        {
            this.drawRectangleDefault(graphics, text, x, y, w, h, textColor, borderColor,
                        backgroundColor, rotate, col, FontStyle.Bold, true, 16, true);
        }
        private void drawRectangleAsNameMenu(Graphics graphics, string text, int x, int y, int w, int h,
                    Color textColor, Color borderColor, Color backgroundColor, int rotate, int col)
        {
            this.drawRectangleDefault(graphics, text, x, y, w, h, textColor, borderColor,
                        backgroundColor, rotate, col, FontStyle.Regular, false, 12, true);
        }

        private void drawRectangleDefault(Graphics graphics, string text, int x, int y, int w, int h,
Color textColor, Color borderColor, Color backgroundColor, int rotate, int col, FontStyle fontStyle, bool calPosition, int defaultFontSize, bool isCenter)
        {
            Pen pen = new Pen(borderColor, 4.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);
            SolidBrush sbText = new SolidBrush(textColor);

            Rectangle myRectangle = new Rectangle(x, y, w, h);
            //draw rectangle
            graphics.DrawRectangle(pen, myRectangle);
            //draw background
            graphics.FillRectangle(sb, x, y, w, h);
            float fontSize = defaultFontSize;

            //draw text
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            //each char in line
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            SizeF stringSize = new SizeF();
            string fontName = "sans-serif";
            Font font = new Font(fontName, fontSize, fontStyle);
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
                    font = new Font(fontName, 0.5f, fontStyle);
                    break;
                }
                font = new Font(fontName, fontSize, fontStyle);
                stringSize = graphics.MeasureString(text, font);
            }

            while (stringSize.Height >= rectangleTextHeight)
            {
                fontSize -= 0.5f;
                if (fontSize <= 0)
                {
                    font = new Font(fontName, 0.5f, fontStyle);
                    break;
                }
                font = new Font(fontName, fontSize, fontStyle);
                stringSize = graphics.MeasureString(text, font);
            }

            drawFormat.Alignment = StringAlignment.Near;
            drawFormat.LineAlignment = StringAlignment.Near;

            float strXPos = x;
            float strYPos = y;
            if (calPosition == true)
            {
                strXPos = x + (float)w / 2 - (float)stringSize.Width / 2;
                strYPos = y + (float)h / 2 - (float)stringSize.Height / 2;
            }
            else if (calPosition == false && isCenter == true)
            {
                strXPos = x + (float)w / 2 - (float)stringSize.Width / 2;
            }

            //rotate for text
            if (rotate != 0)
            {
                strXPos = 0;
                strYPos = 0;
                drawFormat.Alignment = StringAlignment.Near;
                drawFormat.LineAlignment = StringAlignment.Near;
                if (rotate == 270)
                {
                    if (isCenter == true)
                    {
                        graphics.TranslateTransform(x + w / 4, y + (float)h / 2 + ((float)stringSize.Width / 2));
                    }
                    else
                    {
                        graphics.TranslateTransform(x, y + stringSize.Width);
                    }
                }
                else if (rotate == 180)
                {
                    //graphics.TranslateTransform(x + w / 4, y + h - 3);
                }
                else if (rotate == 90)
                {
                    if (isCenter == true)
                    {
                        graphics.TranslateTransform(x + (float)w / 2 + (float)stringSize.Height / 4, ((float)h / 2) + y - ((float)stringSize.Width / 2));
                    }
                    else
                    {
                        graphics.TranslateTransform(x + stringSize.Height, y);
                    }
                }

                graphics.RotateTransform(rotate);
            }

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphics.DrawString(text, font, sbText, strXPos, strYPos, drawFormat);

            graphics.ResetTransform();
            pen.Dispose();
            sb.Dispose();
            sbText.Dispose();
        }

        private void displayPosition(Graphics graphics, Dictionary<string, object> datas, int x, int y, bool isClick, Size sz, Size oldSz)
        {
            //Size sz = pictureBox1.ClientSize;
            //Size oldSz = pictureBox2.ClientSize;

            LabelBean lbChoose = null;
            int nameY = 0;
            float xPos = 0;
            float yPos = 0;
            float width = 0;
            float height = 0;
            float deltaX = (float)sz.Width / (float)oldSz.Width;
            deltaX = CommonFunction.roundValue(deltaX);
            float deltaY = (float)sz.Height / (float)oldSz.Height;
            deltaY = CommonFunction.roundValue(deltaY);
            string position = "0, 0";
            string size = "0, 0";
            int col = 0;
            bool drawChair = false;

            foreach (var data in datas)
            {
                string dataKey = data.Key;
                LabelBean labelBean = null;
                if (data.Value is LabelBean)
                {
                    labelBean = (LabelBean)data.Value;
                    drawChair = true;
                    position = labelBean.Position;
                    size = labelBean.Size;
                    col = labelBean.Col;
                }
                else if (data.Value is string)
                {
                    string coordinateLabelBean = (string)data.Value;
                    labelBean = (LabelBean)mapCoordinatesChair[coordinateLabelBean];
                    position = "0, " + dataKey;
                    size = oldSz.Width + ", " + heightLabelNameDefault;
                    deltaY = 1;
                }

                if (labelBean == null)
                {
                    return;
                }

                int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                xPos = positions[0];
                yPos = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                width = sizes[0];
                height = sizes[1];

                xPos *= deltaX;
                xPos += (col * colMarginDefault) * deltaX;
                yPos *= deltaY;
                width *= deltaX;
                height *= deltaY;

                //check current pointer is belong to label
                bool isOut = checkPointerIsOutLabels(x, y, deltaX, deltaY, position, size, col);
                if (isOut == true)
                {
                    if (drawChair == true)
                    {
                        drawRectangleAsChair(graphics, labelBean.Text, (int)xPos, (int)yPos, (int)width, (int)height, labelBean.TextCorlor, Color.Black,
                            labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                    }
                    else
                    {
                        width = deltaX * (float)oldSz.Width;
                        height *= deltaY * (float)oldSz.Height;
                        drawRectangleAsNameMenu(graphics, labelBean.Text, 0, int.Parse(dataKey), (int)width, (int)height,
                        Color.Black, Color.Black, Color.White, 0, labelBean.Col);
                    }

                    continue;
                }
                if (drawChair == false)
                {
                    nameY = int.Parse(dataKey);
                    curY = nameY;
                }
                lbChoose = labelBean;
            }

            if (drawChair == false)
            {
                width = deltaX * (float)oldSz.Width;
                height = deltaY * heightLabelNameDefault;
                drawRectangleAsNameMenu(graphics, lbChoose.Text, 0, nameY, (int)width, (int)height,
                Color.Black, Color.Black, Color.FromArgb(255, 239, 213), 0, 0);

                return;
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
                    drawRectangleAsChair(graphics, lbChoose.Text, (int)xPos, (int)yPos, (int)width, (int)height,
                        lbChoose.TextCorlor, borderColor, lbChoose.BackgroundCorlor, lbChoose.Rotate, lbChoose.Col);
                }
                //drawDataForDisplaying(bmp);
                return;
            }
        }

        private bool checkPointerIsOutLabels(int Ox, int Oy, float deltaX, float deltaY, string position, string size, int col)
        {
            int[] positions = CommonFunction.getValuesAsPair(position);
            int xPos = positions[0];
            int yPos = positions[1];
            int[] sizes = CommonFunction.getValuesAsPair(size);
            int width = sizes[0];
            int height = sizes[1];

            //calculate delta for pointer was choosen to be belong to on old coordinates
            float newX = xPos * deltaX;
            newX += (col * colMarginDefault) * deltaX;
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDraw == false)
            {
                return;
            }
            isDraw = false;
            Invalidate();
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
            Size sz = pictureBox1.ClientSize;
            Size oldSz = pictureBox2.ClientSize;

            Dictionary<string, object> mapCoordinatesChairTemp = new Dictionary<string, object>();
            bool isError = false;
            float deltaX = (float)sz.Width / (float)oldSz.Width;
            deltaX = CommonFunction.roundValue(deltaX);
            float deltaY = (float)sz.Height / (float)oldSz.Height;
            deltaY = CommonFunction.roundValue(deltaY);
            try
            {
                List<LabelBean> labelBeans = CommonFunction.getListLabel();
                foreach (LabelBean labelBean in labelBeans)
                {
                    int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                    float x = positions[0];
                    float y = positions[1];
                    int[] sizes = CommonFunction.getValuesAsPair(labelBean.Size);
                    float width = sizes[0];
                    float height = sizes[1];

                    float oldX = x;
                    x *= deltaX;
                    x += (labelBean.Col * colMarginDefault) * deltaX;
                    y *= deltaY;
                    width *= deltaX;
                    height *= deltaY;

                    drawRectangleAsChair(graphics, labelBean.Text, (int)x, (int)y, (int)width, (int)height,
                        labelBean.TextCorlor, Color.Black, labelBean.BackgroundCorlor, labelBean.Rotate, labelBean.Col);
                    mapCoordinatesChairTemp.Add(oldX + labelBean.Col * colMarginDefault + ", " + y, labelBean);
                }
            }
            catch (Exception ex)
            {
                isError = true;
            }

            if (mapCoordinatesChairTemp.Count > 0 && isError == false)
            {
                mapCoordinatesChair = mapCoordinatesChairTemp;
            }

            if (curLabelBean != null)
            {
                int[] positions = CommonFunction.getValuesAsPair(curLabelBean.Position);
                float x = positions[0];
                float y = positions[1];
                int[] sizes = CommonFunction.getValuesAsPair(curLabelBean.Size);
                float width = sizes[0];
                float height = sizes[1];

                x *= deltaX;
                x += (curLabelBean.Col * colMarginDefault) * deltaX;
                y *= deltaY;
                width *= deltaX;
                height *= deltaY;

                drawRectangleAsChair(graphics, curLabelBean.Text, (int)x, (int)y, (int)width, (int)height,
                        curLabelBean.TextCorlor, Color.Red, curLabelBean.BackgroundCorlor, curLabelBean.Rotate, curLabelBean.Col);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            int x = p.X;
            int y = p.Y;
            Graphics graphics = pictureBox1.CreateGraphics();
            displayPosition(graphics, mapCoordinatesChair, x, y, true, pictureBox1.ClientSize, pictureBox2.ClientSize);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            isDraw = true;
            pictureBox1_Paint(sender, null);
            panel1_Paint(sender, null);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                isDraw = true;
                pictureBox1_Paint(sender, null);
                panel1_Paint(sender, null);
                return;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                isDraw = true;
                pictureBox1_Paint(sender, null);
                panel1_Paint(sender, null);
                canRestoreSize = true;
                return;
            }
            else if (WindowState == FormWindowState.Normal && canRestoreSize == true)
            {
                isDraw = true;
                pictureBox1_Paint(sender, null);
                panel1_Paint(sender, null);
                canRestoreSize = false;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = null;
            if (e != null)
            {
                graphics = e.Graphics;
            }
            else
            {
                graphics = panel1.CreateGraphics();
            }
            graphics.Clear(Color.White);
            Invalidate();
            Size sz = panel1.ClientSize;
            Size oldSz = panel2.ClientSize;

            Dictionary<string, object> mapCoordinatesNameTemp = new Dictionary<string, object>();
            bool isError = false;
            float deltaX = (float)sz.Width / (float)oldSz.Width;
            deltaX = CommonFunction.roundValue(deltaX);
            float deltaY = (float)sz.Height / (float)oldSz.Height;
            deltaY = CommonFunction.roundValue(deltaY);
            try
            {
                List<LabelBean> labelBeans = CommonFunction.getListLabel();
                float nameY = 0;
                foreach (LabelBean labelBean in labelBeans)
                {
                    if (labelBean.Text.Equals(""))
                    {
                        continue;
                    }
                    float width = sz.Width;
                    float height = sz.Height;


                    width *= deltaX;
                    height *= deltaY;

                    drawRectangleAsNameMenu(graphics, labelBean.Text, 0, (int)nameY, (int)width, (int)height,
                        Color.Black, Color.Black, Color.White, 0, labelBean.Col);

                    int[] positions = CommonFunction.getValuesAsPair(labelBean.Position);
                    float x = positions[0];
                    float y = positions[1];
                    y *= deltaY;
                    mapCoordinatesNameTemp.Add(nameY + "", x + labelBean.Col * colMarginDefault + ", " + y);
                    nameY += heightLabelNameDefault;
                }
            }
            catch (Exception ex)
            {
                isError = true;
            }

            if (mapCoordinatesNameTemp.Count > 0 && isError == false)
            {
                mapCoordinatesName = mapCoordinatesNameTemp;
            }

            if (curY != -1)
            {
                string coordinateLabelBean = (string)mapCoordinatesName[curY + ""];
                LabelBean curLabelBean = (LabelBean)mapCoordinatesChair[coordinateLabelBean];
                float width = deltaX * (float)oldSz.Width;
                float height = deltaY * heightLabelNameDefault;
                drawRectangleAsNameMenu(graphics, curLabelBean.Text, 0, (int)curY, (int)width, (int)height,
                        Color.Black, Color.Black, Color.FromArgb(255, 239, 213), 0, curLabelBean.Col);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            int x = p.X;
            int y = p.Y;
            Graphics graphics = panel1.CreateGraphics();
            displayPosition(graphics, mapCoordinatesName, x, y, true, panel1.ClientSize, panel2.ClientSize);
        }
    }
}
