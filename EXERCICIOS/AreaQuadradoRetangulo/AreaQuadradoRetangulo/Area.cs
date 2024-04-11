using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalculada { get; set;}

        public int Calcular()
        {
            AreaCalculada = Base * Altura;
            return AreaCalculada;
        }

        public string Calcular2()
        {
            string Resultado = "";
            AreaCalculada = Base * Altura;

            if (Base == Altura) {
                Resultado = "QUADRADO";
            }
            else
            {
                Resultado = "RETÂNGULO";
            }
            return Resultado;
        }

        public void MostraDetalhes()
        {
            Console.WriteLine("");
            Console.WriteLine("DETALHES");
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Área: " + AreaCalculada);
        }

    }
}
