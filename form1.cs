using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;uol;gul.l.yilyigl.illu;;i
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsLuxure
{
    public partial class Form1 : Form
    {

        string m = "0";
        string n = "0";
        double result;

        

        public double factorial(double n)
        {
            double result = 1;
            for (double i = 1; i <= n; ++i)
                result = result * i;
            return result;
        }
        public void combination()
        {
            
            double s = d
            double q = double.Parse(n);
            if (s > 165 && q > 165)
            {

                textBox3.Text = "";
                MessageBox.Show("N и M имеют значения более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (s > 165)
            {

                textBox3.Text = "";
                MessageBox.Show("Введено значение M более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            if (q > 165)
            {

                textBox3.Text = "";
                MessageBox.Show("Введено значение N более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (s > q)
            {
                textBox3.Text = "";
                MessageBox.Show("M не может быть больше N", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double d = factorial(q);
            double y = factorial(q - s);
            double g = factorial(s);

            result = d / (y * g);
            textBox3.Text = result.ToString();


            
        }    //Сочетание
        public void placement()
        {
            double s = double.Parse(m);
            double q = double.Parse(n);
            if (s > 165 && q > 165)
            {

                textBox3.Text = "";
                MessageBox.Show("N и M имеют значения более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (s > 165)
            {
                textBox3.Text = "";
                MessageBox.Show("Введено значение M более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (q > 165)
            {
                textBox3.Text = "";
                MessageBox.Show("Введено значение N более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (s > q)
            {
                textBox3.Text = "";
                MessageBox.Show("M не может быть больше N", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double y = factorial(q - s);
            double d = factorial(q);

            result = d / y;
            textBox3.Text = result.ToString();

        }      //Размещение
        public void permutation()       //Перестановка
        {
            double q = double.Parse(n);
            if (q > 165)
            {
                textBox3.Text = "";
                MessageBox.Show("Значение N более 165", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            result = factorial(q);
            textBox3.Text = result.ToString();
        }



        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                combination();
                textBox1.Enabled = true;
            }
            else
                if (radioButton2.Checked == true)
            {
                placement();
                textBox1.Enabled = true;
            }
            if (radioButton3.Checked == true)
            {
                permutation();
                textBox1.Enabled = false;
            }

            if (textBox3.Text != "")
                save_btn.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            textBox3.Text = "";
            Regex rx = new Regex(@"\D", RegexOptions.IgnoreCase);
            textBox1.Text = rx.Replace(textBox1.Text, "");
            textBox1.MaxLength = 3;
            m = textBox1.Text;




            if (((radioButton1.Checked == true || radioButton2.Checked == true) && textBox1.Text != "" && textBox2.Text != "")
                || radioButton3.Checked == true && textBox2.Text != "" && textBox1.Text == "")
            
                button1.Enabled = true;

            else

                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            textBox3.Text = "";
            Regex rx = new Regex(@"\D", RegexOptions.IgnoreCase);
            textBox2.Text = rx.Replace(textBox2.Text, "");
            textBox2.MaxLength = 3;
            n = textBox2.Text;




            if (((radioButton1.Checked == true || radioButton2.Checked == true) && textBox1.Text != "" && textBox2.Text != "")
                 || radioButton3.Checked == true && textBox2.Text != "" && textBox1.Text == "")
            {
                button1.Enabled = true;
                
            }
            else
            {
                
                button1.Enabled = false;
            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            button1.Enabled = false;
            radioButton1.Checked = true;
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            textBox1.Enabled = true;
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
              
                button1.Enabled = true;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            textBox1.Enabled = true;
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";  
            if (textBox1.Text != "" && textBox2.Text != "")
            {
            
                button1.Enabled = true;
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            if (textBox2.Text != "")
            {
                button1.Enabled = true;
            }


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
             if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            const string MY_EXT = ".txt";
            string filename = saveFileDialog2.FileName; 
            string combi = "Сочетание " + Environment.NewLine;
            string place = "Размещение " + Environment.NewLine;
            string permut = "Перестановка " + Environment.NewLine;
            string n_info = "N = " + n + Environment.NewLine;
            string m_info = "M = " + m + Environment.NewLine;
            string result_info = "Результат = " + textBox3.Text + Environment.NewLine;

            if (!MY_EXT.Equals(Path.GetExtension(filename), StringComparison.OrdinalIgnoreCase))
            {
                filename += MY_EXT;
            }

            if (radioButton1.Checked == true)

            {
                File.AppendAllText(filename, combi + n_info + m_info + result_info + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Файл успешно сохранен", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }

            if (radioButton2.Checked == true)
            {
                File.AppendAllText(filename, place + n_info + m_info + result_info + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Файл успешно сохранен", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
            if (radioButton3.Checked == true)
            {
                File.AppendAllText(filename, permut + n_info + result_info + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Файл успешно сохранен", "Save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        }

        private void inf_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте, Вас приветствует Комбинаторный калькулятор" + Environment.NewLine 
            + "Программа позволяет рассчитать три основных формулы комбинаторики, таких как: Сочетание, Размещение и Перестановку" 
            + Environment.NewLine + "Прочтите данную справку если Вы плохо знаете эти формулы, ниже приведено небольшое описание каждой из них"
            + Environment.NewLine 
            + Environment.NewLine + "Сочетание: сколькими способами можно выбрать m объектов из n множества ? Поскольку выборка проводится из множества, состоящего из n оъектов, то справедливо неравенство 0 меньше или равно m меньше или равно n" 
            + Environment.NewLine + "Размещение: сколькими способами можно выбрать m объектов (из n объектов) и в каждой выборке переставить их местами (либо распределить между ними какие-нибудь уникальные атрибуты) ?" 
            + Environment.NewLine + "Перестановка: сколькими способами можно переставить n объектов ?"
            + Environment.NewLine
            + Environment.NewLine + "Все формулы Вы можете увидеть на основном окне, к сожалению наш калькулятор не может рассчитать более 165 факториалов, поэтому не вводите в поля для N и M числа больше 165"
            + Environment.NewLine + "Также Вы можете сохранить свой последний расчет при помоще кнопки Save",
            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
    
}
