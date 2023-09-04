using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoisInterface
{
    internal class Varejo : Empresa, IEmpresa
    {
        public EnviarNotificacaoWhatsapp Notificacao { get; }
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, string setor, EnviarNotificacaoWhatsapp notificacao) : base(nomeFantasia, razaoSocial, cNPJ, setor)
        {
            Notificacao = notificacao;
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda de PRODUTOS realizada!");
            Notificacao.EnviarMensagemCliente();
        }
    }
}
