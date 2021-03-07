using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace win_form
{
    class LabelBean
    {
        public string Text { get; set; }
        public string Position { get; set; }
        public string Size { get; set; }
        public int Rotate { get; set; }
        public int Col { get; set; }
        public Color TextCorlor { get; set; }
        public Color BackgroundCorlor { get; set; }

        public LabelBean(string text, string position, Color textCorlor, Color backgroundCorlor, string size, int rotate, int col)
        {
            this.Text = text;
            this.Position = position;
            this.Size = size;
            this.TextCorlor = textCorlor;
            this.BackgroundCorlor = backgroundCorlor;
            this.Rotate = rotate;
            this.Col = col;
        }
    }
}
