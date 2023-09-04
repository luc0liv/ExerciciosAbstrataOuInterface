namespace ExercicioDoisInterface
{
    internal class Empreiteira : Empresa, IEmpresa
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, string setor) : base(nomeFantasia, razaoSocial, cNPJ, setor)
        {
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda de Serviços realizada!");
        }
    }
}
