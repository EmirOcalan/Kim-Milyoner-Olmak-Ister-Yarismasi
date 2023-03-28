﻿namespace kim_milyoner_olmak_ister_yarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster\n");
            Console.Write("İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("\n1.Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.Write("2.Telefon Jokerinizi Giriniz: ");
            string telefonJoker2 = Console.ReadLine();
            Console.Write("3.Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hoşgeldiniz " + isim + " " + soyisim);

            Console.Write("Kuralları Biliyor Musunuz? : ");
            char kuralCevap = char.Parse(Console.ReadLine().ToUpper());

            if (kuralCevap != 'E')
            {
                Console.WriteLine("Kurallar: Yarışmada toplam 12 soru yer almaktadır. " +
                    "2. soruda 2.000 TL, 7. soruda ise 30.000 TL'lik baraj soruları vardır. " +
                    "Yarışmayı kaybettiğiniz takdirde en son geçtiğiniz baraj sorusunun ödülü sizin olur. " +
                    "Çekildiğiniz takdirde en son doğru yanıtladığınız sorunun ödülünü alırsınız");
            }
            
            Console.Write("Hazır Mısınız? : ");
            char hazirCevap = char.Parse(Console.ReadLine().ToUpper());

            if (hazirCevap != 'E')
            {
                Console.WriteLine("Hazır olmananız bekleniyor.");
                Console.WriteLine("Hazır olduğunuzda Enter'a Basın");
                Console.ReadLine();
            }
            bool seyirciHak = true, yuzdeHak = true, telefonHak = true;
            int kasa = 0;

            int soruNo = 1, odul, baraj;
            int seyirciYuzdeA, seyirciYuzdeB, seyirciYuzdeC, seyirciYuzdeD;
            bool gizleA, gizleB, gizleC, gizleD;
            string soru, a, b, c, d;
            char cevap;

            #region Soru Bilgileri
            soruNo = 1;
            soru = "Türkiyenin Başkenti Neresidir?";
            a = "Ankara";
            b = "Bursa";
            c = "Van";
            d = "Denizli";
            cevap = 'A';
            odul = 1000;
            baraj = 0;

            
            seyirciYuzdeA = 80; seyirciYuzdeB = 10;
            seyirciYuzdeC = 5; seyirciYuzdeD = 5;

            
            gizleA = false; gizleB = false;
            gizleC = false; gizleD = false;
            #endregion
        }
    }
}