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
        public bool isVertical { get; set; }
        public Color TextCorlor { get; set; }
        public Color BackgroundCorlor { get; set; }
        public Color BorderCorlor { get; set; }

        public LabelBean(string text, string position, string size, bool isVertical, Color textCorlor, Color backgroundCorlor, Color borderCorlor)
        {
            Text = text;
            Position = position;
            Size = size;
            this.isVertical = isVertical;
            TextCorlor = textCorlor;
            BackgroundCorlor = backgroundCorlor;
            BorderCorlor = borderCorlor;
        }
    }
}
