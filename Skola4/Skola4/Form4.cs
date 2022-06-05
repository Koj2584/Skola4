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
            int p = a;
            int[] pole = new int[0];
            int i = 1;
            while(!JePrvocislo(a)&&i<=a)
            {
                if(JePrvocislo(i)&&a%i==0)
                {
                    while(a % i == 0)
                    {
                        a = a / i;
                        pole = pole.Concat(new int[] { i }).ToArray();
                    }
                }
                i++;
            }
            if(JePrvocislo(a) || p == 1)
                pole = pole.Concat(new int[] { a }).ToArray();
            return pole;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "NSN: " + NSN((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            label2.Text = "NSD: " + NSD((int)numericUpDown1.Value, (int)numericUpDown2.Value);

            int[] pole = Rozklad((int)numericUpDown1.Value);
            int[] pole2 = Rozklad((int)numericUpDown2.Value);

            listBox1.Items.Clear();
            listBox1.Items.Add("Rozklad:");
            foreach(int i in pole)
            {
                listBox1.Items.Add(i);
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Rozklad:");
            foreach (int i in pole2)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
