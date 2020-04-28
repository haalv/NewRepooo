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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Listor
        public static List<string> spelarLista = new List<string>();

        public static List<int> poängLista = new List<int>();

        //Bool
        public static bool nyStart { get; set; }

        string namn;
        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxNamn.Text.Length <= 8)
            {
                namn = tbxNamn.Text;
                spelarLista.Add(namn);
                poängLista.Add(Form1.poäng);
                Form1.highscore.Close();
            }
            else
            {
                MessageBox.Show("Felinmatning");
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            nyStart = true;
        }
    }
}
