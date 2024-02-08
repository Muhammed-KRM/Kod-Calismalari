// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;
using System.Threading.Channels;

Console.Write("yapmak istediğiniz işlemi seçiniz\ntoplama: 1\nçıkarma: 2\nçarpım: 3\nbölme: 4\n işlem numaranızı girin: ");
int sec = Convert.ToInt32(Console.ReadLine());

Console.Write("x i girin: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("y yi girin: ");
double y = Convert.ToInt32(Console.ReadLine());

double toplam = x + y;
double fark = x - y;
double carpim = x * y;
double bolum = x / y;




if (sec == 1)
{
    Console.WriteLine("x + y = "+ toplam);
    
}
else if (sec == 2) 
{
    Console.WriteLine("x - y = "+ fark);
    
}

else if (sec == 3)
{
    Console.WriteLine("x * y = "+ carpim);
    
}

else if (sec == 4)
{
    if (y == 0)
    {
        Console.WriteLine("tanımsız bir ifade girdiniz");
    }
    else
    {
        Console.WriteLine("x / y = " + bolum);
    }
    
}
else
{
    Console.WriteLine("tanımsız bir değer girdiniz ");
}





