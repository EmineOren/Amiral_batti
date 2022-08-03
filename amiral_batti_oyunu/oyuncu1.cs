using System;
using System.Collections;
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

        int i, j;
        string GemiHarfKonumu = "";
        int GemiSayıKonumu = 0;
        int MayınYeniKonum = 0;

        bool suruklenme = false; // bool tipinde classımı tanımladım.Farenin durumlarında değişiklik yapılacak(true/false)
        Point ilkkonum_alma;// point butonun ilk konumunu alıyoruz. 
        private string kullanılangemi;

        ArrayList uzunluk = new ArrayList();// konum bilgimin uzunluğunu kontrol etmek için dizi tanımlaması yapıyorum.



            /*mayınlar için*/
        private void mayın1_btn_MouseDown(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayın1_btn);
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;//işlemi başlatıyorum.
                mayın1_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayın1_btn";
                silme();
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
            butoneslestirme(mayın1_btn);
            suruklenme = false; //Sol tuştan elimi çektim,sürükle işlemi bitti.
            mayın1_btn.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini aldı.
            eslestirme();
            
        }
        private void mayın2_btn_MouseDown(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayın2_btn);
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;//işlemi başlatıyorum.
                mayın2_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayın2_btn";
                silme();
            }
        }
        private void mayın2_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme)// true ise
            {
                mayın2_btn.Left = e.X + mayın2_btn.Left - (ilkkonum_alma.X);
                //left ile soldan uzaklık ayarlandı.e.x burada mousenin buton üzerindeki hareketi+ sola olan uzaklık eklendi- mousenin tıklandıgı alan
                mayın2_btn.Top = e.Y + mayın2_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayın2_btn.Top + "," + mayın2_btn.Left;

            }
        }
        private void mayın2_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayın2_btn);
            suruklenme = false; //Sol tuştan elimi çektim,sürükle işlemi bitti.
            mayın2_btn.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini aldı.
            eslestirme();
            
        }
        private void mayın3_btn_MouseDown(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayın3_btn);
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;//işlemi başlatıyorum.
                mayın3_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayın3_btn";
                silme();
            }
        }
        private void mayın3_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme)// true ise
            {
                mayın3_btn.Left = e.X + mayın3_btn.Left - (ilkkonum_alma.X);
                //left ile soldan uzaklık ayarlandı.e.x burada mousenin buton üzerindeki hareketi+ sola olan uzaklık eklendi- mousenin tıklandıgı alan
                mayın3_btn.Top = e.Y + mayın3_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayın3_btn.Top + "," + mayın3_btn.Left;
            }
        }
        private void mayın3_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayın3_btn);
            suruklenme = false; //Sol tuştan elimi çektim,sürükle işlemi bitti.
            mayın3_btn.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini aldı.
            eslestirme();
            
        }

        private void mayıng1_btn_MouseDown(object sender, MouseEventArgs e) //mayın gemilerim için
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                mayıng1_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayıng1_btn";
                silme();

            }
        }
        private void mayıng1_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                mayıng1_btn.Left = e.X + mayıng1_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                mayıng1_btn.Top = e.Y + mayıng1_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayıng1_btn.Top + "," + mayıng1_btn.Left;
            }
        }
        private void mayıng1_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayıng1_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            mayıng1_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();

        }
        private void mayıng2_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                mayıng2_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayıng2_btn";
                silme();

            }
        }
        private void mayıng2_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                mayıng2_btn.Left = e.X + mayıng2_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                mayıng2_btn.Top = e.Y + mayıng2_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayıng2_btn.Top + "," + mayıng2_btn.Left;
            }
        }
        private void mayıng2_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayıng2_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            mayıng2_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();

        }
        private void mayıng3_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                mayıng3_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayıng3_btn";
                silme();

            }
        }
        private void mayıng3_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                mayıng3_btn.Left = e.X + mayıng3_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                mayıng3_btn.Top = e.Y + mayıng3_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayıng3_btn.Top + "," + mayıng3_btn.Left;
            }
        }
        private void mayıng3_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayıng3_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            mayıng3_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }
        private void mayıng4_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                mayıng4_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "mayıng4_btn";
                silme();

            }
        }
        private void mayıng4_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                mayıng4_btn.Left = e.X + mayıng4_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                mayıng4_btn.Top = e.Y + mayıng4_btn.Top - (ilkkonum_alma.Y);
                label1.Text = mayıng4_btn.Top + "," + mayıng4_btn.Left;
            }
        }
        private void mayıng4_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(mayıng4_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            mayıng4_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }

        private void kruvazör1_btn_MouseDown(object sender, MouseEventArgs e) //kruvazör gemilerim için
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                kruvazör1_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "kruvazör1_btn";
                silme();

            }
        }
        private void kruvazör1_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                kruvazör1_btn.Left = e.X + kruvazör1_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                kruvazör1_btn.Top = e.Y + kruvazör1_btn.Top - (ilkkonum_alma.Y);
                label1.Text = kruvazör1_btn.Top + "," + kruvazör1_btn.Left;
            }
        }
        private void kruvazör1_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(kruvazör1_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            kruvazör1_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }
        private void kruvazör2_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                kruvazör2_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "kruvazör2_btn";
                silme();

            }
        }
        private void kruvazör2_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                kruvazör2_btn.Left = e.X + kruvazör2_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                kruvazör2_btn.Top = e.Y + kruvazör2_btn.Top - (ilkkonum_alma.Y);
                label1.Text = kruvazör2_btn.Top + "," + kruvazör2_btn.Left;
            }
        }
        private void kruvazör2_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(kruvazör2_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            kruvazör2_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }
        private void kruvazör3_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                kruvazör3_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "kruvazör3_btn";
                silme();

            }
        }
        private void kruvazör3_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                kruvazör3_btn.Left = e.X + kruvazör3_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                kruvazör3_btn.Top = e.Y + kruvazör3_btn.Top - (ilkkonum_alma.Y);
                label1.Text = kruvazör3_btn.Top + "," + kruvazör3_btn.Left;
            }
        }
        private void kruvazör3_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(kruvazör3_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            kruvazör2_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }

        private void fırkateyn1_btn_MouseDown(object sender, MouseEventArgs e) //fırkateyn gemilerim için
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                fırkateyn1_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "fırkateyn1_btn";
                silme();

            }
        }
        private void fırkateyn1_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                fırkateyn1_btn.Left = e.X + fırkateyn1_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                fırkateyn1_btn.Top = e.Y +fırkateyn1_btn.Top - (ilkkonum_alma.Y);
                label1.Text = fırkateyn1_btn.Top + "," + fırkateyn1_btn.Left;
            }
        }
        private void fırkateyn1_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(fırkateyn1_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            fırkateyn1_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }
        private void fırkateyn2_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                fırkateyn2_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "fırkateyn2_btn";
                silme();

            }
        }
        private void fırkateyn2_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                fırkateyn2_btn.Left = e.X + fırkateyn2_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                fırkateyn2_btn.Top = e.Y + fırkateyn2_btn.Top - (ilkkonum_alma.Y);
                label1.Text = fırkateyn2_btn.Top + "," + fırkateyn2_btn.Left;
            }
        }
        private void fırkateyn2_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(fırkateyn2_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            fırkateyn2_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }

        private void amiral_btn_MouseDown(object sender, MouseEventArgs e) // amiral gemim için
        {
            if (e.Button == MouseButtons.Left)
            {
                suruklenme = true;// işlemi başlatıyorum.
                amiral_btn.Cursor = Cursors.SizeAll;
                ilkkonum_alma = e.Location;
                kullanılangemi = "amiral_btn";
                silme();

            }
        }
        private void amiral_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme) // true ise
            {
                amiral_btn.Left = e.X + amiral_btn.Left - (ilkkonum_alma.X);
                // left ile soldan uzaklığı ayarladm. e.X burada Mausenin buton üzerinde hareketi+ sola olan uzaklık eklendi - Mausenin tıklandıgı alan
                amiral_btn.Top = e.Y + amiral_btn.Top - (ilkkonum_alma.Y);
                label1.Text = amiral_btn.Top + "," + amiral_btn.Left;
            }
        }
        private void amiral_btn_MouseUp(object sender, MouseEventArgs e)
        {
            butoneslestirme(amiral_btn);
            suruklenme = false; // sol tuştan elimi çektim, sürükle işlemi bitti.
            amiral_btn.Cursor = Cursors.Default; // imlecimiz(cursor) default değerini aldı.
            eslestirme();
        }








        int sayac = 0;
        int[,] butonlarX = new int[10, 10];
        int[,] butonlarY = new int[10, 10];
        int[,] butonlarFormKonumuX = new int[10, 10];
        int[,] butonlarFormKonumuY = new int[10, 10];
    

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
           GemiHarfKonumu = "";
           GemiSayıKonumu = 0;
            for (i = 0; i < 10; i++)
            {
                if (Gemi.Location.X >= butonlarFormKonumuX[0, i] && Gemi.Location.X < (butonlarFormKonumuX[0, i] + 50))
                {
                    MayınYeniKonum = butonlarFormKonumuX[0, i];
                    for (j = 0; j < 10; j++)
                    {
                        if (Gemi.Location.Y >= butonlarFormKonumuY[j, 0] && Gemi.Location.Y < (butonlarFormKonumuY[j, 0] + 50))
                        {
                            Gemi.Location = new Point(MayınYeniKonum + 3, butonlarFormKonumuY[j, 0] + 3);
                            GemiSayıKonumu = j;
                            break;
                        }
                    }

                    switch (i)// gemilerimin harf konumları
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
                    break;
                } //a1 b4 deger dönecek.
            }

        }

        private void eslestirme()
        {
            // bu alan gemiyi belli bir lokasyona yerleştirdiken sonra 2. bir gemi aynı
            //lokasyona yerleştirilmek istenirse engellemek içindir. 
            if (i == 10 || j == 10)
            {
                if (kullanılangemi == "mayın1_btn")
                {
                    mayın1_btn.Location = new Point(565, 352);
                }
                else if (kullanılangemi == "mayın2_btn")
                {
                    mayın2_btn.Location = new Point(565, 304);
                }
                else if (kullanılangemi == "mayın3_btn")
                {
                    mayın3_btn.Location = new Point(565, 255);
                }
                else if (kullanılangemi == "mayıng1_btn")
                {
                    mayıng1_btn.Location = new Point(558,399);
                }
                else if (kullanılangemi == "mayıng2_btn")
                {
                    mayıng2_btn.Location = new Point(654,399);
                }
                else if (kullanılangemi == "mayıng3_btn")
                {
                    mayıng3_btn.Location = new Point(654,444);
                }
                else if (kullanılangemi == "mayıng4_btn")
                {
                    mayıng4_btn.Location = new Point(558,444);
                }
                else if (kullanılangemi == "kruvazör1_btn")
                {
                    kruvazör1_btn.Location = new Point(613,304);
                }
                else if(kullanılangemi =="kruvazör2_btn")
                {
                    kruvazör2_btn.Location = new Point(612,254);
                }
                else if(kullanılangemi == "kruvazör3_btn")
                {
                    kruvazör3_btn.Location = new Point(613,353);
                }
                else if(kullanılangemi== "fırkateyn1_btn")
                {
                    fırkateyn1_btn.Location = new Point(566, 206);
                }
                else if(kullanılangemi== "fırkateyn2_btn")
                {
                    fırkateyn2_btn.Location = new Point(565,156);
                }
                else 
                {
                    amiral_btn.Location = new Point(565,107);
                }
                
                label1.Text = "Filo kartına yerleşim yapınız";

            }
            
            else if (dolumu(GemiHarfKonumu + (GemiSayıKonumu + 1)))
            {

                if (kullanılangemi == "mayın1_btn")
                {
                    mayın1_btn.Location = new Point(565, 352);
                }
                else if (kullanılangemi == "mayın2_btn")
                {
                    mayın2_btn.Location = new Point(565, 304);
                }
                else if (kullanılangemi == "mayın3_btn")
                {
                    mayın3_btn.Location = new Point(565, 255);
                }
                else if (kullanılangemi == "mayıng1_btn")
                {
                    mayıng1_btn.Location = new Point(558, 399);
                }
                else if (kullanılangemi == "mayıng2_btn")
                {
                    mayıng2_btn.Location = new Point(654, 399);
                }
                else if (kullanılangemi == "mayıng3_btn")
                {
                    mayıng3_btn.Location = new Point(654, 444);
                }
                else if (kullanılangemi == "mayıng4_btn")
                {
                    mayıng4_btn.Location = new Point(558, 444);
                }
                else if (kullanılangemi == "kruvazör1_btn")
                {
                    kruvazör1_btn.Location = new Point(613, 304);
                }
                else if (kullanılangemi == "kruvazör2_btn")
                {
                    kruvazör2_btn.Location = new Point(612, 254);
                }
                else if (kullanılangemi == "kruvazör3_btn")
                {
                    kruvazör3_btn.Location = new Point(613, 353);
                }
                else if (kullanılangemi == "fırkateyn1_btn")
                {
                    fırkateyn1_btn.Location = new Point(566, 206);
                }
                else if (kullanılangemi == "fırkateyn2_btn")
                {
                    fırkateyn2_btn.Location = new Point(565, 156);
                }
                else
                {
                    amiral_btn.Location = new Point(565, 107);
                }


                label1.Text = "Bu alana yerleşim yapılmış";
                

            }
            else
            {
                label1.Text = kullanılangemi + " " + GemiHarfKonumu + (GemiSayıKonumu + 1) + @" Bölgesine yerleştirildi.";
                string a = kullanılangemi + " " + GemiHarfKonumu + (GemiSayıKonumu + 1);
                listBox2.Items.Add(a);
                uzunluk.Add(GemiHarfKonumu + (GemiSayıKonumu + 1));

            }
        }



          private Boolean dolumu(string aranıyor)
          {
              int indexNo;

              indexNo = uzunluk.IndexOf(aranıyor);
              if(indexNo == -1)
              {
                  uzunluk.Add(aranıyor);
                  return false;
              }
            
             return true;
          }

        private void silme()
        {
            if (uzunluk.IndexOf(GemiHarfKonumu + (GemiSayıKonumu + 1)) != -1)
            {
                uzunluk.Remove(GemiHarfKonumu + (GemiSayıKonumu + 1));
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void oyuncu1_Load(object sender, EventArgs e)
        {
            butonKonumBelirleme();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
    }
}
