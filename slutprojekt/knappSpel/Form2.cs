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
    public partial class Highscore_Lista : Form
    {
        //label
        Label highscore;

        //ints
        int räknare = 0;

        int plats;

        public Highscore_Lista(Label highscoreLabel)
        {
            InitializeComponent();
            highscore = highscoreLabel;

            //Ta bort alternativ för att manipulera fönstret
            this.ControlBox = false;
        }

        //Listor
        public static List<int> poängLista = new List<int>();

        List<string> poängtavla = new List<string>();

        //Bools
        public static bool nyStart { get; set; }

        //strings
        string namn;

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxNamn.Text.Length <= 8 && tbxNamn.Text.Length >= 1)
            {
                //Lägg in spelarens poäng i en poänglista
                namn = tbxNamn.Text;
                poängLista.Add(KnappSpel.poäng);
                if (poängLista.Count > 1)
                {
                    //Loopa igenom alla poäng och bestäm spelarens plats i highscore listan
                    for (int i = 0; i < poängLista.Count; i++)
                    {
                        if (KnappSpel.poäng >= poängLista[i])
                        {
                            räknare++;
                        }
                    }
                    plats = poängLista.Count - räknare;
                    //Gör en sträng av spelarens namn och respektive poäng på rätt plats i listan
                    poängtavla.Insert(plats, namn + "  " + KnappSpel.poäng);
                    //Skriv om highscore listan med den nya spelarens poäng
                    highscore.Text = "Highscore lista" + "\r\n";
                    for(int i = 0; i<poängLista.Count; i++)
                    {
                        highscore.Text += poängtavla[i] + "\r\n";
                    }
                }
                //Om det är den absolut första spelaren att spela så sätts spelarens poäng som högsta highscore
                else
                {
                    poängtavla.Add(namn + "  " + KnappSpel.poäng);
                    highscore.Text += poängtavla[0];
                }
                //återställ spelet och göm highscore formen
                räknare = 0;
                nyStart = true;
                tbxNamn.Text = "";
                this.Hide();
            }
            else
            {
                //Om spelaren angiver ett namn utanför restriktionerna
                MessageBox.Show("Felinmatning");
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            //slutpoängen visas när formen aktiveras
            lblVisaPoäng.Text = "Slutpoäng: " + KnappSpel.poäng;
        }
    }
}
