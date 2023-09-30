int[] sayilar = new int[5];
for (int i = 0; i <5; i++)
{
    Console.WriteLine(i+"sayi gir");
    int number = Convert.ToInt32(Console.ReadLine());
    sayilar[i]=number;
}


Console.WriteLine("aranan sayı");
int aranan = Convert.ToInt32(Console.ReadLine());


int kontrol = 0;

foreach (var sayi in sayilar)
{
    if (sayi == aranan)
    {
        Console.WriteLine("var");
    }
    

}













