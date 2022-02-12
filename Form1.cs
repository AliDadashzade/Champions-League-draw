using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champions_League_draw
{
    public partial class Form1 : Form
    {
        List<Teams> takimlar;
        List<ListBox> torbalar= new List<ListBox> ();
        List<ListBox> gruplar=new List<ListBox> ();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Teams yenitakim = null;
            takimlar = new List<Teams> ();
            yenitakim = new Teams("Barcelona", "Spain");
            takimlar.Add (yenitakim);
            yenitakim = new Teams("Real Madrid", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Valencia", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Sevilla", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Bayern Munich", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Borussia Dortmund", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Leipzig", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("PSG", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Lyon", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Lille", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Chelsea", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Arsenal", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Manchester City", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Manchester United", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Liverpool", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Inter", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Milan", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Roma", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Napoli", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Lazio", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Besiktas", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Galatasaray", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Fenerbahce", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Trabzonspor", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Basel", "Switzerland");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Astana", "Kazakhistan");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Zenit", "Russia");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("CSKA Moskva", "Russia");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Bayern Leverkusen", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Dynamo Kiev", "Ukraine");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Porto", "Portugal");
            takimlar.Add(yenitakim);
            yenitakim = new Teams("Benfica", "Portugal");
            takimlar.Add(yenitakim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Random rastgele=new Random();
            List<int> secilentakimlar=new List<int>();
            for(int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0, takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for(int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    Torba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    Torba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    Torba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if(i<32)
                {
                    Torba4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(Torba1);
            torbalar.Add(Torba2);
            torbalar.Add(Torba3);
            torbalar.Add(Torba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = ayniulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Teams);
                    if (ayniulkedentakimvar)
                    {
                        break;
                    }
                    if (!ayniulkedentakimvar)
                    {
                        listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Teams);
                        listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Teams);
                        listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Teams);
                        listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Teams);
                        listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Teams);
                        listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Teams);
                        listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Teams);
                        listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Teams);
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            
            bool ayniulkedentakimvarmi(ListBox grup, Teams takim)
            {
                bool durum = false;
                for (int i = 0; i < grup.Items.Count; i++)
                {
                    Teams gruptakim = grup.Items[i] as Teams;
                    if (gruptakim.CountryName == takim.CountryName)
                    {
                        durum = true;
                        break;
                    }
                }
                return durum;
            }
        }
    }
}
