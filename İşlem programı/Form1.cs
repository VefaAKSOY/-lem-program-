using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Windows.Forms;

namespace İşlem_programı
{
    public partial class frmHesaplama : Form
    {
     
        public frmHesaplama()
        {
            InitializeComponent();
        }
        enum islemTuru
        {
            eCiftToplama,
            eTekToplama,
            eTekCarpma,
            eCiftCarpma
        }
        string armstrongSayılar (int birinciSayi, int ikinciSayi)
        {
            int armstrongSayilariToplam = 0; 
            BigInteger armstrongSayilaricarpim = 1;
            string armstrongsayilar = " ";
            if (birinciSayi == 1) { birinciSayi += 1; }
            for (int a = birinciSayi; a <= ikinciSayi; a++)
            {
                int birlerBasamagi = a % 10;
                int onlarBasamagi = ((a - birlerBasamagi) / 10) % 10;
                int yuzlerBasamagi = (((a - birlerBasamagi) / 10) - onlarBasamagi) / 10;
                if (a == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3))
                {
                    armstrongSayilaricarpim *= a;
                    armstrongSayilariToplam += a;
                    lsvArmstrongSayilari.Items.Add(a.ToString());
                    armstrongsayilar+= a + " ";
                }    
            }
            lsvArmstrongSayilari.Items.Add("Armstrong sayilari toplamı: " + armstrongSayilariToplam.ToString() + "Armstrong Sayıların Çarpımı: " + armstrongSayilaricarpim.ToString());
            return armstrongsayilar;
        }
        string asalSayilar(int ilkSayi,int ikinciSayi)
        {
            int asalSayilarToplam=0;
            string asalsayilar = " ";
            BigInteger asalSayilarCarpim=1;
            if (ilkSayi == 1)
            {
                ilkSayi++;
            }
            for(int i = ilkSayi; i <= ikinciSayi; i++)
            {
                int bayrak = 0;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        bayrak = 1;
                        
                    }
                }
                if (bayrak == 0)
                {
                    asalSayilarCarpim *= i;
                    asalSayilarToplam += i;
                    lsvAsalSayilar.Items.Add(i.ToString());
                    asalsayilar += i + " ";
                }
            }
            lsvAsalSayilar.Items.Add("Asal Sayılar Toplam: " + asalSayilarToplam.ToString() + "Asal Sayılar Çarpım: " + asalSayilarCarpim.ToString());
            return asalsayilar;
        }
        string ciftYazma(int ilkSayi,int ikinciSayi)
        {
            string ciftSayilar = " ";
            for (int i = ilkSayi; i <= ikinciSayi; i++)
            {
                if (i % 2 == 0)
                {
                    lsvCiftSayilar.Items.Add(i.ToString());
                    ciftSayilar += i + " ";
                }               
            }
            return ciftSayilar;
        }
        string tekYazma(int sayi1,int sayi2)
        {
            string tekSayilar = "";
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 1)
                {
                    lsvTekSayilar.Items.Add(i.ToString());
                    tekSayilar += i + " ";
                }
            }
            return tekSayilar;
        }
        BigInteger islem(islemTuru tur, int ilkSayi, int ikinciSayi)
        {
            int ciftToplam = 0, tekToplam = 0;
            BigInteger ciftCarpim = 1, tekCarpim = 1;                       
            for (int i = ilkSayi; i <= ikinciSayi; i++)
            {
                if (i % 2 == 0)
                {                                                         
                    ciftToplam += i;
                    ciftCarpim *= i;
                }
                else
                {                                 
                    tekToplam += i;
                    tekCarpim *= i;
                }
            }
            if (tur == islemTuru.eCiftToplama)
            {
                return ciftToplam;
            }
            else if (tur == islemTuru.eTekToplama)
            {
                return tekToplam;
            }
            else if (tur== islemTuru.eCiftCarpma)
            {
                return ciftCarpim;
            }
            else 
            {
                return tekCarpim;
            }
        }
        void Loglama()
        {
            StreamWriter Loglama = new StreamWriter("D:\\Log.txt");
            int baslangic = Convert.ToInt32(mtbIlkSayi.Text);
            int bitis = Convert.ToInt32(mtbIkinciSayi.Text);
            if (tbcIşlemler.SelectedIndex == 0)
            {
                Loglama.WriteLine("Tek Sayılar:\n" 
                    + tekYazma(baslangic, bitis) 
                    +("\nTek sayı Toplama:\n "+islem(islemTuru.eTekToplama, baslangic, bitis).ToString()) 
                    +("\nTek sayı çarpma:\n " + islem(islemTuru.eTekCarpma, baslangic, bitis).ToString()));
                Loglama.Close();
            }
            else if (tbcIşlemler.SelectedIndex == 1)
            {
                Loglama.WriteLine("Çift Sayılar:\n" + ciftYazma(baslangic, bitis) +
                lsvCiftSayilar.Items.Add("\nÇift Sayı Toplama: \n" + islem(islemTuru.eCiftToplama, baslangic, bitis).ToString()) +
                lsvCiftSayilar.Items.Add("\nçift sayı çarpma:\n " + islem(islemTuru.eCiftCarpma, baslangic, bitis).ToString()));
                Loglama.Close();
            }
            else if (tbcIşlemler.SelectedIndex == 2)
            {
                Loglama.WriteLine("\nAsal Sayılar:\n " + asalSayilar(baslangic,bitis));
                Loglama.Close();
            }
            else if (tbcIşlemler.SelectedIndex == 3)
            {
                Loglama.WriteLine("Armstrong sayılar:" + armstrongSayılar(baslangic, bitis));
                Loglama.Close();
            }
        }
        void EkranHazirla()
        {
            mtbIlkSayi.Focus();
            lsvArmstrongSayilari.Clear();
            lsvAsalSayilar.Clear();
            lsvCiftSayilar.Clear();
            lsvTekSayilar.Clear();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(mtbIlkSayi.Text);
            int bitis = Convert.ToInt32(mtbIkinciSayi.Text);           
            if (tbcIşlemler.SelectedIndex == 0)
            {
                EkranHazirla();
                lsvTekSayilar.Items.Add("Tek sayı Toplama: "+islem(islemTuru.eTekToplama, baslangic, bitis).ToString());
                lsvTekSayilar.Items.Add("Tek sayı çarpma: "+islem(islemTuru.eTekCarpma, baslangic, bitis).ToString());
                tekYazma(baslangic, bitis);
                Loglama(); 
            }
            else if (tbcIşlemler.SelectedIndex == 1)
            {
                EkranHazirla();
                lsvCiftSayilar.Items.Add("Çift Sayı Toplama: " + islem(islemTuru.eCiftToplama, baslangic, bitis).ToString());
                lsvCiftSayilar.Items.Add("çift sayı çarpma: "+islem(islemTuru.eCiftCarpma, baslangic, bitis).ToString());
                ciftYazma(baslangic, bitis);
                Loglama();
            }
            else if (tbcIşlemler.SelectedIndex == 2)
            {
                EkranHazirla();
                asalSayilar(baslangic, bitis);
                Loglama();
            }
            else if (tbcIşlemler.SelectedIndex == 3)
            {
                EkranHazirla();
                armstrongSayılar(baslangic, bitis);
                Loglama();
            }            
        }
        private void frmHesaplama_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
            ntfBildirim.ShowBalloonTip(5000);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (tbcIşlemler.SelectedIndex == 0)
            {
                tbcIşlemler.SelectedIndex = 0;
            }
            else
            tbcIşlemler.SelectedIndex -= 1;
        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (tbcIşlemler.SelectedIndex == 3)
            {
                tbcIşlemler.SelectedIndex = 3;
            }
            else
                tbcIşlemler.SelectedIndex += 1;
        }
    }
}
