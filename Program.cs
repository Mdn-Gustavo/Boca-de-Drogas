using System.Globalization;
using BOCACS;

class Program
{
    // arraylist em c# pra guardar as dorgas e consumidores
    
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

            //coloquei uma funçao pra cada opcao pra ficar mais goat
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

    static void CadastrarDroga()
    {
        Console.WriteLine("Nome da droga: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Preço por unidade: ");
        double preco = double.Parse(Console.ReadLine());
        

        Console.WriteLine("Quantidade em estoque: ");
        int estoque = int.Parse(Console.ReadLine());
        
        drogas.Add(new Droga(nome, preco, estoque));
        Console.WriteLine("Droga cadastrada com sucesso!");
        
    }

    static void ListarDrogas()
    {
        if (drogas.Count == 0)
        {
            Console.WriteLine("nenhuma droga cadastrada");
            return;
        }
        foreach (Droga droga in drogas)
        {
            droga.Exibir();
        }
    }
    
    static void EntrarEstoque()
    {
        Console.WriteLine("Nome da droga: ");
        string nome = Console.ReadLine();
        Droga droga = drogas.Find(x => x.Nome == nome);
        if(droga == null) { Console.WriteLine("Nao encontrada.");
            return;
        }
        Console.WriteLine("Quantidade entrada: ");
        int quantidade = int.Parse(Console.ReadLine());
        droga.EntrarEstoqueDrogas(quantidade);
        Console.WriteLine("Estoque atualizado com sucesso!");
    }

    static void CadastrarConsumidor()
    {
        Console.WriteLine("Nome do consumidor: ");
        string nome = Console.ReadLine();
        consumidores.Add(new Consumidor(nome));
        Console.WriteLine("Consumidor cadastrado com sucesso!");
    }

    static void ListarConsumidor()
    {
        if (consumidores.Count == 0)
        {
            Console.WriteLine("nenhum consumidor cadastrado");
            return;
        }
        foreach (Consumidor consumidor in consumidores)
        {
            consumidor.Exibir();
        }
    }

    static void RegistrarVenda()
    {
        Console.WriteLine("Nome do consumidor: ");
        string nome = Console.ReadLine();
        Consumidor consumidor = consumidores.Find(x => x.Nome == nome);
        if(consumidor == null) { Console.WriteLine("Nao encontrado.");
            return;
        }
        Console.WriteLine("Nome da droga: ");
        string nomeDroga = Console.ReadLine();
        Droga droga = drogas.Find(x => x.Nome == nomeDroga);
        if(droga == null) { Console.WriteLine("Nao encontrada.");}
        
        Console.WriteLine("Quantidade vendida: ");
        int quantidade = int.Parse(Console.ReadLine());
        droga.VenderDroga(quantidade);
        consumidor.AdicionarDivida(quantidade * droga.Preco);
        Console.WriteLine($"Venda registrada com sucesso! Total da divida: R${consumidor.Divida}");
    }

    static void PagarDivida()
    {
        Console.WriteLine("Nome do consumidor: ");
        Consumidor consumidor = consumidores.Find(x => x.Nome == Console.ReadLine());
        if (consumidor == null)
        {
            Console.WriteLine("Não encontrado");
            return;
        }

        Console.WriteLine("Valor pago: ");
        double valor = double.Parse(Console.ReadLine());
        consumidor.PagarDivida(valor);
        Console.WriteLine("Divida paga com sucesso! Valor da divida atual: R$" + consumidor.Divida); 
    }

    static void BuscarDroga()
    {
        Console.WriteLine("Nome da droga: ");
        string nome = Console.ReadLine();
        Droga droga = drogas.Find(x => x.Nome == nome);
        if (droga == null) Console.WriteLine("Não encontrada");
        else droga.Exibir();
    }
}