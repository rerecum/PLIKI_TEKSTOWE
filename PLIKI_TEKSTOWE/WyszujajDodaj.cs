using DevExpress.Data.Browsing;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

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

            string myConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student\\source\\repos\\PLIKI_TEKSTOWE\\PLIKI_TEKSTOWE\\Database1.mdf;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", myConn);
            cmd.Connection = myConn;

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string line = $"{reader["Imie"]} {reader["Nazwisko"]} {reader["Klasa"]}";
                if (comboBox1.SelectedIndex == 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[0])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[0].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[0].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[1])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[1].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[1].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[2])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[2].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[2].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
            }

            myConn.Close();


            /*string[] lines = System.IO.File.ReadAllLines(@"C:\Users\student\Desktop\uczen.txt");
            textBox2.Text = "";
            foreach (string line in lines)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[0])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[0].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[0].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[1])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[1].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[1].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (textBox1.Text == line.Split(' ')[2])
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[2].Contains(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[2].StartsWith(textBox1.Text))
                            textBox2.AppendText(line + "\r\n");
                    }
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string myConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\student\\source\\repos\\PLIKI_TEKSTOWE\\PLIKI_TEKSTOWE\\Database1.mdf;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(myConnection);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
            myConn.Open();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(myConnection);
            cmd.Connection = myConn;
            cmd.CommandText = "INSERT INTO [Table](Imię, Nazwisko, Klasa) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();

            myConn.Close();
        }



        /*  string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

          // zapisywanie do pliku
          using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt"), true))
          {
              outputFile.WriteLine(textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
          } */

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
