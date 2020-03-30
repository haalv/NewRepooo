using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glass g = new Glass();
            g.antalKulor = 3;
            g.behållare = "Rån";
        }
    }
    public class Glass
    {
        //Variabler //Medlemsvariabler
        public string behållare;

        public int antalKulor;

        //Konstruktorer
        public Glass()
        {
            MessageBox.Show("Nu skapades en tomm glass");
        }
        public Glass(int antalkulor, string behållare)
        {
            this.behållare = behållare;
            this.antalKulor = antalkulor;
            MessageBox.Show("Nu skapades en glass med " + antalKulor.ToString() + " kulor, och " + behållare);
        }

        public void smält()
        {
            MessageBox.Show("");
        }
    }
}
