namespace ExercicioUmAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            Varejo varejo = new("Varejão", "Varejão LTDA", "1234567", "Varejo");

            Empreiteira empreiteira = new("Empreiteirona", "Empreiteira da panterona LTDA", "2345321", "Construção Civil");

            listaEmpresas.Add(varejo);
            listaEmpresas.Add(empreiteira);

            Console.WriteLine("Exercício 1 - Classes abstratas");

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