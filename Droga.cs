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
    public void EntrarEstoqueDrogas(int quantidade)
    {
        if (Estoque <= quantidade)
        {
            Console.WriteLine("Não possuimos essa quantidade de drogas");
            return;
        }
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