using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGUI.Bean
{
    class CFCTimer
    {
        #region variable
        public Timer timer;
        public static int limitTime = 10;
        public static int current = 0;
        public Label label;
        //public MethodInfo methodInfo;
        //public ParameterInfo[] parameters;

        #endregion

        #region Contructor
        public CFCTimer()
        {
            timer = new Timer();
            timer.Tick += countDown;
            timer.Interval = 1000;
        }
        #endregion

        #region public method
        public void start(MethodInfo methodInfo)
        {
            //this.methodInfo = methodInfo;
            //parameters = this.methodInfo.GetParameters();
            timer.Enabled = true;
        }

        public void countDown(object sender, EventArgs e)
        {
            current++;
            autoResetTimer();
            //TODO hide display second
            label.Text = current.ToString();
        }

        public void autoResetTimer()
        {   
            if (current >= limitTime)
            {
                current = 0;
                timer.Enabled = false;
                //MessageBox.Show("reset Time");
                //TODO something => click btnUpdate obj, event = null
                //methodInfo.Invoke(null, parameters);
                timer.Enabled = true;
            }
        }

        public void resetTimer()
        {
            current = limitTime - 1;
        }
        #endregion
    }
}
