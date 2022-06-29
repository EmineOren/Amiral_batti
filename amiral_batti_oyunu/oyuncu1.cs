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

        bool suruklenme = false;
        Point ilkkonum_alma;


        private void dnzaltı3_btn_Click(object sender, EventArgs e)
        {

        }

        private void amiral_btn_Click(object sender, EventArgs e)
        {

        }

        private void kruvazör2_btn_Click(object sender, EventArgs e)
        {

        }


       
         
        private void mayın1_btn_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenme = true;
            mayın1_btn.Cursor = Cursors.SizeAll;
            ilkkonum_alma = e.Location;
            

        }

        private void mayın1_btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme)
            {
                mayın1_btn.Left = e.X + mayın1_btn.Left - (ilkkonum_alma.X);
                // mayın1.left ile sol tarafdan uzaklık ayarlanıyor. e.X buton üzerinde mousenin hareket ettiği pixeli  + butonun soldan uzaklığını ekliyoruz son olarak ilk mouseın tıklandığı alanı çıkarıyoruz yoksa butonun en solunda olur mouse imleci.
                mayın1_btn.Top = e.Y + mayın1_btn.Top - (ilkkonum_alma.Y);
            }

        }
        private void mayın1_btn_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenme = false; //Sol tuştan elimi çektim,sürükle işlemi bitti.
            mayın1_btn.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini aldı.
        }

        private void mayın2_btn_Click(object sender, EventArgs e)
        {

        }

        private void A1_btn_Click(object sender, EventArgs e)
        {

        }

        private void J9_btn_Click(object sender, EventArgs e)
        {

        }

        private void I10_btn_Click(object sender, EventArgs e)
        {

        }

        private void I9_btn_Click(object sender, EventArgs e)
        {

        }

        private void H10_btn_Click(object sender, EventArgs e)
        {

        }

        private void H9_btn_Click(object sender, EventArgs e)
        {

        }

        private void G10_btn_Click(object sender, EventArgs e)
        {

        }

        private void G9_btn_Click(object sender, EventArgs e)
        {

        }

        private void F10_btn_Click(object sender, EventArgs e)
        {

        }

        private void E10_btn_Click(object sender, EventArgs e)
        {

        }

        private void F9_btn_Click(object sender, EventArgs e)
        {

        }

        private void D10_btn_Click(object sender, EventArgs e)
        {

        }

        private void E9_btn_Click(object sender, EventArgs e)
        {

        }

        private void C10_btn_Click(object sender, EventArgs e)
        {

        }

        private void D9_btn_Click(object sender, EventArgs e)
        {

        }

        private void B10_btn_Click(object sender, EventArgs e)
        {

        }

        private void C9_btn_Click(object sender, EventArgs e)
        {

        }

        private void A10_btn_Click(object sender, EventArgs e)
        {

        }

        private void B9_btn_Click(object sender, EventArgs e)
        {

        }

        private void A9_btn_Click(object sender, EventArgs e)
        {

        }

        private void J8_btn_Click(object sender, EventArgs e)
        {

        }

        private void I8_btn_Click(object sender, EventArgs e)
        {

        }

        private void H8_btn_Click(object sender, EventArgs e)
        {

        }

        private void G8_btn_Click(object sender, EventArgs e)
        {

        }

        private void F8_btn_Click(object sender, EventArgs e)
        {

        }

        private void E8_btn_Click(object sender, EventArgs e)
        {

        }

        private void D8_btn_Click(object sender, EventArgs e)
        {

        }

        private void C8_btn_Click(object sender, EventArgs e)
        {

        }

        private void B8_btn_Click(object sender, EventArgs e)
        {

        }

        private void A8_btn_Click(object sender, EventArgs e)
        {

        }

        private void J7_btn_Click(object sender, EventArgs e)
        {

        }

        private void I7_btn_Click(object sender, EventArgs e)
        {

        }

        private void H7_btn_Click(object sender, EventArgs e)
        {

        }

        private void G7_btn_Click(object sender, EventArgs e)
        {

        }

        private void F7_btn_Click(object sender, EventArgs e)
        {

        }

        private void E7_btn_Click(object sender, EventArgs e)
        {

        }

        private void D7_btn_Click(object sender, EventArgs e)
        {

        }

        private void C7_btn_Click(object sender, EventArgs e)
        {

        }

        private void B7_btn_Click(object sender, EventArgs e)
        {

        }

        private void A7_btn_Click(object sender, EventArgs e)
        {

        }

        private void J6_btn_Click(object sender, EventArgs e)
        {

        }

        private void I6_btn_Click(object sender, EventArgs e)
        {

        }

        private void H6_btn_Click(object sender, EventArgs e)
        {

        }

        private void G6_btn_Click(object sender, EventArgs e)
        {

        }

        private void F6_btn_Click(object sender, EventArgs e)
        {

        }

        private void E6_btn_Click(object sender, EventArgs e)
        {

        }

        private void D6_btn_Click(object sender, EventArgs e)
        {

        }

        private void C6_btn_Click(object sender, EventArgs e)
        {

        }

        private void B6_btn_Click(object sender, EventArgs e)
        {

        }

        private void A6_btn_Click(object sender, EventArgs e)
        {

        }

        private void J5_btn_Click(object sender, EventArgs e)
        {

        }

        private void I5_btn_Click(object sender, EventArgs e)
        {

        }

        private void H5_btn_Click(object sender, EventArgs e)
        {

        }

        private void G5_btn_Click(object sender, EventArgs e)
        {

        }

        private void F5_btn_Click(object sender, EventArgs e)
        {

        }

        private void E5_btn_Click(object sender, EventArgs e)
        {

        }

        private void D5_btn_Click(object sender, EventArgs e)
        {

        }

        private void C5_btn_Click(object sender, EventArgs e)
        {

        }

        private void B5_btn_Click(object sender, EventArgs e)
        {

        }

        private void A5_btn_Click(object sender, EventArgs e)
        {

        }

        private void J4_btn_Click(object sender, EventArgs e)
        {

        }

        private void I4_btn_Click(object sender, EventArgs e)
        {

        }

        private void H4_btn_Click(object sender, EventArgs e)
        {

        }

        private void G4_btn_Click(object sender, EventArgs e)
        {

        }

        private void F4_btn_Click(object sender, EventArgs e)
        {

        }

        private void E4_btn_Click(object sender, EventArgs e)
        {

        }

        private void D4_btn_Click(object sender, EventArgs e)
        {

        }

        private void C4_btn_Click(object sender, EventArgs e)
        {

        }

        private void B4_btn_Click(object sender, EventArgs e)
        {

        }

        private void A4_btn_Click(object sender, EventArgs e)
        {

        }

        private void J3_btn_Click(object sender, EventArgs e)
        {

        }

        private void I3_btn_Click(object sender, EventArgs e)
        {

        }

        private void H3_btn_Click(object sender, EventArgs e)
        {

        }

        private void G3_btn_Click(object sender, EventArgs e)
        {

        }

        private void F3_btn_Click(object sender, EventArgs e)
        {

        }

        private void E3_btn_Click(object sender, EventArgs e)
        {

        }

        private void D3_btn_Click(object sender, EventArgs e)
        {

        }

        private void C3_btn_Click(object sender, EventArgs e)
        {

        }

        private void B3_btn_Click(object sender, EventArgs e)
        {

        }

        private void A3_btn_Click(object sender, EventArgs e)
        {

        }

        private void J2_btn_Click(object sender, EventArgs e)
        {

        }

        private void I2_btn_Click(object sender, EventArgs e)
        {

        }

        private void H2_btn_Click(object sender, EventArgs e)
        {

        }

        private void G2_btn_Click(object sender, EventArgs e)
        {

        }

        private void F2_btn_Click(object sender, EventArgs e)
        {

        }

        private void E2_btn_Click(object sender, EventArgs e)
        {

        }

        private void D2_btn_Click(object sender, EventArgs e)
        {

        }

        private void C2_btn_Click(object sender, EventArgs e)
        {

        }

        private void B2_btn_Click(object sender, EventArgs e)
        {

        }

        private void A2_btn_Click(object sender, EventArgs e)
        {

        }

        private void J1_btn_Click(object sender, EventArgs e)
        {

        }

        private void I1_btn_Click(object sender, EventArgs e)
        {

        }

        private void H1_btn_Click(object sender, EventArgs e)
        {

        }

        private void G1_btn_Click(object sender, EventArgs e)
        {

        }

        private void F1_btn_Click(object sender, EventArgs e)
        {

        }

        private void E1_btn_Click(object sender, EventArgs e)
        {

        }

        private void D1_btn_Click(object sender, EventArgs e)
        {

        }

        private void C1_btn_Click(object sender, EventArgs e)
        {

        }

        private void B1_btn_Click(object sender, EventArgs e)
        {

        }

        private void J10_btn_Click(object sender, EventArgs e)
        {

        }

        private void oyuncu1_Load(object sender, EventArgs e)
        {

        }

        private void B9_Click(object sender, EventArgs e)
        {

        }
    }
}

