using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tal;

        bool primtal;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        

        void metod()
        {
            tal = int.Parse(tbxTal.Text);
            int räknare = 0;
            for(int i = tal; i>0; i--)
            {
                int modulus = tal % i;

                if(modulus == 0)
                {
                    räknare++;
                }
            }
            if(räknare == 2)
            {
                primtal = true;
            }
            else
            {
                primtal = false;
            }
        }


        private void BtnKör_Click(object sender, EventArgs e)
        {
            metod();

            if(primtal == true)
            {
                lblShow.Text = "Talet är ett primtal";
            }
            else if(primtal == false)
            {
                lblShow.Text = "Talet är inte ett primtal";
            }
        }

        private void TbxTal_TextChanged(object sender, EventArgs e)
        {
            primtal = false;
        }
    }
}
