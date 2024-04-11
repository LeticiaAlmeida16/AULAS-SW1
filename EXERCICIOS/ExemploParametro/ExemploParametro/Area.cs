using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculada { get; set;}

        public void Escolha(int opcao)
        {
            if (opcao == 1)
            {
                float quadrado = CalculaAreaQuadrado();
                Console.WriteLine("Área do Quadrado é: " + quadrado);
            }
            if (opcao == 2)
            {
                float retangulo = CalculaAreaRetangulo();
                Console.WriteLine("Área do Retângulo é: " + retangulo);
            }
            if (opcao == 3)
            {
                float triangulo = CalculaAreaTriangulo();
                Console.WriteLine("Área do Triângulo é: " + triangulo);
            }
        }

        public float CalculaAreaQuadrado()
        {
            AreaCalculada = Base * Base;
            return AreaCalculada;
        }
        public float CalculaAreaRetangulo()
        {
            AreaCalculada = Base * Altura;
            return AreaCalculada;
        }
        public float CalculaAreaTriangulo()
        {
            AreaCalculada = (Base * Altura)/2;
            return AreaCalculada;
        }
    }
}
