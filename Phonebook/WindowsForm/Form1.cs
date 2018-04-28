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
    public struct Phone
    {
        public string Name;
        public string Number;

    }

    public partial class Form1 : Form
    {
        List<Phone> newPhone = new List<Phone>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader readd = new StreamReader("D:\\text1.txt");
            string m;
            while ((m = readd.ReadLine())!=null)
            {
                Phone ss;
                ss.Name = m;
                ss.Number = readd.ReadLine();
                newPhone.Add(ss);
            }
            readd.Close(); 
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == " ") || (textBox2.Text == " "))
            {
                MessageBox.Show("Ошибка данных. \n" + "Необходимо ввести данные во все поля.", "Справочник", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
               Phone x;
                x.Name = textBox1.Text;
                x.Number = textBox2.Text;
                int x1 = search(x.Name);
                if (x1 == -1)
                {
                    newPhone.Add(x);
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    MessageBox.Show("Контакт внесён");

                }
                else
                {
                    MessageBox.Show("Данный контакт существует");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e) 
        {
            textBox1.Text = null;
            textBox2.Text = null;

        }
        int search(string s)
        {
            for (int i = 0; i < newPhone.Count; i++)
            {
                if (newPhone[i].Name.Equals(s))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int x = search(s);
            if (x != -1)
                textBox2.Text = newPhone[x].Number;
            else
                MessageBox.Show("Контакт не найден");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader readd = new StreamReader("D:\\text1.txt");
            string m;
            while ((m = readd.ReadLine()) != null)
            {
                Phone ss;
                ss.Name = m;
                ss.Number = readd.ReadLine();
                newPhone.Add(ss);
            }
            readd.Close();
        }
    }
}
