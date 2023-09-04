using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoisInterface
{
    internal class Empresa
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

        public void ImprimeInfo()
        {
            Console.WriteLine($"Nome Fantasia: {NomeFantasia}");
            Console.WriteLine($"Razão Social: {RazaoSocial}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Setor: {Setor}");
        }
    }
}
