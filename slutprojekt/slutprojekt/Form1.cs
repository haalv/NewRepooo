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

        int yVärde = 50;


        //Skapa gamemodes
        int easy = 25;


        int xVärde = 50;

        int nyRad = 1;

        bool fårKlicka = true;

        int nivå = 0;


        void skapaKnappar()
        {

            for (int i = 0; i < mode; i++)
            {
                //lägg till en knapp i knapplistan
                knappLista.Add(new Button());



                //Ge egenskaper till knapp i knapplistan
                knappLista.ElementAt(i).Location = new System.Drawing.Point((xVärde + (i*50)), yVärde);
                knappLista.ElementAt(i).Size = new System.Drawing.Size(20, 20);
                knappLista.ElementAt(i).UseVisualStyleBackColor = true;
                knappLista.ElementAt(i).TabIndex = 0;
                knappLista.ElementAt(i).BackColor = Color.FromArgb(255, 255, 255);
                knappLista.ElementAt(i).Tag = i.ToString();

                //Lägg till knappen i Formen
                this.Controls.Add(this.knappLista.ElementAt(i));

                //händelse då knappen trycks
                knappLista.ElementAt(i).Click += new System.EventHandler(this.click);

                knappLista.ElementAt(i).Name = i.ToString();
                if (nyRad % 5 == 0)
                {
                    yVärde += 50;

                    xVärde -= 250;
                }
                nyRad++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
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
            }
            fårKlicka = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            referens.BackColor = Color.FromArgb(255, 255, 255);
            timerPress.Enabled = false;
            fårKlicka = true;
        }
    }
}
