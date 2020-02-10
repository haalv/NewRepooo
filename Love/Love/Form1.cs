using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        Random random = new Random();

         
        void love()
        {
            pcbx1.Image = Image.FromFile("C:\\Users\\haalv0223\\Pictures\\Hearts" + "\\" + random.Next(1, 11).ToString() + ".png");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            love();
        }

        private void Pcbx3_Click(object sender, EventArgs e)
        {

        }

        private void Pcbx1_Click(object sender, EventArgs e)
        {

        }
    }
}
