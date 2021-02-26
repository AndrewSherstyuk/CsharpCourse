using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            int yearOfBirth = Convert.ToInt32(text);

            var yearCurrent = Convert.ToInt32(DateTime.Now.Year);

            int age = yearCurrent - yearOfBirth;

            textBox2.Text = $"{age}";
        }
    }
}
