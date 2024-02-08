using System;

class toplam
{
    static void Main()
    {
        int y = 0;
        int t = 0;

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
             
                
                y += i;
            }
            else
            {
                t += i;
            }
        }
        Console.WriteLine("çift sayıların toplamı İlk yöntem: "+y);
        Console.WriteLine("tek sayıların toplamı İlk yöntem: "+t);


    }

}