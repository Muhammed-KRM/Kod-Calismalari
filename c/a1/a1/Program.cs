// See https://aka.ms/new-console-template for more information

Console.Write("bir sayı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("bir sayı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("bir sayı girin: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());


if (sayi1 > sayi2 && sayi1 > sayi3)
{
    Console.WriteLine(" en büyüksayı: " + sayi1);

}
else if (sayi2 > sayi1 && sayi2 > sayi3)
{
    Console.WriteLine(" en büyüksayı: " + sayi2);
}
else if (sayi3 > sayi1 && sayi3 > sayi2)
{
    Console.WriteLine(" en büyüksayı: " + sayi3);
}
