namespace BOCACS;

public class Droga
{
    public string Nome { get; set; }

    // resolvi colar double pq na documentaçao da microsoft diz ser mais preciso
    public double Preco { get; set; }
    public int Estoque{ get; set; }

    // craindo nueva droga
    public Droga(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
    // 1 regra - estoque as drogas
    // Mudar para que ele exiba a quantidade do estoque e possa adicionar quantidade no estoque ao inves de verificar se a quantidade ta la
    public void EntrarEstoqueDrogas(int quantidade)
    {
        if (quantidade <= 0){
            Console.WriteLine("Quantidade invalida");
            return;
        }
        Console.WriteLine("Atualizando estoque...");
        Estoque += quantidade;
    }
    // 2 regra - vender drogas
    public bool VenderDroga(int quantidade)
    {
        if (quantidade <= 0)
        {
            Console.WriteLine("Quantidade invalida");
            return false;
        }

        if (quantidade > Estoque)
        {
            Console.WriteLine("Estoque insuficiente");
            return false;
        }
        Estoque -= quantidade;
        return true;
    }
    // exibir mostrado nas arla do professor
    public void Exibir()
    {
        Console.WriteLine($" [{Nome}] - R$ {Preco} - Estoque: {Estoque}");
    }
    
    
    
    
}