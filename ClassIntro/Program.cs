using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Enes";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Enes Öncü";
            kurs1.IzlenmeOranı = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hilal Öncü";
            kurs2.IzlenmeOranı = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Hikmet Öncü";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Fatma Öncü";
            kurs4.IzlenmeOranı = 90;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " +kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
