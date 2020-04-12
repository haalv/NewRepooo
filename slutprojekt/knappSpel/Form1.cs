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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> knappLista = new List<Button>();

        bool nyStart = true;

        bool startaSpel;

        int xVärde = 100;

        int yVärde = 100;

        List<int> matchningsLista = new List<int>();

        bool fårKlicka;

        Button b;

        Button b2;

        Random random = new Random();

        int värde;

        int räknare = 0;

        int ronder = 4;

        bool spela;

        bool simulation;

        bool restart = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(nyStart == true)
            {
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
                        knappLista.ElementAt(i).BackColor = Color.FromArgb(255, 255, 255);
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
                nyStart = false;
                btnStart.Text = "börja nivå";
            }
            else if(startaSpel == true)
            {
                simulationTimer.Enabled = true;
                startaSpel = false;
                simulation = true;
            }
        }

        //Händelsen när en knapp trycks
        void klickad(object sender, EventArgs e)
        {
            if(simulation == true)
            {
                if (fårKlicka == true)
                {
                    b2 = b;
                    fårKlicka = false;
                    b2 = sender as Button;
                    b2.BackColor = Color.FromArgb(255, 0, 0);
                    timerKlick.Enabled = true;
                }
            }

            //om spelaren klickar
            else if(spela == true)
            {
                b = sender as Button;
                b.BackColor = Color.FromArgb(255, 0, 0);
                timerKlick.Enabled = true;
                if(int.Parse(b.Tag.ToString()) != matchningsLista[räknare])
                {
                    spela = false;
                    ronder = 4;
                    räknare = 0;
                    MessageBox.Show("Du förlorade precis, kompis.");
                    nyStart = true;
                    btnStart.Text = "Starta";
                    matchningsLista.Clear();
                }
                else
                {
                    räknare++;
                    if(räknare == ronder)
                    {
                        MessageBox.Show("Grattis du klarade nivå " + (ronder - 3) + "!");
                        ronder++;
                        räknare = 0;
                        matchningsLista.Clear();
                        startaSpel = true;
                        lblNivå.Text = "Nivå " + (ronder - 3);
                        spela = false;
                    }
                }
            }
        }

        private void timerKlick_Tick(object sender, EventArgs e)
        {
            b.BackColor = Color.FromArgb(255, 255, 255);

            b2.BackColor = Color.FromArgb(255, 255, 255);

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

            if (räknare == ronder)
            {
                simulationTimer.Enabled = false;
                räknare = 0;
                spela = true;
                simulation = false;
            }
        }
    }
 
}
