namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULO DE ÁREA QUADRADO OU RETÂNGULO");
            Area area= new Area();
            Console.WriteLine("Digite o valor da Base");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("O valor da área é " + area.Calcular() + " e o formato é " + area.Calcular2());
            Console.WriteLine("O valor da área é: " + area.Calcular());
            Console.WriteLine("O formato é: " + area.Calcular2());

            area.MostraDetalhes();


        }
    }
}