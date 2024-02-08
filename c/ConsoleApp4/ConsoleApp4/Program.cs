using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("sıfıran büyük bir sayı girin");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        if (sayi1 >= 0)
        {
            int toplam=0;
            for (int i = 0; i < sayi1; i++)
            {
                if (i % 2==0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine("0 dan "+sayi1+" e kadarki çift sayıların toplamı: "+toplam);

        }
        else
        {
            Console.WriteLine("girdiğiniz sayı sıfırdan küçüktür lütfen yeniden deneyin.");
        }


    }
}