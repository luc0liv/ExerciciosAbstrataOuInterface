using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoisInterface
{
    internal class Varejo : Empresa, IEmpresa
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, string setor) : base(nomeFantasia, razaoSocial, cNPJ, setor)
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
            Console.WriteLine("Venda de PRODUTOS realizada!");
        }
    }
}
