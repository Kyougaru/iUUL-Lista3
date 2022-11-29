namespace Q3
{
    public static class Armstrong
    {
        //Verificação do número retirado do site: https://www.macoratti.net/19/02/c_armstr1.htm

        static int Potencia(int x, long y)
        {
            if (y == 0)
                return 1;
            if (y % 2 == 0)
                return Potencia(x, y / 2) *
                       Potencia(x, y / 2);
            return x * Potencia(x, y / 2) *
                       Potencia(x, y / 2);
        }

        static int Ordem(int x)
        {
            int n = 0;
            while (x != 0)
            {
                n++;
                x /= 10;
            }
            return n;
        }

        public static bool IsArmstrong(this int number)
        {
            int ordem = Ordem(number);
            int temp = number, soma = 0;

            while (temp != 0)
            {
                int resto = temp % 10;
                soma += Potencia(resto, ordem);
                temp /= 10;
            }

            return (soma == number);
        }
    }
}
