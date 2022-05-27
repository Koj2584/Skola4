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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ObsahujeSlovo(string vstup, out string nejV, out string nejM)
        {
            nejV = "";
            nejM = "";
            vstup = vstup.Trim();
            if (vstup.Length < 1)
                return false;
            while (vstup.Contains("  "))
                vstup = vstup.Replace("  ", " ");
            string[] pole = vstup.Split(' ');

            int predchoziV = 0, predchoziM = 10000;
            foreach(string s in pole)
            {
                if(s.Length > predchoziV)
                {
                    nejV = s;
                    predchoziV = s.Length;
                }
                if (s.Length < predchoziM)
                {
                    nejM = s;
                    predchoziM = s.Length;
                }
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nejV, nejM;
            bool vysl = ObsahujeSlovo(textBox1.Text, out nejV, out nejM);
            label1.Text = String.Format("{0}bsahuje slova. {1}",vysl ? "O":"Neo",vysl?"Nejdelší slovo: "+nejV+". Nejkratší slovo: "+nejM+".":"");
        }
    }
}
