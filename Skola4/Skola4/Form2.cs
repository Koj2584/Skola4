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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool JeAlfanum(string vstup, out int mala, out int velka, out int jinaci)
        {
            string alfanum = "0123456789qwertzuiopasdfghjklyxcvbnmůúěščřžýáíéóQWERTZUIOPASDFGHJKLYXCVBNMŮÚĚŠČŘŽÝÁÍÉÓ";
            string vel = "QWERTZUIOPASDFGHJKLYXCVBNMŮÚĚŠČŘŽÝÁÍÉÓ";
            string mal = "qwertzuiopasdfghjklyxcvbnmůúěščřžýáíéó";
            bool vysledek = true;

            mala = 0;
            velka = 0;
            jinaci = 0;

            foreach(char c in vstup)
            {
                if (!alfanum.Contains(c))
                {
                    vysledek = false;
                    jinaci++;
                }
                if (vel.Contains(c))
                    velka++;
                if (mal.Contains(c))
                    mala++;
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mala, velka, jinaci;
            bool vysl = JeAlfanum(textBox1.Text, out mala, out velka, out jinaci);

            label1.Text = String.Format("Řetězec {0} alfanumerický. Počet malích písmen: {1}. Počet velkých písmen: {2}. Počet jinačích písmen: {3}.", vysl ? "je": "není", mala, velka, jinaci);
        }
    }
}
