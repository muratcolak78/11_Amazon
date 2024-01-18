using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Amazon
{
    internal class SignIn
    {
        private const string kullanicilarDosyaYolu = "C:\\Users\\Public\\amazonApp\\usernameUndPasswordList.txt";

        public void KullaniciyiKaydet()
        {
            Console.WriteLine("Lütfen kullanıcı adınızı girin:");
            string kullaniciAdi = Console.ReadLine();

            if (KullaniciAdiVarMi(kullaniciAdi))
            {
                Console.WriteLine("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı girin.");
            }
            else
            {
                string sifre = SifreAl();
                KullaniciyiKaydetDosyaya(kullaniciAdi, sifre);
                Console.WriteLine("Kullanıcı başarıyla kaydedildi.");
            }
        }

        private bool KullaniciAdiVarMi(string kullaniciAdi)
        {
            List<string> kayitliKullanicilar = DosyadanKullanicilariOku();

            return kayitliKullanicilar.Contains(kullaniciAdi);
        }

        private string SifreAl()
        {
            string sifre;
            do
            {
                Console.WriteLine("Lütfen bir şifre girin (en az 6 karakter, en az bir harf ve bir sayı içermelidir):");
                sifre = Console.ReadLine();
            } while (!SifreGecerliMi(sifre));

            return sifre;
        }

        private bool SifreGecerliMi(string sifre)
        {
            return sifre.Length >= 6 && sifre.Any(char.IsLetter) && sifre.Any(char.IsDigit);
        }

        private List<string> DosyadanKullanicilariOku()
        {
            List<string> kullanicilar = new List<string>();

            if (File.Exists(kullanicilarDosyaYolu))
            {
                kullanicilar = File.ReadAllLines(kullanicilarDosyaYolu).ToList();
            }
            foreach (string a in kullanicilar)
            {
                Console.WriteLine(a);
            }

            return kullanicilar;
        }

        private void KullaniciyiKaydetDosyaya(string kullaniciAdi, string sifre)
        {
            using (StreamWriter writer = File.AppendText(kullanicilarDosyaYolu))
            {
                writer.WriteLine($"{kullaniciAdi},{sifre}");
            }
        }
    }

}
