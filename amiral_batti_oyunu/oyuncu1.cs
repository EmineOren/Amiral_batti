using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amiral_batti_oyunu
{
    public partial class oyuncu1 : Form
    {
        public oyuncu1()
        {
            InitializeComponent();
        }

        bool suruklenme = false; // bool tipinde classımı tanımladım.Farenin durumlarında değişiklik yapılacak(true/false)
        Point ilkkonum_alma;// point butonun ilk konumunu alıyoruz. 

        private string kullanılangemi;
         /*  int i,j;
        String GemiHarfKonumu = "";
        int GemiSayiKonumu = 0;
        int MayinyeniKonum = 0;*/
      
       
         
        private void mayın1_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;//işlemi başlatıyorum.
                mayın1_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayın1.btn";
            }
            

        }

        private void mayın1_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme)// true ise
            {
                mayın1_btn.Left = e.X + mayın1_btn.Left - (ilkkonum_alma.X);
                //left ile soldan uzaklık ayarlandı.e.x burada mousenin buton üzerindeki hareketi+ sola olan uzaklık eklendi- mousenin tıklandıgı alan
                mayın1_btn.Top = e.Y + mayın1_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayın1_btn.Top + "," + mayın1_btn.Left;
               


            }

        }
        private void mayın1_btn_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenme = false; //Sol tuştan elimi çektim,sürükle işlemi bitti.
            mayın1_btn.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini aldı.
            butoneslestirme(mayın1_btn);
        }


        int sayac = 0;
        int[,] butonlarX = new int[10,10];
        int[,] butonlarY = new int[10,10];
        int[,] butonlarFormKonumuX = new int[10,10];
        int[,] butonlarFormKonumuY = new int[10,10];

        private void butonKonumBelirleme()// butonun konumunu belirliyorum.
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    butonlarX[i, j] = panel1.Controls[sayac].Location.X;
                    butonlarY[i, j] = panel1.Controls[sayac].Location.Y;
                    butonlarFormKonumuX[i, j] = panel1.Controls[sayac].Location.X + panel1.Location.X;
                    butonlarFormKonumuY[i, j] = panel1.Controls[sayac].Location.Y + panel1.Location.Y;
                    sayac++;
                }
            }
            
        }
        private void butoneslestirme(Button Gemi)
        {
            int i, j;
            string GemiHarfKonumu = "";
            int GemiSayıKonumu = 0;
            int MayınYeniKonum = 0;


            for(i=0; i<10; i++)
            {
                if(Gemi.Location.X >= butonlarFormKonumuX[0,i] && Gemi.Location.X<(butonlarFormKonumuX[0,i] + 50))
                {
                    MayınYeniKonum = butonlarFormKonumuX[0, i];
                    break;
                }
            }


            for (j = 0; j < 10; j++)
            {
                if(Gemi.Location.Y >= butonlarFormKonumuY[j,0] && Gemi.Location.Y<(butonlarFormKonumuY[j,0] + ))
                {
                    Gemi.Location = new Point(MayınYeniKonum+3,butonlarFormKonumuY[j, 0] + 3);
                    GemiSayıKonumu = j;
                    break;
                }
            }
          
            switch (i)
            {
                case 0:
                    GemiHarfKonumu = "A";
                    break;
                case 1:
                    GemiHarfKonumu = "B";
                    break;
                case 2:
                    GemiHarfKonumu = "C";
                    break;
                case 3:
                    GemiHarfKonumu = "D";
                    break;
                case 4:
                    GemiHarfKonumu = "E";
                    break;
                case 5:
                    GemiHarfKonumu = "F";
                    break;
                case 6:
                    GemiHarfKonumu = "G";
                    break;
                case 7:
                    GemiHarfKonumu = "H";
                    break;
                case 8:
                    GemiHarfKonumu = "I";
                    break;
                case 9:
                    GemiHarfKonumu = "J";
                    break;
            }
            
    
            
            if(i == 10 || j == 10)
            {
                mayın1_btn.Location = new Point(565,352); 
                label1.Text= "";
            }
            else
            {
                label1.Text =  kullanılangemi+" " + GemiHarfKonumu + (GemiSayıKonumu + 1) +@" Bölgesine yerleştirildi.";

            }

      
        }



        private void oyuncu1_Load(object sender, EventArgs e)
        {
            butonKonumBelirleme();
        }

    

        private void mayıng2_btn_Click(object sender, EventArgs e)
        {
        }

        private void mayıng1_btn_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

