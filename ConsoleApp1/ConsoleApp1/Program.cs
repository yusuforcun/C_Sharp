public class kisiler
{
    
    string ad, soyad;
    int yas, okulno;
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }
    public string Soyad
    {
        get { return soyad; }
        set { soyad = value; }
    }
    public int Yas
    {
        get { return yas; }
        set
        {

            if (value < 14)
            {
                Console.WriteLine("yas kücük ");
            }
            else
            {
                yas = value;
            }
        }

    }

    public int Okulno
    {
        get { return okulno; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("olamazzzz");
            }
            else
            {
                okulno = value;
            }
        }
        
    }
    
}

internal class program
{
    private static void Main(string[] args)
    {

        kisiler x = new kisiler();
        x.Ad = "mehmeto";
        x.Soyad = "aga";
        Console.WriteLine(x.Ad);
        Console.WriteLine(x.Soyad);
        Console.WriteLine(x.Okulno);
        Console.WriteLine(x.Yas);
    }
}
