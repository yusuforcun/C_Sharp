internal class Program
{

    public static void asalsayı()
    {
        Console.WriteLine(" sayı giriniz");
        int sayi = Console.ReadLine();

        Console.WriteLine(" sayı giriniz");
        int sayi2 = Console.ReadLine();

        if (sayi ==sayi2) 
        {
            Console.WriteLine("aynı sayı" );
        }
        else if (sayi >sayi2)
                {
            Console.WriteLine("ilk sayı büyük ");
        }
        else if(sayi<sayi2)
        {
            Console.WriteLine("ikinci sayı bğyük");
        }
    }


    private static void Main(string[] args)
    {

        asalsayı();

    }
}