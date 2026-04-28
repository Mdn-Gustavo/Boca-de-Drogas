using System.Globalization;
using BOCACS;

class Program
{
    public static List<Droga> drogas = new List<Droga>();
    public static List<Consumidor> consumidores = new List<Consumidor>();

    public static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE GESTÃO DA BOCA ===\n");
        
        int opcao = -1 ;
        while (opcao != 0)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1 - Cadastrar Droga");
            Console.WriteLine("2 - Listar Drogas");
            Console.WriteLine("3 - Entrada de Estoque");
            Console.WriteLine("4 - Cadastrar Consumidor");
            Console.WriteLine("5 - Listar Consumidores");
            Console.WriteLine("6 - Registrar venda");
            Console.WriteLine("7 - Consumidor pagar divida");
            Console.WriteLine("8 - Buscar droga");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarDroga(); break;
                case 2: ListarDrogas(); break;
                case 3: EntrarEstoque(); break;
                case 4: CadastrarConsumidor(); break;
                case 5: ListarConsumidor(); break;
                case 6: RegistrarVenda(); break;
                case 7: PagarDivida(); break;
                case 8: BuscarDroga(); break;
                case 0: Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Escreva uma opçao valida seu noia"); break;
            }
        }
    }
}