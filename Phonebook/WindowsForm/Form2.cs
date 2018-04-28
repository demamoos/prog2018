using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == " ") || (textBox2.Text == " "))
            {
                MessageBox.Show("Ошибка данных. \n" + "Необходимо ввести данные во все поля.", "Справочник", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string t1 = textBox1.Text;
                string textik = File.ReadAllText("D:\\text1.txt");
                using (StreamReader read = new StreamReader(("D:\\text1.txt")))
                {
                    if (textik.Contains(t1))
                    {
                        MessageBox.Show("Контакт уже существует, его сохранение невозможно");
                    }
                    else
                    {
                        read.Close();
                        System.IO.StreamWriter write = new System.IO.StreamWriter("D:\\text1.txt", true);
                        write.WriteLine(textBox1.Text);
                        write.WriteLine(textBox2.Text);
                        write.Close();
                        textBox1.Text = " ";
                        textBox2.Text = " ";
                        MessageBox.Show("Контакт сохранен");
                    }

                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
