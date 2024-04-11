namespace ExemploParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area= new Area();
            Console.WriteLine("Digite o valor da Base");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ESCOLHA QUAL A FIGURA QUE DESEJA SABER A AREA: \n1-QUADRADO \n2-RETÂNGULO \n3-TRIÂNGULO");
            int opcao = Convert.ToInt32(Console.ReadLine());
            area.Escolha(opcao);
        }
    }
}