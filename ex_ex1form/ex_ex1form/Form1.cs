using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ex_ex1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string g = textBox1.Text;
            int n = Convert.ToInt32(textBox2.Text);
            string sp = textBox3.Text;
            Dekanat group = new Dekanat(g, n, sp);
            string dek = group.Writenew();
            richTextBox1.Text += dek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            string s = textBox1.Text;
            int p = Convert.ToInt32(textBox2.Text);
            int gr = Convert.ToInt32(textBox3.Text);
            Visiting visiting = new Visiting(s, p, gr);
            string vis = visiting.Writenew();
            richTextBox2.Text += vis;
            int a = visiting.Subtract1();
            int a1 = visiting.Subtract1();
            string a2 = visiting.Subtract2();
            string pr;
            pr = ($"Pass without reason:{a} - {a1}% {a2}");
            richTextBox2.Text += pr;
        }
    }
}
