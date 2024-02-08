#include <stdio.h>

int main() 
{
	float ortalama, not;
	int sayac, toplam;

	toplam = 0;
	sayac = 0;

	printf("Notu giriniz, Cikis icin -1;");
	scanf_s("%f", &not);

	while (not != -1)
	{
			if (not> 0 && not <100)
			{				
				toplam = toplam + not;
				sayac++;
			}
			else
			{
				printf("lutfen gecerli bir sayi girin\n");
			}
			printf("notu girniz, Cikis icin -1: ");
			scanf_s("%f", &not);
	}

	if (sayac != 0)
	{

		ortalama = (float)toplam / sayac;
		printf("sinifin ortalamasi; %.2f\n", ortalama);
	}
	else
	{
		printf("not girmediniz lütfen not giriniz\n");
	}
	return 0;
}
