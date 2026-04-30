namespace BOCACS;

public class Droga
{
    public string Nome { get; set; }

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
    public void Exibir()
    {
        Console.WriteLine($" [{Nome}] - R$ {Preco} - Estoque: {Estoque}");
    }
    
    
    
    
}