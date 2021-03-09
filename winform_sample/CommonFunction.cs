using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using win_form;

namespace sample2_WinForm
{
    class CommonFunction
    {
        public static List<LabelBean> getListLabel()
        {
            List<LabelBean> labels = new List<LabelBean>();
            labels.Add(new LabelBean("1", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("11", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 0));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 0));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 0));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 0));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 0));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 0));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 0));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 0));
            labels.Add(new LabelBean("9200", "65, 250", System.Drawing.Color.Blue, System.Drawing.Color.White, "14, 30", 270, 0));

            labels.Add(new LabelBean("2", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 1));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 1));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 1));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 1));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 1));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 1));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 1));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 1));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 1));

            labels.Add(new LabelBean("3", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 2));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 2));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 2));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 2));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 2));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 2));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 2));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 2));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 2));

            labels.Add(new LabelBean("4", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 3));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 3));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 3));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 3));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 3));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 3));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 3));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 3));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 3));

            labels.Add(new LabelBean("5", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 4));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 4));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 4));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 4));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 4));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 4));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 4));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 4));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 4));

            labels.Add(new LabelBean("6", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 5));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 5));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 5));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 5));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 5));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 5));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 5));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 5));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 5));

            labels.Add(new LabelBean("7", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 6));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 6));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 6));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 6));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 6));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 6));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 6));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 6));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 6));

            labels.Add(new LabelBean("8", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 7));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 7));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 7));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 7));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 7));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 7));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 7));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 7));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 7));

            labels.Add(new LabelBean("9", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 8));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 8));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 8));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 8));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 8));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 8));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 8));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 8));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 8));

            labels.Add(new LabelBean("10", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 9));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 9));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 9));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 9));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 9));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 9));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 9));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 9));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 9));

            labels.Add(new LabelBean("11", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("", "65, 23", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 10));
            labels.Add(new LabelBean("9337", "49, 55", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("山口", "81, 55", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 10));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 10));
            labels.Add(new LabelBean("2130", "81, 87", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("2101", "49, 106", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("よろろ", "81, 106", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 10));
            labels.Add(new LabelBean("ろし口", "65, 125", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 10));
            labels.Add(new LabelBean("5237", "81, 138", System.Drawing.Color.Blue, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("2170", "49, 157", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 10));
            labels.Add(new LabelBean("口山口山", "81, 157", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 270, 10));
            labels.Add(new LabelBean("ろし", "65, 176", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221, 160, 221), "14, 30", 90, 10));
            labels.Add(new LabelBean("2565", "81, 189", System.Drawing.Color.Black, System.Drawing.Color.White, "30, 17", 0, 10));
            return labels;
        }

        public static int[] getValuesAsPair(string values)
        {
            var valuesArr = values.Split(',');
            int[] map = new int[] { int.Parse(valuesArr[0].Trim()), int.Parse(valuesArr[1].Trim())};

            return map;
        }

        public static float roundValue(float value) {
            int result = (int)Math.Round((decimal)value, 0, MidpointRounding.AwayFromZero);
            if (value < 1f)
            {
                return value;
            }
            return result;
        }
    }
}
