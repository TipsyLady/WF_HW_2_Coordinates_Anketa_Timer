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
    public partial class MenuBar : Form
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.ShowDialog(); //модальное окно, когда одно окно активно
            //form_1.Show(); //немодальное окно, когда два окна работают одновременно
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_anketa form3 = new Form_anketa();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            string _message = "Сорокина Мария";
            string _caption = "Моё резюме";
            MessageBox.Show(_message, _caption);
            Counter += _message.Length + _caption.Length;
            _message = "Возраст: 27 лет";
            MessageBox.Show(_message, _caption);
            Counter += _message.Length + _caption.Length;
            _message = "Вид деятельности: Специалист по качеству автомобилей";
            Counter += _message.Length + _caption.Length;
            _caption = (Counter / 3).ToString();
            MessageBox.Show(_message, _caption);
        }
    }
}
