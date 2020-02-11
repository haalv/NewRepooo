using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        bool siffra;
        void tecken()
        {
            char karaktär = Convert.ToChar(tbxTecken.Text);
            if((int)karaktär < 58 && karaktär > 47)
            {
                siffra = true;
            }
            else
            {
                siffra = false;
            }
        }

        private void BtnKör_Click(object sender, EventArgs e)
        {
            tecken();
            if (siffra == true)
            {
                lblShow.Text = "Tecken är en siffra";
            }
            else
            {
                lblShow.Text = "Tecken är inte en siffra";
            }

        }
    }
}
