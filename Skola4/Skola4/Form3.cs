using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skola4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void neco(string vstup, ListBox listBox)
        {
            string c = "0123456789";
            vstup = vstup.Trim();
            while (vstup.Contains("  "))
                vstup = vstup.Replace("  ", " ");
            foreach(char ch in c)
            {
                if (vstup.Contains(ch))
                    vstup = vstup.Replace(ch.ToString(), "");
            }
            string[] pole = vstup.Split(' ');
            listBox.Items.Clear();
            foreach(string slovo in pole)
            {
                listBox.Items.Add(slovo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neco(textBox1.Text, listBox1);
        }
    }
}
