using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasilev5
{

  
    enum Bank { текущий, сберегательный}

    struct Bank_Info
    {
        public int number;
        public Bank type;
        public double balance;
    }

    enum University { КемГУ, НГАХА, МФТИ, ТУСУР }
    struct Student
    {
        public string name;
        public University university;
    }

    public partial class Form1 : Form
    {
        internal int iEx1 = 1;
        internal int iEx2 = 1;
        internal string[] names = new string[] {"София", "Михаил", "Дарья", "Юлия","Маргарита","Марк","Акулбек","Константин", "Валерий", "НикитаЛучший"};
        internal Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Задание 1\n";
            richTextBox2.Text = "Задание 2\n";
            richTextBox3.Text = "Задание 3\n";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< Ex1.Value; i++)
            {
                Bank bank = new Bank();
                bank = (Bank)rnd.Next(0, 2);
                richTextBox1.Text += $"-------\n{iEx1}: {bank}\n";
                iEx1++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Задание 1\n";
            iEx1 = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ex2.Value; i++)
            {
                Bank_Info bankInfo = new Bank_Info();
                bankInfo.number = iEx2;
                iEx2++;

                bankInfo.type = (Bank)rnd.Next(0, 2);

                bankInfo.balance = (double) Math.Round(rnd.NextDouble()*100000, 2);
                richTextBox2.Text += $"-------\nНомер счёта: {bankInfo.number}\nТип счёта: {bankInfo.type}\nБаланс: {bankInfo.balance} $\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Задание 2\n";
            iEx2 = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ex3.Value; i++)
            {
                Student student = new Student();
                student.name = names[rnd.Next(0, names.Length)];
                student.university = (University)rnd.Next(0, 4);

                richTextBox3.Text += $"-------\nИмя: {student.name}\nУниверситет: {student.university}\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "Задание 3\n";
        }
    }
}
