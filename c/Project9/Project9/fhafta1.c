#include <stdio.h>

int main() 
{
	float saat;

printf("bir saat girin:");
scanf_s("%f", &saat);

	if (saat >= 0 && saat <= 12)
	{
		printf("\ngunaydin");
	}

	else if (saat > 12 && saat <= 18)
	{
		printf("\niyi gunler");
	}

	else if (saat > 18 && saat <= 24)
	{
		printf("\niyi geceler");
	}

	else
	{
		printf("\ngecerli(0-24) bir saat girin");
	}

		return 0;
}