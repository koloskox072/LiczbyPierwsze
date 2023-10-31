namespace LiczbyPierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 191;
            bool czyPierwsza = true;
            for (int i = 2; i < x / 2; i++)
                if (i % 2 == 0) { czyPierwsza = false; break; } 
            if(czyPierwsza) { Console.WriteLine("Liczba Pierwsza"); }
            else { Console.WriteLine("Liczba Nie pierwsza"); }
            
        }
    }
}