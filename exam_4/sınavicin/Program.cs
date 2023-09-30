string[]  name = new string[3];
int[] year = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("login name");
    name[i] = Console.ReadLine();
    Console.WriteLine("how many year did you work");
    year[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(name[0]);
Console.WriteLine(year[0]);