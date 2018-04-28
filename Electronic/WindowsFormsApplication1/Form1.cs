using Electronic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Choice GetModelFromUI()
        {
            return new Choice
            {
                FullName = textBox1.Text,
                Name = textBox3.Text,
                Memory = textBox4.Text,
                VideoCard = textBox5.Text,
                Processor = textBox6.Text,
                Price = numericUpDown1.Value,
                NewTime = new NewTime()
            {
                Filled = dateTimePicker1.Value,
            },

           
        

           
                
            };
         }
        private void SetModelToUI(Choice dto)
        {
            textBox1.Text = dto.FullName;
            numericUpDown1.Value = dto.Price;
            textBox3.Text = dto.Name;
            textBox4.Text = dto.Memory;
            textBox5.Text = dto.VideoCard;
            textBox6.Text = dto.Processor;


        }



         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog() { Filter = "Файл заказа|*.txt" };
            var result = o.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = ElectronicHelper.LoadFromFile(o.FileName);
                SetModelToUI(dto);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = new SaveFileDialog() { Filter = "Файлы заказа|*.txt" };
            var result = s.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
               
                ElectronicHelper.WriteToFile(s.FileName, dto);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
