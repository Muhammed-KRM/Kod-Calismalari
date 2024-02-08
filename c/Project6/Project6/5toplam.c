#include <stdio.h>

int main() 
{
	int sayac = 1;
	int sayi1;
	int toplam = 0;
	int belirtec;
	printf("kaç deðiþken toplamak istersiniz: ");
	scanf_s("%d", &belirtec);

	while (sayac <= belirtec )
	{
		
		printf("bir sayi girin: ");
		scanf_s("%d", &sayi1);
		toplam += sayi1;
		sayac++;
		
	}

	printf("%d", toplam);

}