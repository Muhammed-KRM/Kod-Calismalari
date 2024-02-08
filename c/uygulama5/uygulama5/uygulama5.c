#include <stdio.h>

int main()
{
	int ogrenci, gsayc = 0, ksayac = 0,not;

	while (ogrenci<10)
	{
		printf("geçtiyse(1) , kaldýysa(2) girin\n");
			scanf_s("%d", &not);
			if (not ==1)
			{

				gsayac++;
			}


		ogrenci++;
	}

	return 0;
}