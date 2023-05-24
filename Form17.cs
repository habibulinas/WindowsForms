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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
            string.IsNullOrEmpty(textBox2.Text) ||
            string.IsNullOrEmpty(textBox5.Text) ||
            string.IsNullOrEmpty(textBox3.Text) ||
            string.IsNullOrEmpty(textBox4.Text))
            {

                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            MessageBox.Show("Статистика доходов успешно установлена.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
