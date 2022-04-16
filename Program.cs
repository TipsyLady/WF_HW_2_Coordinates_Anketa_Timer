using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_10._04._2022
{
    public static class Program
    {
        static DialogResult ShowMessageBoxes_1()
        {
            //1
            string _message = "Текст сообщения";
            string _caption = "Заголовок сообщения";
            MessageBox.Show(_message, _caption);
            //2
            DialogResult _result = MessageBox.Show(_message, _caption,
               MessageBoxButtons.YesNo);
            //3
            _result = MessageBox.Show(_message);
            return _result;


            //string _message = "Сообщение от програмиста";
            //MessageBox.Show(_message);
            //string _caption = "Это заглавие";
            //MessageBox.Show(_message, _caption);
            ////2
            //_caption = "Выбор";
            //DialogResult _result = MessageBox.Show(_message, _caption,
            //   MessageBoxButtons.YesNoCancel);
            //string _button = _result.ToString();
            //_result = MessageBox.Show("Вы выбрали " + _button,
            //_button, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //return _result;

        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuBar());
        }
    }
}
