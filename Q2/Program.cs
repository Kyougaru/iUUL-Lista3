namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndiceRemissivo i = new IndiceRemissivo("texto.txt", "ignore.txt");
            i.Imprime();
        }
    }
}
