using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knappSpel
{
    public partial class Form2 : Form
    {
        Label highscore;

        //ints
        int räknare;

        int plats;

        public Form2(Label highscoreLabel)
        {
            InitializeComponent();
            highscore = highscoreLabel;
            lblVisaPoäng.Text = "Slutpoäng: " + Form1.poäng;
            räknare = 0;
        }

        //Listor
        public static List<int> poängLista = new List<int>();

        List<string> poängtavla = new List<string>();

        List<string> namnLista = new List<string>();

        //Bools
        public static bool nyStart { get; set; }

        //strings
        string namn;

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxNamn.Text.Length <= 8)
            {
                namn = tbxNamn.Text;
                namnLista.Add(namn);
                poängLista.Add(Form1.poäng);
                if (poängLista.Count != 0)
                {
                    for (int i = 0; i < poängLista.Count; i++)
                    {
                        if (Form1.poäng >= poängLista[i])
                        {
                            räknare++;
                        }
                    }
                    plats = poängLista.Count - räknare;
                    poängtavla.Insert(plats, namn + "  " + Form1.poäng);
                    highscore.Text = "Highscore lista" + "\r\n";
                    for(int i = 0; i<poängLista.Count; i++)
                    {
                        highscore.Text += poängtavla[i] + "\r\n";
                    }
                }
                else
                {
                    poängtavla.Add(namn + "  " + Form1.poäng);
                    highscore.Text += poängtavla[0];
                }

                Form1.highscore.Close();
            }
            else
            {
                MessageBox.Show("Felinmatning");
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            nyStart = true;
        }
    }
}
