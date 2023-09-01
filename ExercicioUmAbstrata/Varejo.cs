namespace ExercicioUmAbstrata
{
    internal class Varejo : Empresa
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, string setor) : base(nomeFantasia, razaoSocial, cNPJ, setor)
        {
        }

        public override void ImprimeInfo()
        {
            Console.WriteLine($"Nome Fantasia: {NomeFantasia}");
            Console.WriteLine($"Razão Social: {RazaoSocial}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Setor: {Setor}");
        }

        public override void RealizarVenda()
        {
            Console.WriteLine("Venda de PRODUTOS realizada!");
        }
    }
}
