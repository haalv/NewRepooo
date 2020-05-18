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
    public partial class KnappSpel : Form
    {
        public KnappSpel()
        {
            InitializeComponent();
            Highscore_Lista.nyStart = true;
            lblPoänglista.Text = "Highscore lista" + "\r\n";
            highscore = new Highscore_Lista(lblPoänglista);
        }

        //Forms
        public static Highscore_Lista highscore;

        //Listor
        List<Button> knappLista = new List<Button>();

        List<int> matchningsLista = new List<int>();

        //Buttons
        Button b;

        Button b2;

        //Random
        Random random = new Random();

        //Ints
        int värde;

        int räknare = 0;

        int ronder = 4;

        int xVärde = 100;

        int yVärde = 100;

        int liv;

        public static int poäng = 0;

        //Bools
        bool spela;

        bool restart = false;

        bool fårKlicka;

        bool startaSpel;

        bool spelknapp;

        bool vinstLjud;

        bool förlustLjud;

        bool startLjud;

        bool slutPåLiv;

        bool felKnapp;

        bool simulation;

        //Ljudfiler
        System.Media.SoundPlayer klickadKnapp = new System.Media.SoundPlayer("KlickLjud_Knapp.wav");

        System.Media.SoundPlayer vinst = new System.Media.SoundPlayer("music.wav");

        System.Media.SoundPlayer förlust = new System.Media.SoundPlayer("Bruh.wav");

        System.Media.SoundPlayer start = new System.Media.SoundPlayer("StartLjud.wav");

        System.Media.SoundPlayer felLjud = new System.Media.SoundPlayer("wrong.wav");

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Highscore_Lista.nyStart == true)
            {
                lblLiv.Text = "Liv: " + liv;

                lblNivå.Text = ("Nivå 1");

                if(restart == false)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        knappLista.Add(new Button());

                        //Ge egenskaper till knapp i knapplistan
                        knappLista.ElementAt(i).Location = new System.Drawing.Point((xVärde + (i * 100)), yVärde);
                        knappLista.ElementAt(i).Size = new System.Drawing.Size(50, 50);
                        knappLista.ElementAt(i).UseVisualStyleBackColor = true;
                        knappLista.ElementAt(i).TabIndex = 0;
                        knappLista.ElementAt(i).BackColor = Color.White;
                        knappLista.ElementAt(i).Tag = i;

                        //Lägg till knappen i Formen
                        this.Controls.Add(this.knappLista.ElementAt(i));

                        //händelse då knappen trycks ändras
                        knappLista.ElementAt(i).Click += new System.EventHandler(this.klickad);

                        if ((i + 1) % 5 == 0)
                        {
                            xVärde += -500;
                            yVärde += 100;
                        }
                    }
                    restart = true;
                }
                startaSpel = true;
                Highscore_Lista.nyStart = false;
                btnStart.Text = "börja nivå";
                liv = 3;
                lblLiv.Text = "Liv: " + liv;
                poäng = 0;
                lblPoäng.Text = "Poäng: " + poäng;
            }
            else if(startaSpel == true)
            {
                startLjud = true;
                Ljud();
                simulationTimer.Enabled = true;
                startaSpel = false;
            }
        }

        void Ljud()
        {
            if(felKnapp == true)
            {
                felLjud.Play();
                felKnapp = false;
            }
            else if (spelknapp == true)
            {
                klickadKnapp.Play();
                spelknapp = false;
            }
            else if(vinstLjud == true)
            {
                vinst.Play();
                vinstLjud = false;
            }
            else if(förlustLjud == true)
            {
                förlust.Play();
                förlustLjud = false;
            }
            else if(startLjud == true)
            {
                start.Play();
                startLjud = false;
            }
        }

        //Händelsen när en knapp trycks
        void klickad(object sender, EventArgs e)
        {
            //simulationen
            if (fårKlicka == true)
            {
                simulation = true;
                 b2 = b;
                 fårKlicka = false;
                 b2 = sender as Button;
                 b2.BackColor = Color.Red;
                 spelknapp = true;
                 Ljud();
                 timerKlick.Enabled = true;
            }

            //om spelaren klickar
            else if(spela == true)
            {
                b = sender as Button;
                b.BackColor = Color.Red;
                spela = false;
                timerKlick.Enabled = true;

                //Ifall spelaren förlorar
                if (int.Parse(b.Tag.ToString()) != matchningsLista[räknare] && slutPåLiv == true)
                {
                    simulation = true;
                    liv = 3;
                    slutPåLiv = false;
                    ronder = 4;
                    räknare = 0;
                    förlustLjud = true;
                    Ljud();
                    MessageBox.Show("Du förlorade precis, kompis.");
                    highscore.Show();
                    btnStart.Text = "Starta";
                    matchningsLista.Clear();
                }
                //Ifall spelaren klickar rätt knapp
                else if(int.Parse(b.Tag.ToString()) == matchningsLista[räknare])
                {
                    poäng += (ronder - 3);
                    lblPoäng.Text = "Poäng: " + poäng;
                    räknare++;
                    spelknapp = true;
                    //Om du vinner
                    if(räknare == ronder)
                    {
                        poäng += (ronder-3)*10;
                        lblPoäng.Text = "Poäng: " + poäng;
                        spelknapp = false;
                        vinstLjud = true;
                        Ljud();
                        slutPåLiv = false;
                        MessageBox.Show("Grattis du klarade nivå " + (ronder - 3) + "!");
                        vinst.Stop();
                        ronder++;
                        räknare = 0;
                        matchningsLista.Clear();
                        startaSpel = true;
                        lblNivå.Text = "Nivå " + (ronder - 3);
                        spela = false;
                        liv = 3;
                        lblLiv.Text = "Liv :" + liv;
                    }
                    else
                    {
                        Ljud();
                    }
                }
                //ifall spelaren väljer fel knapp
                else
                {
                    felKnapp = true;
                    Ljud();
                    liv--;
                    lblLiv.Text = "Liv: " + liv;
                    if (liv == 0)
                    {
                        slutPåLiv = true;
                    }
                }
            }
        }

        private void timerKlick_Tick(object sender, EventArgs e)
        {
            b.BackColor = Color.White;

            b2.BackColor = Color.White;
            
            if(simulation == false)
            {
                spela = true;
            }
            else
            {
                spela = false;
            }

            timerKlick.Enabled = false;
        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            värde = random.Next(0, 25);
            b = knappLista.ElementAt(värde);
            fårKlicka = true;
            b.PerformClick();

            matchningsLista.Add(new int());
            matchningsLista[räknare] = int.Parse(b.Tag.ToString());

            räknare++;

            if (räknare == ronder && simulation == true)
            {
                simulationTimer.Enabled = false;
                räknare = 0;
                spela = true;
                simulation = false;
            }
        }
    }
 
}
