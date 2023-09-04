using System.Runtime.Intrinsics.X86;

namespace ExercicioDoisInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Vamos pegar o projeto de vcs da Empresa com interfaces!
        //Crie uma interface EnviarNotificacao com um método void EnviarMensagemCliente.
        //Crie uma classe EnviarNotificacaoWhatsApp, que implementa EnviarNotificacao e
        //nela teremos o método EnviarMensagemCliente que printa a notificação: "Estou enviando uma mensagem no WhatsApp do Cliente!";

        //Dentro da classe Varejo, vamos incluir um private readonly EnviarNotificacaoWhatsApp que é recebido no construtor da classe.
        //Após Realizar a venda, utilizaremos o método de EnviarNotificacao.

                    List<IEmpresa> listaEmpresas = new List<IEmpresa>();

            IEmpresa varejo = new Varejo("Varejão", "Varejão LTDA", "1234567", "Varejo", new EnviarNotificacaoWhatsapp());

            IEmpresa empreiteira = new Empreiteira("Empreiteirona", "Empreiteira da panterona LTDA", "2345321", "Construção Civil");

            listaEmpresas.Add(varejo);
            listaEmpresas.Add(empreiteira);

            Console.WriteLine("Exercício 2 -  Interface");

            listaEmpresas.ForEach(empresa =>
            {
                empresa.ImprimeInfo();
                empresa.RealizarVenda();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            });
        }
    }
}