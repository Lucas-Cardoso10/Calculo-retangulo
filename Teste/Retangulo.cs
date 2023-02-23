
namespace Teste
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura; ;
        }
        public double perimetro()
        {
            return (Largura + Altura) * 2;

        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
}
