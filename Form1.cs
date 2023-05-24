using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText1 = textBox1.Text;
            string inputText2 = textBox2.Text;

            if (inputText1 == "Администратор")

            {
                // Переход на первую форму
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (inputText1 == "Экскурсовод")
            {
                // Переход на вторую форму
                Form8 form8 = new Form8();
                form8.Show();
                this.Hide();
            }
            else if (inputText1 == "Бухгалтер")
            {
                // Переход на третью форму
                Form15 form15 = new Form15();
                form15.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
