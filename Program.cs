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
        }
    }
}