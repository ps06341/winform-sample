using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace coordinate_scale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variable
        bool isBigger = true;
        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isBigger == true)
            {
                //this.Scale(new SizeF(720*2, 480*2));
                this.ClientSize = new System.Drawing.Size(720 * 2, 480 * 2);
            }
            else 
            {
                //this.Scale(new SizeF(720, 480));
                this.ClientSize = new System.Drawing.Size(720, 480);
            }
            isBigger = !isBigger;
        }

        private void picB_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            MessageBox.Show("x: " + point.X + " y: " + point.Y);
        }

        public static float[] getResizingPostion(Size size, Size oldSize, float x, float y, float w, float h, float penwidth)
        {
            return getResizingPostion(size, oldSize, x, y, w, h, penwidth, new float[] { 0, 0 });
        }

        public static float[] getResizingPostion(Size size, Size oldSize, float x, float y, float w, float h, float penwidth, float[] originalCoordinate)
        {
            float deltaX = (float)size.Width / (float)oldSize.Width;
            float deltaY = (float)size.Height / (float)oldSize.Height;
            //deltaY += 0.1f;

            float newX = originalCoordinate[0] + deltaX * (x - originalCoordinate[0]);
            float newY = originalCoordinate[1] + deltaY * (y - originalCoordinate[1]);
            float newW = originalCoordinate[0] + deltaX * (w - originalCoordinate[0]);
            float newH = originalCoordinate[1] + deltaY * (h - originalCoordinate[1]);
            float newPenwidth = originalCoordinate[1] + deltaY * (penwidth - originalCoordinate[1]);

            if (newPenwidth < 4)
            {
                newPenwidth = 4;
            }

            if (newPenwidth > 8)
            {
                newPenwidth = 8;
            }

            if (newPenwidth % 2 != 0)
            {
                newPenwidth -= 1;
            }

            //float[] result = new float[] { newX, CommonFunction.roundValue(newY, 3),
            //    newW, CommonFunction.roundValue(newH, 3) };
            float[] result = new float[] { newX, newY, newW, newH, newPenwidth };

            return result;
        }

        float[] resizeCoordinate = null;
        bool isDraw = true;
        int countFire = 1;
        private void picB_Paint(object sender, PaintEventArgs e)
        {
            isDraw = false;
            countFire++;
            Size szSize = picB.ClientSize;
            Size oldSize = oldSz.Size;

            resizeCoordinate = getResizingPostion(szSize, oldSize, 47, 67, 20, 30, 2.0f);

            drawRectangleAsChair(e.Graphics, "text", resizeCoordinate[0], resizeCoordinate[1], resizeCoordinate[2], resizeCoordinate[3],
                        Color.Red, Color.Red, Color.Blue, 0, 0, 2.0f);

            resizeCoordinate = getResizingPostion(szSize, oldSize, 0, 0, 20, 30, 2.0f);

            drawRectangleAsChair(e.Graphics, "text", resizeCoordinate[0], resizeCoordinate[1], resizeCoordinate[2], resizeCoordinate[3],
                        Color.Red, Color.Red, Color.Blue, 0, 0, 2.0f);
            //int restoreW = this.ClientSize.Width;
            //int restoreH = this.ClientSize.Height;
            //this.ClientSize = new System.Drawing.Size(this.ClientSize.Width * 2, szSize.Height * 2);
            //this.ClientSize = new System.Drawing.Size(restoreW, restoreH);
        }

        private void drawRectangleAsChair(Graphics graphics, string text, float x, float y, float w, float h,
            Color textColor, Color borderColor, Color backgroundColor, float rotate, int col, float penWidth)
        {
            this.drawRectangleDefault(graphics, text, x, y, w, h, textColor, borderColor,
                        backgroundColor, rotate, col, FontStyle.Bold, true, 8, true, penWidth);
        }

        private void drawRectangleDefault(Graphics graphics, string text, float x, float y, float w, float h,
Color textColor, Color borderColor, Color backgroundColor, float rotate, int col, FontStyle fontStyle, bool calPosition, int defaultFontSize, bool isCenter, float penWidth)
        {
            //text = y + ", " + h;
            Pen pen = new Pen(borderColor, 2.0f);
            SolidBrush sb = new SolidBrush(backgroundColor);
            SolidBrush sbText = new SolidBrush(textColor);

            //Rectangle myRectangle = new Rectangle(x, y, w, h);
            ////draw rectangle
            //graphics.DrawRectangle(pen, myRectangle);
            graphics.DrawRectangle(pen, x, y, w, h);

            //draw background
            graphics.FillRectangle(sb, x, y, w, h);
            float fontSize = defaultFontSize;

            //draw text
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
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
    }
}
