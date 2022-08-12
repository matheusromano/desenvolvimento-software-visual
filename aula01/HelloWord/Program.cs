using System;

// This is the entry point of the program. Everything declared here will be executed when the program is run.
namespace HelloWorld
{
  //functions must be declared inside the class
  class Program
  {
    // methods names must start with a capital letter
    static void Main(string[] args)
    {
      Console.WriteLine("Qual o seu nome?");
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      Console.WriteLine($"{Environment.NewLine}Olá {name}, hoje é {currentDate:d} e agora são {currentDate:t}.");

      try {
      Console.WriteLine("Digite o valor da base: ");
      double largura = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite o valor da altura:");
      double altura = Convert.ToDouble(Console.ReadLine());
      double area = CalcularArea(largura, altura);
      Console.WriteLine($"A área da figura é {area}"); 
      }
      catch (Exception e) {
        Console.WriteLine($"Erro: {e.Message}");
      }
      
      Console.Write($"{Environment.NewLine}Presione qualquer tecla para sair...");
      Console.ReadKey(true);
    }

    static double CalcularArea(double largura, double altura)
    {
      return (largura * altura) / 2;
    }
  }
}
