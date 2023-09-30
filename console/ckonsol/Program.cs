namespace ckonsol
{
    public class dikdörtgen
    {
        public int a, b;
        public void alanhesapla(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                Console.WriteLine("hatalı sayı");
            }
            else  
            {
                Console.WriteLine(a + b);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            dikdörtgen kare = new dikdörtgen();
            int a, b, c;

            kare.alanhesapla(5, 8);


        }

    }
}