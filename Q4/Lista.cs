using System;
using System.Collections.Generic;
using System.Linq;

namespace Q4
{
    public static class Lista
    {
        public static List<T> RemoveRepetidos<T> (this List<T> lista)
        {
            return lista.Distinct().ToList();
        }

        public static void ImprimeLista<T>(this List<T> lista)
        {
            Console.WriteLine("-------- Lista com repetidos --------");
            PercorreLista(lista);
            Console.WriteLine("-------------------------------------");

            lista = lista.RemoveRepetidos();

            Console.WriteLine("-------- Lista sem repetidos --------");
            PercorreLista(lista);
            Console.WriteLine("-------------------------------------");
        }

        static void PercorreLista<T>(List<T> lista)
        {
            foreach (T i in lista)
            {
                if (i.GetType().GetProperty("CPF") != null)
                {
                    Console.WriteLine(i.GetType().GetProperty("Nome").GetValue(i, null) +
                        " " + i.GetType().GetProperty("CPF").GetValue(i, null));
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
