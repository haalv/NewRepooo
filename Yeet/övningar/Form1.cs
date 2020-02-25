using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övningar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rndm = new Random();

        int[] kast = new int[6];

        int kastVärde;

        string[] resultatLista = new string[7];

        int summa;

        void kastaTärningar()
        {
            summa = 0;
            for(int i = 0; i < 6; i++)
            {
                kastVärde = rndm.Next(1, 7);
                kast[i] = kastVärde;
                summa += kastVärde;
            }
        }

        void resultat()
        {
            tbxShow.Text = "";
            for (int i = 0; i < 6; i++)
            {
                resultatLista[i] = "Tärning " + (i + 1).ToString() + ":    " + kast[i].ToString();
                tbxShow.Text += resultatLista[i] + "\r\n";
            }
            resultatLista[6] = "\r\n" + "Antal prickar: " + summa.ToString();
            tbxShow.Text += resultatLista[6];
        }

        private void BtnKasta_Click(object sender, EventArgs e)
        {
            
            kastaTärningar();
            resultat();
        }
    }
}
