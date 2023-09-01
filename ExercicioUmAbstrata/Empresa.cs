namespace ExercicioUmAbstrata
{
    public abstract class Empresa
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Setor { get; set; }

        public Empresa(string nomeFantasia, string razaoSocial, string cNPJ, string setor)
        {
            NomeFantasia = nomeFantasia ?? throw new ArgumentNullException(nameof(nomeFantasia));
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            CNPJ = cNPJ ?? throw new ArgumentNullException(nameof(cNPJ));
            Setor = setor ?? throw new ArgumentNullException(nameof(setor));
        }

        public abstract void ImprimeInfo();
        public abstract void RealizarVenda();
    }
}

