namespace ExercicioDoisInterface
{
    internal class Empreiteira : Empresa, IEmpresa
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, string setor) : base(nomeFantasia, razaoSocial, cNPJ, setor)
        {
        }

        public void ImprimeInfo()
        {
            Console.WriteLine($"Nome Fantasia: {NomeFantasia}");
            Console.WriteLine($"Razão Social: {RazaoSocial}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Setor: {Setor}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda de Serviços realizada!");
        }
    }
}
