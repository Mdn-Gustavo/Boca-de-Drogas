using System.Runtime.CompilerServices;

namespace BOCACS;
public class Consumidor
{
  public string Nome { get; set; }
  public double Divida { get; set; }
  
  public Consumidor(string nome)
  {
    Nome = nome;
    Divida = 0;
  } 
    
  public void AdicionarDivida(double valor)
  {
    Divida += valor;
  }

  public void PagarDivida(double valor)
  {
    if (valor <= 0)
    {
      Console.WriteLine("Valor invalido");
      return;
    }

    if (Divida < valor)
    {
      Console.WriteLine("Seu valor é maior que a divida, pagando o total");
      Divida = 0;
    }
    else
    {
      Divida -= valor;
    }
  }

  public void Exibir()
  {
    Console.WriteLine($"Nome: {Nome} - Divida: R${Divida}");
  }
}