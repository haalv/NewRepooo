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

        int xVärde = 100;

        int yVärde = 100;

        bool fårKlicka = true;

        Button b;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(nyStart == true)
            {
                string tag;

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

                    //händelse då knappen trycks
                    knappLista.ElementAt(i).Click += new System.EventHandler(this.klickad);

                    if ((i + 1) % 5 == 0)
                    {
                        xVärde += -500;
                        yVärde += 100;
                    }
                }
            }
        }
        void klickad(object sender, EventArgs e)
        {
            if (fårKlicka == true)
            {
                fårKlicka = false;
                b = sender as Button;
                b.BackColor = Color.FromArgb(255, 0, 0);
                timerKlick.Enabled = true;
            }
        }

        private void timerKlick_Tick(object sender, EventArgs e)
        {
            b.BackColor = Color.FromArgb(255, 255, 255);
            fårKlicka = true;
        }
    }
 
}
