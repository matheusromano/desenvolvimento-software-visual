namespace niceFunction {
  class Program{
    public static void Main(string[] args) {
      string data = File.ReadAllText("mytext.txt");
      string []linhas = data.Split('\n');
      foreach (string linha in linhas) {
        string []conteudos = linha.Split('=');
        string key = conteudos[0];
        string value = conteudos[1];
        Console.WriteLine(key);
        Console.WriteLine(value);
      }

    }
  }
}
