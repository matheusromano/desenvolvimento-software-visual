namespace Ex1 {
  class Program {
    static void Main (string[] args){
      Console.WriteLine("--- conversor de moedas ---");
      Console.WriteLine("Digite o valor em real: ");
      double real = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite a moeda para converter: ");
      string moeda = Console.ReadLine();
      double conversao = 0;
      switch (moeda) {
        case "dolar":
          conversao = real / 5.17;
          break;
        case "euro":
          conversao = real / 6.14;
          break;
        case "peso argentino":
          conversao = real / 0.05;
          break;
        case "yen":
          conversao = real / 0.28;
          break;
        default:
          Console.WriteLine("Moeda inválida");
          break;
      }
      Console.WriteLine($"{real} reais equivalem a {conversao} {moeda}");
      Console.Write($"{Environment.NewLine}Presione qualquer tecla para sair...");
    }
  }
}

