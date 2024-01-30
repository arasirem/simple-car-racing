using ARABA_YARIŞI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //ses için

namespace ARABA_YARIŞI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yolhizi = 35;
        int arabahizi = 35;
        bool solyon = false;
        bool sagyon = false;
        int kazanilanpuan = 0;

        Random random = new Random(); //bazı komutlarda rastgele sayı üretmesi için kullanıcam

        private void Form1_Load(object sender, EventArgs e)
         {
            oyunuBaslat();
            sesbaslat();
         }
        public void oyunuBaslat()
        {
            btn_oyunubaslat.Enabled = false; //buton kullanmayı kapatıyorum
            carpma.Visible = false; //çarpma efekti görünmesin


            //yuksek skor oyun başlayınca görünsün diye;

            lbl_yuksekskor.Text = Settings1.Default.yuksekskor;

            kazanilanpuan = 0;
            arabahizi = 35;
            
            bizimaraba.Left = 160; //başlangıçta soldan ve üstten olan mesafeleri tanımlıyoruz
            bizimaraba.Top = 300;

            araba1.Left = 30;
            araba1.Top = 50;

            araba2.Left = 320;
            araba2.Top = 50;

            
            solyon = false;
            sagyon=false; //oyun her başladığında sağa sola hareket edemesin puan sıfırlansın vs

            carpma.Left = 165;
            carpma.Top = 294;

            timer1.Start(); //zamanı başlatıyo metot bitmeden bu da timer1.tick metodunun çalışmasını sağlıyor

        }


        private void sesbaslat()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesyolu = Application.StartupPath + "\\depositphotos_550409720-track-cool-energetic-motivational-sport-action.wav";
            ses.SoundLocation = sesyolu;
            ses.Play();
        }



        private void btn_oyunubaslat_Click(object sender, EventArgs e)
        {
            oyunuBaslat(); sesbaslat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            kazanilanpuan++;
            lbl_kazanilanpuan.Text = kazanilanpuan.ToString();


            yol.Top += yolhizi; //yol aşağı doğru kaymaya başlayacak

            if (yol.Top > 250) { yol.Top = -100; } //yol kaybolmasın diye 


            if(solyon) {bizimaraba.Left-=arabahizi; } //eğer solyone gitmek istenirse arabanın sola uzaklığını hızı kadar azaltıyoruz ve sola yaklaşmış oluyo
            if (sagyon) { bizimaraba.Left += arabahizi; } //sağa gitmek isteyince de sol mesafesini arttırıp sağa gitmesini sağla


            if (bizimaraba.Left <1) {solyon = false; } //sola mesafe kalmazsa gitmeye izin verme
                                                       
            else if (bizimaraba.Left + bizimaraba.Width > 510) { sagyon = false; } //sol mesafesi ve arab genişliği toplamda >510 yani panel uzunluğundan ise sağa gidecek yer kalmadı izin verme


            araba1.Top += arabahizi; //diğer iki araba da hızı kadar toptan uzaklaşacak, kaybolmasın diye kontrol yapalım
            araba2.Top += arabahizi;

            if (araba1.Top > panel1.Height)
            {
                araba1degistir () ;

                araba1.Left = random.Next(20, 50); //yeni gelen araba1 'in random left ve top mesafelerini belirledik
                araba1.Top = random.Next(40, 150) * -1; // - ile çarptık ki aşağıdan gelsin


            }

            if(araba2.Top>panel1.Height)
            {
                araba2degistir ();

                araba2.Left = random.Next(60,400);
                araba2.Top = random.Next(40, 140) * -1;
            }

            if (bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds))
            {
                oyunbitti();
            }

        }



        private void araba1degistir()
        {
            int sira = random.Next(2,7);

            switch(sira)
            {
                case 2:
                    {
                        araba1.Image = Properties.Resources.araba2;
                        break;
                    }

                case 3:
                    {
                        araba1.Image = Properties.Resources.araba3;
                        break;
                    }
                case 4:
                    {
                        araba1.Image = Properties.Resources.araba4;
                        break;
                    }
                case 5:
                    {
                        araba1.Image= Properties.Resources.araba5;
                        break;
                    }
                case 6:
                    {
                        araba1.Image = Properties.Resources.araba6;
                        break;
                    }
                case 7:
                    {
                        araba1.Image = Properties.Resources.araba7;
                        break;
                    }
            }


        }

        private void araba2degistir()
        {

            int sira = random.Next(2, 7);
            switch(sira)
            {
                case 2:
                    {
                        araba2.Image = Properties.Resources.araba2;
                        break;
                    }
                case 3:
                    {
                        araba2.Image = Properties.Resources.araba3;
                        break;
                    }  
                case 4:
                    {
                        araba2.Image = Properties.Resources.araba4;
                        break;
                    }
                case 5:
                    {
                        araba2.Image = Properties.Resources.araba5;
                        break;
                    }

                case 6:
                    {
                        araba2.Image = Properties.Resources.araba6;
                        break;
                    }
                case 7:
                    {
                        araba2.Image = Properties.Resources.araba7;
                        break;
                    }
            }


        }


        public void oyunbitti()
        {
            timer1.Stop ();

            if(Convert.ToInt32(lbl_kazanilanpuan.Text)> Convert.ToInt32(Settings1.Default.yuksekskor.ToString())) 
            {
                //lbl_yuksekskor.Text= Settings1.Default.yuksekskor.ToString();

                Settings1.Default.yuksekskor = lbl_kazanilanpuan.Text; //kazanılan puan settingste tuttuğumuz yuksekskor'dan büyükse 
                                                                      //settingsteki yuksek skora kazanılan ouan atanır  
            }


            btn_oyunubaslat.Enabled = true;
            carpma.Visible = true;

            bizimaraba.Controls.Add(carpma); //carpma efektini araba içine ekliyo
            carpma.Location = new Point(7, -5);

            carpma.BringToFront (); //carpma efektini öne getirir
            carpma.BackColor = Color.Transparent; //arkaplanı saydam yapar

            MessageBox.Show ("Tebrikler kazandığınız puan: " + lbl_kazanilanpuan.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//tuşa basınca
        {
            if (e.KeyCode == Keys.Left && bizimaraba.Left>0) //bastığın tuş left ise 
            {
                solyon = true;
            }
            if (e.KeyCode == Keys.Right && bizimaraba.Left + bizimaraba.Width < panel1.Width) { sagyon = true; }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //tuştan elini çekince
        {
            if(e.KeyCode == Keys.Left)
            {
                solyon = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagyon = false;
            }
        }
    }
}
