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
            labels.Add(new LabelBean("1", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("11", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 0));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 0));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 0));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 0));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 0));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 0));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 0));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 0));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 0));

            labels.Add(new LabelBean("2", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 1));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 1));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 1));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 1));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 1));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 1));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 1));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 1));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 1));

            labels.Add(new LabelBean("3", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 2));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 2));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 2));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 2));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 2));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 2));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 2));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 2));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 2));

            labels.Add(new LabelBean("4", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 3));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 3));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 3));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 3));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 3));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 3));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 3));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 3));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 3));

            labels.Add(new LabelBean("5", "49, 4", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 4));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 4));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 4));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 4));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 4));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 4));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 4));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 4));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 4));

            labels.Add(new LabelBean("6", "49, 4", System.Drawing.Color.White, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("", "65, 24", System.Drawing.Color.White, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 5));
            labels.Add(new LabelBean("9337", "49, 54", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("山口", "85, 54", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 5));
            labels.Add(new LabelBean("よろし口", "65, 74", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 5));
            labels.Add(new LabelBean("2130", "85, 84", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("2101", "49, 101", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("よろろ", "85, 104", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 5));
            labels.Add(new LabelBean("ろし口", "65, 121", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 5));
            labels.Add(new LabelBean("5237", "85, 131", System.Drawing.Color.Blue, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("2170", "51, 151", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 5));
            labels.Add(new LabelBean("口山口山", "86, 151", System.Drawing.Color.Red, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 270, 5));
            labels.Add(new LabelBean("ろし", "65, 171", System.Drawing.Color.Black, System.Drawing.Color.FromArgb(221,160,221), "17, 30", 90, 5));
            labels.Add(new LabelBean("2565", "85, 184", System.Drawing.Color.Black, System.Drawing.Color.White, "33, 17", 0, 5));

            return labels;
        }

        public static int[] getValuesAsPair(string values)
        {
            var valuesArr = values.Split(',');
            int[] map = new int[] { int.Parse(valuesArr[0].Trim()), int.Parse(valuesArr[1].Trim())};

            return map;
        }
    }
}
