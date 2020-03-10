using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slutprojekt
{
    public partial class Form1 : Form
    {
        //Skapa en lista med knappar
        List<Button> knappLista = new List<Button>();

        int btnNumber;

        int mode;

        public Form1()
        {
            InitializeComponent();
        }

        int räknare = 0;

        int yVärde = 100;


        //Skapa gamemodes
        int easy = 25;

        //Skapa en random int
        Random random = new Random();

        //Skapa en lista med tagföljd

        List<int> taglista = new List<int>();

        int tag;

        int räknareEasy = 0;

        int xVärde = 100;

        //en bool som säger om du får spela
        bool spela = false;

        int nyRad = 1;

        bool fårKlicka = true;

        int nivå = 0;

        int värde;

        int limit = 2;

        int räknare3 = 0;

        void skapaKnappar()
        {

            for (int i = 0; i < mode; i++)
            {
                //lägg till en knapp i knapplistan
                knappLista.Add(new Button());



                //Ge egenskaper till knapp i knapplistan
                knappLista.ElementAt(i).Location = new System.Drawing.Point((xVärde + (i*100)), yVärde);
                knappLista.ElementAt(i).Size = new System.Drawing.Size(50, 50);
                knappLista.ElementAt(i).UseVisualStyleBackColor = true;
                knappLista.ElementAt(i).TabIndex = 0;
                knappLista.ElementAt(i).BackColor = Color.FromArgb(255, 255, 255);
                knappLista.ElementAt(i).Tag = i;

                //Lägg till knappen i Formen
                this.Controls.Add(this.knappLista.ElementAt(i));

                //händelse då knappen trycks
                knappLista.ElementAt(i).Click += new System.EventHandler(this.click);

                knappLista.ElementAt(i).Name = i.ToString();
                if (nyRad % 5 == 0)
                {
                    yVärde += 100;

                    xVärde -= 500;
                }
                nyRad++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;

            mode = easy;

            skapaKnappar();

            nivå = 1;

            lblNivå.Text = "Nivå: " + nivå.ToString();
        }

        Button referens;
        //Skapa en referensknapp som utför händelser

        private void click(object sender, EventArgs e)
        {
            if(fårKlicka == true)
            {
                referens = sender as Button;
                referens.BackColor = Color.FromArgb(255, 0, 0);
                //knappLista.ElementAt(0).BackColor = Color.FromArgb(255,0,0);
                timerPress.Enabled = true;
                if (spela == true)
                {
                    if ((int)referens.Tag != taglista[räknare3])
                      {
                        MessageBox.Show("Det var fel knapp kompis");
                      }
                    räknare3++;
                    if (räknare3 == (limit-1))
                    {
                        räknare3 = 0;
                        taglista.Clear();
                    }

                }
            }
            fårKlicka = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            referens.BackColor = Color.FromArgb(255, 255, 255);
            timerPress.Enabled = false;
            fårKlicka = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(mode == easy)
            {
                timerStart.Interval = 750;
                timerStart.Enabled = true;
            }
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            if(mode == easy)
            {
                if(räknareEasy <= limit)
                {
                    värde = random.Next(0, 25);
                    foreach (Button b in knappLista)
                    {
                        if ((int)b.Tag == värde)
                        {
                            taglista.Add((int)b.Tag);
                            fårKlicka = true;
                            b.PerformClick();
                        }
                    }
                    räknareEasy++;
                }
            }
            if(räknareEasy == limit)
            {
                limit++;
                räknareEasy = 0;
                timerStart.Enabled = false;
                spela = true;
            }
        }
    }
}
