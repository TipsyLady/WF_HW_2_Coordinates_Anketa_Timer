using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_10._04._2022
{
    public partial class Form2 : Form
    {
        //создание таймера вручную
        Timer myTimer = new Timer();
        int Counter = 0;
        
        public Form2()
        {
            InitializeComponent();
            buttonStop.Enabled = false;
            myTimer.Tick += new EventHandler(ShowTimer);
            myTimer.Tick += new EventHandler(myTimer_Tick);
            
            
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            myTimer.Stop();
            MessageBox.Show("Timer finishes the work", "Timer");
            buttonStop.Enabled = false;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(NumericSecond.Value<=0)
            {
                MessageBox.Show("Warning! Enter seconds more than 0");
            }
            else
            {
                buttonStop.Enabled = true;
                myTimer.Interval = Decimal.ToInt32(NumericSecond.Value) * 1000;
                myTimer.Start();
                
                
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            MessageBox.Show("Timer stops before Time ends", "Timer");
            buttonStop.Enabled = false;
            
            //создать видимый таймер Value - NumericSecond
            //сделать по Stop  сколько сек прошло
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            this.label2.Text = (++Counter).ToString();
        }

    }
}
