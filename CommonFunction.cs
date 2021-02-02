using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace win_form
{
    class CommonFunction
    {
        public static List<LabelBean> getListLabel() {
            List<LabelBean> lst = new List<LabelBean>();
            lst.Add(new LabelBean("手地と2", "60, 100", "17, 50", true, System.Drawing.Color.Black, System.Drawing.Color.MediumPurple, System.Drawing.Color.Black));
            lst.Add(new LabelBean("手地と", "60, 40", "50, 17", false, System.Drawing.Color.Black, System.Drawing.Color.MediumPurple, System.Drawing.Color.Black));

            return lst;
        }
        public static int[] getValuesAsPair(string value) {
            var values = value.Split(',');
            int[] result = new int[] {int.Parse(values[0].Trim()), int.Parse(values[1].Trim())};

            return result;
        }
    }
}
