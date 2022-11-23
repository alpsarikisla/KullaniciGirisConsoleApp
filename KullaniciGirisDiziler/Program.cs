using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Çınar Topçınar", "Kerem Mert Eryiğit", "Sarp Toygar Akkaya", "Efe Öğül", "Ezel Çetinkaya" };
            string[] numaralar = { "500", "501", "502", "503", "504" };
            string[] kullaniciAdlari = { "c.topcinar", "k.eryigit", "s.akkaya", "e.ogul", "e.cetinkaya" };
            string[] sifreler = { "1234", "1235", "1236", "1237", "1238" };

            Console.WriteLine("-*-*-*-*-*-*- Hoşgeldiniz -*-*-*-*-*-*-");
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Lütfen Şifrenizi Adınızı Giriniz");
            string sifre = Console.ReadLine();

            bool kullanicivarmi = false;
            int kullaniciIndex = -1;

            for (int i = 0; i < isimler.Length; i++)
            {
                if (kullaniciAdi == kullaniciAdlari[i])
                {
                    kullanicivarmi = true;
                    kullaniciIndex = i;
                }
            }
            if (kullanicivarmi == true)
            {
                if (sifre == sifreler[kullaniciIndex])
                {
                    Console.WriteLine("Merhaba");
                    Console.WriteLine("No: " + numaralar[kullaniciIndex] + " " + isimler[kullaniciIndex]);
                }
                else
                {
                    Console.WriteLine("Şifre hatalı");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı");
            }
        }
    }
}
