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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        bool JePrvocislo(int cislo)
        {
            bool vysledek = (cislo % 2 != 0 || cislo == 2) && !(cislo == 1 || cislo == 0);
            for (int i = 3; i <= Math.Sqrt(cislo) && vysledek != false; i += 2)
            {
                vysledek = cislo % i != 0;
            }
            return vysledek;
        }

        int NSD(int a, int b)
        {
            if(a<b)
            {
                int p = a;
                a = b;
                b = p;
            }

            int nsd = 1;
            for(int i = 2; i <= b;i++)
            {
                if (b % i == 0 && a % i == 0)
                    nsd = i;
            }
            return nsd;
        }

        int NSN(int a, int b)
        {
            if (a < b)
            {
                int p = a;
                a = b;
                b = p;
            }

            for (int i = 2;i<=b;i++)
            {
                int p = b * i;
                if (p % a == 0)
                    return p;
            }
            return b * a;
        }

        int[] Rozklad(int a)
        {
            int pole = new int();
            int i = 2;
            while(JePrvocislo(a))
            {
                if (JePrvocislo(i)&&a%i==0)
                {
                    a = a / i;
                }
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(NSN((int)numericUpDown1.Value, (int)numericUpDown2.Value));
        }
    }
}
