using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUmAbstrata
{
    internal class Empreiteira : Empresa
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, string setor) : base(nomeFantasia, razaoSocial, cNPJ, setor)
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
            Console.WriteLine("Venda de Serviços realizada!");
        }
    }
}
