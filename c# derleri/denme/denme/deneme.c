#include <stdio.h>

int main()
{
    int sayi1;
    int sayi2;
    int sayi3;

    scanf_s("%d %d %d", &sayi1, &sayi2, &sayi3);

    int toplam = sayi1 + sayi2;
    int sonu� = toplam % sayi3;
    printf("%d", sonu�);

    return 0;
}