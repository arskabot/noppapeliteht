using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noppapeliteht
{
    public partial class Form1 : Form
    {
        public PictureBox Boxi;
        public int Koko;

        public Form1()
        {
            InitializeComponent();

        }

        // 1. nappia voi painaa vain kerran
        // 2. voiton tarkistus
        // 3. resetointi

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int noppa1;


            noppa1 = rnd.Next(1, 7);
            label1.Text = noppa1.ToString();
            button1.Enabled = false;

            pictureBox1.Image = GetPictureResX(GetNoppaKey(noppa1));

            //if (label2.Text != "")
            if (button2.Enabled == false)
            {
                checkWinner();

            }



        }
      


        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int noppa2;


            noppa2 = rnd.Next(1, 7);
            label2.Text = noppa2.ToString();
            button2.Enabled = false;
            pictureBox2.Image = GetPictureResX(GetNoppaKey(noppa2));

            if (button1.Enabled == false)
            {
                checkWinner();

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            pictureBox1.Image = null;
            pictureBox2.Image = null;


        }
        private void checkWinner()
        {
            int arvo1 = Convert.ToInt32(label1.Text);
            int arvo2 = Convert.ToInt32(label2.Text);

            if (arvo1 > arvo2)
            {
                label3.Text = "Pelaaja 1 Voitti";

            }

            if (arvo1 < arvo2)
            {
                label3.Text = "Pelaaja 2 Voitti";

            }
            if (arvo1 == arvo2)
            {
                label3.Text = "Tasapeli";

            }
        }
        public string GetNoppaKey(int noppa1) // "N1" - "N6"
        {
            string returnValue = "N"; // Noppa picture filenames begin with Text "N" in NoppaPictures.resx

            return returnValue + noppa1;
        }


        public static Image GetPictureResX(string key)
        {
            return noppapeliteht.noppakuvat.ResourceManager.GetObject(key) as Image;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
