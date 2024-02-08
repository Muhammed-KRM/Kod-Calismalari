#include <stdio.h>
int main() 
{
	int wcarpim=1;
	int fcarpim=1;
	int sayi = 1;
	int gun;
	char notlar;
	/*
	while (sayi<=5)
	{
		wcarpim *= sayi;
		printf("while ile: %d\n", wcarpim);
			sayi++;
	}

	for (int i = 1; i <=5  ; i++)
	{
		fcarpim *= i;
		printf("for ile: %d\n", fcarpim);
	}
	printf("haftanin bir gununu secin(1-7): ");
	scanf_s("%d",&gun);

	switch (gun)
	{
	case 1:
		printf("pazartesi");
	
			break;
	case 2:
		printf("salý");
		break;
	case 3: 
		printf("çarþamba");
		break;
	case 4:
		printf("perþembe");
		break;
	case 5:
		printf("cuma");
		break;
	case 6:
		printf("cumartesi");
		break;
	case 7:
		printf("pazar");
		break;

	default:
		printf("(1-7) arasi bir degergirin");
		break;
	}*/


	/*
	int aSay=0;
	int bSay=0;
	int cSay=0;
	int dSay=0;
	int eSay=0;
	int fSay=0;



	while ((notlar = getchar()) != 'EOF')
	{




		printf("bir not Harfi girin");
		scanf_s("%c", &notlar);

		switch (notlar)
		{
		case'A': case 'a':
			printf("notunuz (100-90)");
			aSay++;
			break;
		case'B': case 'b':
			printf("notunuz (89-75)");
			bSay++;
			break;
		case'C': case 'c':
			printf("notunuz (74-65)");
			cSay++;
			break;
		case'D': case 'd':
			printf("notunuz (64-50)");
			dSay++;
			break;
		case'E': case 'e':
			printf("notunuz (49-35)");
			fSay++;
			break;
		case'F': case 'f':
			printf("notunuz (34-0)");
			aSay++;
			break;
		default: printf("dogruduzgun deger gir");
			break;
		}


	}

	printf("A: %d", aSay);
	printf("B: %d", bSay);
	printf("C: %d", cSay);
	printf("D: %d", dSay);
	printf("E: %d", eSay);
	printf("F: %d", fSay);

	*/




for (int i = 1; i <= 100; i++)
{

	if (i % 5==0)
	{
		continue;
	}

		printf("%d\n",i);
		
		
	
	


}




	return 0;
}