
using System;
class HelloWorld
{
    static void Main()
    {
        /*Console.WriteLine("yılbilgisi girin");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Girdiğinizyıl: "+sayi1);


        Console.WriteLine("ad girin: ");
        string ad = Console.ReadLine();
        Console.WriteLine("soyad girin: ");
        string soyad = Console.ReadLine();

        Console.WriteLine("hoşgeldiniz sayın "+ad+" "+soyad);
        */
        Console.WriteLine("öğrencinin adını girin: ");
        string adı = Console.ReadLine();
        Console.WriteLine("öğrencinin soyadını girin: ");
        string soyadı = Console.ReadLine();
        Console.WriteLine("öğrencinin numarasını girin: ");
        int no = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("matematik dersi notunu girin: ");
        int ders1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("fizik dersi notunu girin: ");
        int ders2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("edebiyat dersi notunu girin: ");
        int ders3 = Convert.ToInt32(Console.ReadLine());

        int ort = (ders1 + ders2 + ders3) / 3;
        Console.WriteLine(no + " no lu " + adı + " " + soyadı + "adlı öğrencinin not ortalaması: " + ort + " dir");
    }
}

