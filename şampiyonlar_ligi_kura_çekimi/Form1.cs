using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şampiyonlar_ligi_kura_çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar=new List<ListBox>();
        List<ListBox> gruplar=new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakım = null;
            takimlar=new List<Takim>();

            yenitakım = new Takim(" Bayern Münih", "Almanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" FC Barcelona ", "İspanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Real Madrid ", "İspanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Milan ", "İtalya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Inter ", "İtalya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Manchester United ", "İngiltere");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Basel", "İsviçre");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Young Boys ", "İsviçre");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Fenerbahçe", "Türkiye");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Galatasaray ", "Türkiye");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Beşiktaş ", "Türkiye");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Borissia Dortmund", "Almanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Chelsea", "İngiltere");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Manchester City ", "İngiltere");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Napoli ", "İtalya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Victoria Plzen ", "Çek Cumhuriyeti");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Celtic", "İskoçya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Glasgov Rangers", "İskoçya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Ajax", "Hollanda");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Feyenoord", "Hollanda");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" PSV ", "Hollanda");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Paris an German ", "Fransa");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" O Marsilya ", "Fransa");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" O Lyon ", "Fransa");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Rennes", "Fransa");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Steau Bucrest", "Romanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim( " Cluj ", "Romanya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Juventus", "İtalya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Zenit ", "Rusya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Spartak Moskova", "Rusya");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Trabzonspor ", "Türkiye");
            takimlar.Add(yenitakım);
            yenitakım = new Takim(" Liverpool ", "İngiltere");
            takimlar.Add(yenitakım);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele=new Random();
            List<int> seçilentakımlar=new List<int>();
            for(int i = 0; i < takimlar.Count; i++)
            {
                int seçilentakım = rastgele.Next(0, takimlar.Count);
                if (seçilentakımlar.Contains(seçilentakım))
                {
                    i--;
                }
                else
                {
                    seçilentakımlar.Add(seçilentakım);
                }
            }
            for(int i = 0; i < seçilentakımlar.Count; i++)
            {
                if (i < 8)
                {
                    Lsttorba1.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else if (i < 16)
                {
                    Lsttorba2.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else if (i < 24)
                {
                    Lsttorba3.Items.Add(takimlar[seçilentakımlar[i]]);
                }
                else
                {
                    Lsttorba4.Items.Add(takimlar[seçilentakımlar[i]]);
                }
            }
            torbalar.Add(Lsttorba1);
            torbalar.Add(Lsttorba2);
            torbalar.Add(Lsttorba3);
            torbalar.Add(Lsttorba4);

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
                List<int> seçilentakımlar = new List<int>();
                for (int j = 0; j < 4; j++)
                {
                    seçilentakımlar.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        int seçilentakım = rastgele.Next(0, takimlar.Count / 4);

                        if (seçilentakımlar.Contains(seçilentakım))
                        {
                            i--;
                        }
                        else
                        {
                            seçilentakımlar.Add(seçilentakım);
                        }
                    }
                    bool aynıülkedentakımvar = false;
                    for (int k = 0; k < 8; k++)
                    {
                        aynıülkedentakımvar = aynıülkedentakımvarmi(gruplar[k], torbalar[j].Items[seçilentakımlar[k]] as Takim);
                        if (aynıülkedentakımvar)
                            break;
                    }
                    if (!aynıülkedentakımvar)
                    {
                        listBox1.Items.Add(torbalar[j].Items[seçilentakımlar[0]] as Takim);
                        listBox2.Items.Add(torbalar[j].Items[seçilentakımlar[1]] as Takim);
                        listBox3.Items.Add(torbalar[j].Items[seçilentakımlar[2]] as Takim);
                        listBox4.Items.Add(torbalar[j].Items[seçilentakımlar[3]] as Takim);
                        listBox5.Items.Add(torbalar[j].Items[seçilentakımlar[4]] as Takim);
                        listBox6.Items.Add(torbalar[j].Items[seçilentakımlar[5]] as Takim);
                        listBox7.Items.Add(torbalar[j].Items[seçilentakımlar[6]] as Takim);
                        listBox8.Items.Add(torbalar[j].Items[seçilentakımlar[7]]as Takim);
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            private bool aynıülkedentakımvarmi(ListBox grup, Takim takim)
            {
                bool durum = false;
                for (int i = 0; i < grup.Items.Count; i++)
                {
                    Takim gruptakim = grup.Items[i] as Takim;
                    if (gruptakim.teamcountry == takim.teamcountry)
                    {
                        durum = true;
                        break;
                    }
                }
                return durum;
            }
        }
    }
