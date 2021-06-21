using System;
using System.Collections.Generic;

namespace TarefaHE
{
    class Program
    {

        static List<object> _figuras;

        static void Main(string[] args)
        {
            _figuras = new List<Object>();
            _figuras.add(new Retangulo(alt: 10, l: 20));
            _figuras.add(new Circulo(r: 3));
            _figuras.add(new TrianguloRetangulo(c1: 20, c2: 30, l1: 20, l2: 40, l3: 30));


            foreach (Object p in _figuras)
            {
                Console.WriteLine("");
                Console.WriteLine("Nome da Figura:{0}", GetProperty(p, "Nome da Figura"));
                Console.WriteLine("Area da Figura:{0}", GetProperty(p, "Area da Figura"));
                Console.WriteLine("Perimetro da Figura:{0}", GetProperty(p, "Perimetro da Figura"));
                Console.WriteLine("");
            }
        }

        static private string GetProperty(Object Obj, String PropName)
        {
            var propinfo = Obj.GetType().GetProperty(PropName);
            var p = propinfo.GetValue(Obj, null);
            return p.ToString();
        }
    }
}