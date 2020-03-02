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


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lägg till en knapp i knapplistan
            knappLista.Add(new Button());

            //Ge egenskaper till knapp i knapplistan
            knappLista.ElementAt(0).Location = new System.Drawing.Point(50, 50);
            knappLista.ElementAt(0).Size = new System.Drawing.Size(20, 20);
            knappLista.ElementAt(0).UseVisualStyleBackColor = true;
            knappLista.ElementAt(0).TabIndex = 0;
            knappLista.ElementAt(0).Text = "Knapp 1";

            this.Controls.Add(this.knappLista.ElementAt(0));

            knappLista.ElementAt(0).Click += new System.EventHandler(this.click);
        }

        private void click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show("Hej på mig står det" + b.Text);
        }
    }
}
