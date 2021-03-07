using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerGUI.Bean;

namespace TimerGUI
{
    public partial class Form1 : Form
    {
        //Timer timer1;
        CFCTimer timer;
        public Form1()
        {
            InitializeComponent();
            //timer1 = new Timer();
            //timer1.Tick += timer1_Tick;
            //timer1.Interval = 1000;
            timer = new CFCTimer();
            timer.label = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = !timer1.Enabled;
            button1.Text = button1.Text == "Stop" ? "Start" : "Stop";
            timer.start();
        }
        //int i = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    i++;
        //    resetTimer(ref i);
        //    label1.Text = i.ToString();
        //}

        //private void resetTimer(ref int curSecond) {
        //    if (curSecond >= 10)
        //    {
        //        curSecond = 0;
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //i = 10;
            //resetTimer(ref i);
            timer.resetTimer();
        }

        public void temp() {
            Type type = this.GetType();
            var method = type.GetMethods();
        }
    }
}
