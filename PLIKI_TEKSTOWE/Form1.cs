using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PLIKI_TEKSTOWE
{
    public partial class Sekretariat : Form
    {

        int liczba;
        string txt0;

        public Sekretariat()
        {
            InitializeComponent();

            Random rnd = new Random();
            liczba = rnd.Next(6);
            pictureBox1.Image = imageList1.Images[liczba];
            if (liczba == 0)
                txt0 = "mxyxw";
            if (liczba == 1)
                txt0 = "b5nmm";
            if (liczba == 2)
                txt0 = "74853";
            if (liczba == 3)
                txt0 = "cg5dd";
            if (liczba == 4)
                txt0 = "x3deb";
            if (liczba == 5)
                txt0 = "befhd";
            if (liczba == 6)
                txt0 = "c7gb3";
        }

        private void Captcha(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            liczba = rnd.Next(6);
            pictureBox1.Image = imageList1.Images[liczba];
            if (liczba == 0)
                txt0 = "mxyxw";
            if (liczba == 1)
                txt0 = "b5nmm";
            if (liczba == 2)
                txt0 = "74853";
            if (liczba == 3)
                txt0 = "cg5dd";
            if (liczba == 4)
                txt0 = "x3deb";
            if (liczba == 5)
                txt0 = "befhd";
            if (liczba == 6)
                txt0 = "c7gb3";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            bool tak1 = false;
            bool tak2 = false;
            bool tak3 = false;
            if (textBox1.Text != "admin")
                MessageBox.Show("Nieprawid這wy login");
            else
                tak1 = true;
            if (textBox2.Text != "Qwerty1@34")
                MessageBox.Show("Nieprawid這we has這");
            else
                tak2 = true;
            if (textBox3.Text != txt0)
                MessageBox.Show("Nieprawid這wa CZAPcza");
            else
                tak3 = true;
            if (tak1 && tak2 && tak3 == true)
            {
                this.Hide();
                WyszujajDodaj f2 = new WyszujajDodaj();
                f2.ShowDialog();
            }
        }
    }
}