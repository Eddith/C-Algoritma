using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                R: Direnç 
                P: Telin Öz Direnci
                l: Telin Uzunluğu
                A: Telin Kesit Alanı = Pi*(r*r) sabit Pi: 3,14 r: Yarıçap
                R = P*(l/A) 
            */
            double pi = 3.14;
            double rYariCap;
            double rDirencSonuc;
            double pOzDirenc;
            double lTelinUzunlugu;
            double aKesitAlan;
            
            Console.Write("Telin Özdirencini Giriniz: ");
            pOzDirenc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Telin Uzunluğunu Giriniz: ");
            lTelinUzunlugu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Telin YarıÇapını Giriniz : ");
            rYariCap = Convert.ToDouble(Console.ReadLine());

            aKesitAlan = pi*(rYariCap*rYariCap); // Kesit Alanı Hesaplama
            Console.WriteLine("Telin Kesit Alanı = " + aKesitAlan);

            rDirencSonuc = pOzDirenc*(lTelinUzunlugu/aKesitAlan); // Telin Gösterdiği Direnç Hesaplama
            Console.WriteLine("Telin Direnci =  " + rDirencSonuc);

            Console.ReadLine(); // Bitti
        }
    }
}
