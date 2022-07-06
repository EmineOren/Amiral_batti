using System;
using System.Windows.Forms;

namespace amiral_batti_oyunu
{
    public partial class Giriş_ekranı : Form
    {
        public Giriş_ekranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Nicknamelerinizi giriniz..");

            }
            else
            {
                MessageBox.Show(textBox1.Text + " " + textBox2.Text, " oyun yükleniyor...");
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                oyuncu1 form1 = new oyuncu1();
                form1.Show();
                this.Hide();
            }



        }

        /* private void textBox2_TextChanged(object sender, EventArgs e)
         {

         }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
