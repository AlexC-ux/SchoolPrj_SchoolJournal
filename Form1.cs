using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raspisanie.Properties;

namespace Raspisanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox9.Text = Settings.Default.Zametki.ToString();

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)//расписание на пн
            {
                Settings.Default["lesson1"] = textBox1.Text;
                Settings.Default.Save();
                Settings.Default["lesson2"] = textBox2.Text;
                Settings.Default.Save();
                Settings.Default["lesson3"] = textBox3.Text;
                Settings.Default.Save();
                Settings.Default["lesson4"] = textBox4.Text;
                Settings.Default.Save();
                Settings.Default["lesson5"] = textBox5.Text;
                Settings.Default.Save();
                Settings.Default["lesson6"] = textBox6.Text;
                Settings.Default.Save();
                Settings.Default["lesson7"] = textBox7.Text;
                Settings.Default.Save();
                Settings.Default["lesson8"] = textBox8.Text;
                Settings.Default.Save();

            }
            if (radioButton2.Checked == true)//расписание на вт
            {
                Settings.Default["lesson1_2"] = textBox1.Text;
                Settings.Default.Save();
                Settings.Default["lesson2_2"] = textBox2.Text;
                Settings.Default.Save();
                Settings.Default["lesson3_2"] = textBox3.Text;
                Settings.Default.Save();
                Settings.Default["lesson4_2"] = textBox4.Text;
                Settings.Default.Save();
                Settings.Default["lesson5_2"] = textBox5.Text;
                Settings.Default.Save();
                Settings.Default["lesson6_2"] = textBox6.Text;
                Settings.Default.Save();
                Settings.Default["lesson7_2"] = textBox7.Text;
                Settings.Default.Save();
                Settings.Default["lesson8_2"] = textBox8.Text;
                Settings.Default.Save();

            }
            if (radioButton3.Checked == true)//расписание на ср
            {
                Settings.Default["lesson1_3"] = textBox1.Text;
                Settings.Default.Save();
                Settings.Default["lesson2_3"] = textBox2.Text;
                Settings.Default.Save();
                Settings.Default["lesson3_3"] = textBox3.Text;
                Settings.Default.Save();
                Settings.Default["lesson4_3"] = textBox4.Text;
                Settings.Default.Save();
                Settings.Default["lesson5_3"] = textBox5.Text;
                Settings.Default.Save();
                Settings.Default["lesson6_3"] = textBox6.Text;
                Settings.Default.Save();
                Settings.Default["lesson7_3"] = textBox7.Text;
                Settings.Default.Save();
                Settings.Default["lesson8_3"] = textBox8.Text;
                Settings.Default.Save();

            }
            if (radioButton4.Checked == true)//расписание на чт
            {
                Settings.Default["lesson1_4"] = textBox1.Text;
                Settings.Default.Save();
                Settings.Default["lesson2_4"] = textBox2.Text;
                Settings.Default.Save();
                Settings.Default["lesson3_4"] = textBox3.Text;
                Settings.Default.Save();
                Settings.Default["lesson4_4"] = textBox4.Text;
                Settings.Default.Save();
                Settings.Default["lesson5_4"] = textBox5.Text;
                Settings.Default.Save();
                Settings.Default["lesson6_4"] = textBox6.Text;
                Settings.Default.Save();
                Settings.Default["lesson7_4"] = textBox7.Text;
                Settings.Default.Save();
                Settings.Default["lesson8_4"] = textBox8.Text;
                Settings.Default.Save();

            }
            if (radioButton5.Checked == true)//расписание на пт
            {
                Settings.Default["lesson1_5"] = textBox1.Text;
                Settings.Default.Save();
                Settings.Default["lesson2_5"] = textBox2.Text;
                Settings.Default.Save();
                Settings.Default["lesson3_5"] = textBox3.Text;
                Settings.Default.Save();
                Settings.Default["lesson4_5"] = textBox4.Text;
                Settings.Default.Save();
                Settings.Default["lesson5_5"] = textBox5.Text;
                Settings.Default.Save();
                Settings.Default["lesson6_5"] = textBox6.Text;
                Settings.Default.Save();
                Settings.Default["lesson7_5"] = textBox7.Text;
                Settings.Default.Save();
                Settings.Default["lesson8_5"] = textBox8.Text;
                Settings.Default.Save();

            }
            if (radioButton1.Checked == true)//в
            {
                progressBar1.Value = 20;
            }
            if (radioButton2.Checked == true)
            {
                progressBar1.Value = 40;
            }
            if (radioButton3.Checked == true)
            {
                progressBar1.Value = 60;
            }
            if (radioButton4.Checked == true)
            {
                progressBar1.Value = 80;
            }
            if (radioButton5.Checked == true)
            {
                progressBar1.Value = 100;
            }//выхи

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
        }
        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Settings.Default["Zametki"] = textBox9.Text;
            Settings.Default.Save();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                //________________________________________________________
                textBox1.Text = Settings.Default.lesson1.ToString();
                textBox2.Text = Settings.Default.lesson2.ToString();
                textBox3.Text = Settings.Default.lesson3.ToString();
                textBox4.Text = Settings.Default.lesson4.ToString();
                textBox5.Text = Settings.Default.lesson5.ToString();
                textBox6.Text = Settings.Default.lesson6.ToString();
                textBox7.Text = Settings.Default.lesson7.ToString();
                textBox8.Text = Settings.Default.lesson8.ToString();
            }
            if (radioButton2.Checked == true)
            {

                //________________________________________________________
                textBox1.Text = Settings.Default.lesson1_2.ToString();
                textBox2.Text = Settings.Default.lesson2_2.ToString();
                textBox3.Text = Settings.Default.lesson3_2.ToString();
                textBox4.Text = Settings.Default.lesson4_2.ToString();
                textBox5.Text = Settings.Default.lesson5_2.ToString();
                textBox6.Text = Settings.Default.lesson6_2.ToString();
                textBox7.Text = Settings.Default.lesson7_2.ToString();
                textBox8.Text = Settings.Default.lesson8_2.ToString();
            }
            if (radioButton3.Checked == true)
            {

                //________________________________________________________
                textBox1.Text = Settings.Default.lesson1_3.ToString();
                textBox2.Text = Settings.Default.lesson2_3.ToString();
                textBox3.Text = Settings.Default.lesson3_3.ToString();
                textBox4.Text = Settings.Default.lesson4_3.ToString();
                textBox5.Text = Settings.Default.lesson5_3.ToString();
                textBox6.Text = Settings.Default.lesson6_3.ToString();
                textBox7.Text = Settings.Default.lesson7_3.ToString();
                textBox8.Text = Settings.Default.lesson8_3.ToString();
            }
            if (radioButton4.Checked == true)
            {

                //________________________________________________________
                textBox1.Text = Settings.Default.lesson1_4.ToString();
                textBox2.Text = Settings.Default.lesson2_4.ToString();
                textBox3.Text = Settings.Default.lesson3_4.ToString();
                textBox4.Text = Settings.Default.lesson4_4.ToString();
                textBox5.Text = Settings.Default.lesson5_4.ToString();
                textBox6.Text = Settings.Default.lesson6_4.ToString();
                textBox7.Text = Settings.Default.lesson7_4.ToString();
                textBox8.Text = Settings.Default.lesson8_4.ToString();
            }
            if (radioButton5.Checked == true)
            {

                //________________________________________________________
                textBox1.Text = Settings.Default.lesson1_5.ToString();
                textBox2.Text = Settings.Default.lesson2_5.ToString();
                textBox3.Text = Settings.Default.lesson3_5.ToString();
                textBox4.Text = Settings.Default.lesson4_5.ToString();
                textBox5.Text = Settings.Default.lesson5_5.ToString();
                textBox6.Text = Settings.Default.lesson6_5.ToString();
                textBox7.Text = Settings.Default.lesson7_5.ToString();
                textBox8.Text = Settings.Default.lesson8_5.ToString();
            }

        }
    }
}
