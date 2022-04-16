
namespace WF_CW_10._04._2022
{
    partial class Form_anketa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Countries_list = new System.Windows.Forms.ComboBox();
            this.Cities_list = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Telephone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fem = new System.Windows.Forms.RadioButton();
            this.Man = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FatherName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 470);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.Countries_list);
            this.panel2.Controls.Add(this.Cities_list);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Telephone);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Fem);
            this.panel2.Controls.Add(this.Man);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.FatherName);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Controls.Add(this.Surname);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 470);
            this.panel2.TabIndex = 1;
            // 
            // Countries_list
            // 
            this.Countries_list.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Countries_list.FormattingEnabled = true;
            this.Countries_list.Items.AddRange(new object[] {
            "Россия",
            "Украина",
            "Беларусь",
            "Казахстан"});
            this.Countries_list.Location = new System.Drawing.Point(161, 189);
            this.Countries_list.Name = "Countries_list";
            this.Countries_list.Size = new System.Drawing.Size(200, 24);
            this.Countries_list.TabIndex = 21;
            this.Countries_list.SelectedIndexChanged += new System.EventHandler(this.Countries_list_SelectedIndexChanged);
            // 
            // Cities_list
            // 
            this.Cities_list.FormattingEnabled = true;
            this.Cities_list.Location = new System.Drawing.Point(161, 231);
            this.Cities_list.Name = "Cities_list";
            this.Cities_list.Size = new System.Drawing.Size(200, 24);
            this.Cities_list.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 30;
            this.button3.Location = new System.Drawing.Point(342, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 30;
            this.button2.Location = new System.Drawing.Point(189, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Сохранить результат";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(161, 267);
            this.Telephone.Mask = "+7(999) 000-00-00";
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(200, 22);
            this.Telephone.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 30;
            this.button1.Location = new System.Drawing.Point(29, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Посмотреть результат";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fem
            // 
            this.Fem.AutoSize = true;
            this.Fem.Checked = true;
            this.Fem.Location = new System.Drawing.Point(265, 362);
            this.Fem.Name = "Fem";
            this.Fem.Size = new System.Drawing.Size(58, 21);
            this.Fem.TabIndex = 16;
            this.Fem.TabStop = true;
            this.Fem.Text = "Жен";
            this.Fem.UseVisualStyleBackColor = true;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(161, 362);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(56, 21);
            this.Man.TabIndex = 15;
            this.Man.Text = "Муж";
            this.Man.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 306);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 4, 24, 23, 59, 59, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 24, 23, 59, 59, 0);
            // 
            // FatherName
            // 
            this.FatherName.Location = new System.Drawing.Point(161, 142);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(200, 22);
            this.FatherName.TabIndex = 10;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(161, 92);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(200, 22);
            this.FirstName.TabIndex = 9;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(161, 46);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 22);
            this.Surname.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Город *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия *";
            // 
            // Form_anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_anketa";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Telephone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Fem;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Countries_list;
        private System.Windows.Forms.ComboBox Cities_list;
    }
}