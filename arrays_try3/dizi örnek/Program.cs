int[] dizi = new int[20];

Random random= new Random();

for(int i = 0;i < 20; i++)
{
    dizi[i] =random.Next(-100,100) ;
}

foreach(int i in dizi)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------------");
int pozitif = 0;
int negatif = 0;


for (int i = 0; i < 20; i++)
{
    if (dizi[i] > 0) { pozitif++;}
    if (dizi[i] < 0 ) {negatif++;}

}

Console.WriteLine(pozitif);
Console.WriteLine(negatif);
