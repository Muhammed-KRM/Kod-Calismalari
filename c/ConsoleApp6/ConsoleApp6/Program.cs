// See https://aka.ms/new-console-template for more information
Console.Write("bir sayı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("bir sayı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("bir sayı girin: ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

if (sayi1 > sayi2 && sayi1 > sayi3)
{
    if (sayi2 > sayi3)
    {
        Console.WriteLine(sayi1 + " enbüyük sayıdır " + sayi2 + " 2.sayı dır " + sayi3 + " en küçük tür");
        Console.WriteLine(sayi1 + " > " + sayi2 + " > " + sayi3);
    }

    else
    {
        Console.WriteLine(sayi1 + " enbüyük sayıdır " + sayi3 + " 2.sayı dır " + sayi2 + " en küçük tür");
        Console.WriteLine(sayi1 + " > " + sayi3 + " > " + sayi2);
    }

}
else if (sayi2 > sayi1 && sayi2 > sayi3)
{
    if (sayi1 > sayi3)
    {
        Console.WriteLine(sayi2 + " enbüyük sayıdır " + sayi1 + " 2.sayı dır " + sayi3 + " en küçük tür");
        Console.WriteLine(sayi2 + " > " + sayi1 + " > " + sayi3);
    }

    else
    {
        Console.WriteLine(sayi2 + " enbüyük sayıdır " + sayi3 + " 2.sayı dır " + sayi1 + " en küçük tür");
        Console.WriteLine(sayi2 + " > " + sayi3 + " > " + sayi1);
    }
}
else if (sayi3 > sayi1 && sayi3 > sayi2)
{
    if (sayi2 > sayi1)
    {
        Console.WriteLine(sayi3 + " enbüyük sayıdır " + sayi2 + " 2.sayı dır " + sayi1 + " en küçük tür");
        Console.WriteLine(sayi3 + " > " + sayi2 + " > " + sayi1);
    }

    else
    {
        Console.WriteLine(sayi3 + " enbüyük sayıdır " + sayi1 + " 2.sayı dır " + sayi2 + " en küçük tür");
        Console.WriteLine(sayi3 + " > " + sayi1 + " > " + sayi2);
    }
}




