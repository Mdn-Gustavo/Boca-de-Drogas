namespace BOCACS;

public class Droga
{
    public string Nome { get; set; }

    // resolvi colar double pq na documentaçao da microsoft diz ser mais preciso
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    // craindo nueva droga
    public Droga(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    // 1 regra - estoque de drogas
    public void EntrarEstoqueDrogas(int estoque)
    {
        if (estoque < Quantidade)
        {
            Console.WriteLine("Não possuimos essa quantidade de drogas");
            return;
        }
        estoque += Quantidade;
    }
    
    public 
    
    
    
    
}