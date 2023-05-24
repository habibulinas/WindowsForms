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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
             string.IsNullOrEmpty(textBox2.Text) ||
             string.IsNullOrEmpty(textBox5.Text) ||
             string.IsNullOrEmpty(textBox4.Text))
            {

                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            MessageBox.Show("Товар успешно заказан! Ожидайте, с вами свяжется поставщик для уточнения деталей.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
