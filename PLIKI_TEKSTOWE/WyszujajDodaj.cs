using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLIKI_TEKSTOWE
{
    public partial class WyszujajDodaj : Form
    {
        public WyszujajDodaj()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            using (var stream = new StreamWriter(dialog.FileName,true))
            {
                stream.WriteLine(textBox3.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
