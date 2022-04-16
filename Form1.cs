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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string CoordinatesToString(MouseEventArgs e)
        {
            return "Координаты мышки: X= " + e.X.ToString() + "; Y= " 
                + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //ссылка на объект MEV
        {
            //Отображаем координаты мыши в заголовке окна
            Text = CoordinatesToString(e);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e) //ссылка на объект MEV
        {
            //Отображаем координаты мыши в заголовке окна
            Text = CoordinatesToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = " ";
            string caption = " ";
            if (e.Button == MouseButtons.Left) //если нажать ЛКМ
            {
                    message = "Вы находитесь за прямоугольником";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (e.Button == MouseButtons.Right) //если нажать ПКМ
            {
                caption = "\n" + panel2.Size.ToString();
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = " ";
            string caption = " ";
            if (e.Button == MouseButtons.Left)
            {
                if (e.X == 0 || e.Y == 0)
                {
                    message = "Вы находитесь на границе прямоугольника";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    message = "Вы находитесь в прямоугольнике";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (e.Button == MouseButtons.Right)
            {

                caption = "\n" + panel1.Size.ToString();
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
