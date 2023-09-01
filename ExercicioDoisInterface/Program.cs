namespace ExercicioDoisInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmpresa> listaEmpresas = new List<IEmpresa>();

            IEmpresa varejo = new Varejo("Varejão", "Varejão LTDA", "1234567", "Varejo");

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