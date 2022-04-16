using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_10._04._2022
{
    public partial class Form_anketa : Form
    {
        string[] Russia_list = new string[]
        {
            "Москва",
            "Новомосковск",
            "Питер"
        };
        string [] Ukraine_list = new string []
        {
            "Киев",
            "Мариуполь",
            "Львов"
        };
        string[] Belorus_list = new string[]
        {
            "Гомель",
            "Минск",
            "Могилёв"
        };
        string[] Kaz_list = new string[]
        {
            "Нур-Султан",
            "Семей",
            "Шымкент"
        };

        public Form_anketa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void Countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {
           int _res = Countries_list.SelectedIndex;
            switch (_res)
            {
                case 0:
                    Cities_list.Items.Clear();
                    Cities_list.Items.AddRange(Russia_list);
                    break;
                case 1:
                    Cities_list.Items.Clear();
                    Cities_list.Items.AddRange(Ukraine_list);
                    break;
                case 2:
                    Cities_list.Items.Clear();
                    Cities_list.Items.AddRange(Belorus_list);
                    break;
                case 3:
                    Cities_list.Items.Clear();
                    Cities_list.Items.AddRange(Kaz_list);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        
        {
            if (FirstName.Text == "" || Surname.Text == "" || Countries_list.Text == "" || Cities_list.Text == "" || Telephone.Text == "")
                MessageBox.Show("Вы не заполнили все обязательные поля");
            else
            {
                string UserData = "ФИО: " + Surname.Text + "  " + FirstName.Text
                    + "  " + FatherName.Text + "\n";
                UserData += "Место жительства: " + Countries_list.Text + "  "
                    + Cities_list.Text + "\n";
                UserData += "Телефон: " + "  " + Telephone.Text + "\n";
                UserData += "Дата рождения: " + "  " + dateTimePicker1.Value.ToShortDateString()
                    + "\n";
                if (Man.Checked == true) UserData += "Пол: мужской" + "\n";
                else UserData += "Пол: женский" + "\n";
                MessageBox.Show(UserData, "Анкетные данные");
               

            Surname.Clear();
            FirstName.Clear();
            FatherName.Clear();
            Telephone.Clear();
            Countries_list.SelectedIndex = -1;
            Cities_list.SelectedIndex = -1;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            }


        }
            

    }
}
