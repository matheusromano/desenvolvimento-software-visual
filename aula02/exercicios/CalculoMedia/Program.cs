namespace Ex1
{
  class Program
  {
    static void Main(string[] args)
    {
      double[] notas = {2,4,6,8,2, 3, 3, 3};
      double media = CalcularMedia(notas);
      double mediana = CalcularMediana(notas);
      double moda = CalcularModa(notas);
      Console.WriteLine($"A media de notas é: {media}");
      Console.WriteLine($"A mediana de notas é: {mediana}");
      Console.WriteLine($"A moda de notas é: {moda}");
    }

    static double CalcularMedia(double[] notas)
    {
      double media = 0.0;
      double soma = 0.0;
      for (int i = 0; i < notas.Length; i++)
      {
        soma += notas[i];
      }
      media = soma / notas.Length;
      return media;
    }

    static double CalcularMediana (double[] notas)
    {
      double mediana = 0;
      Array.Sort(notas); 
      if (notas.Length % 2 == 0)
      {       
        mediana = (notas[notas.Length / 2] + notas[notas.Length / 2 - 1]) / 2;
      }
      else
      {
        mediana = notas[notas.Length / 2];
      }
      return mediana;
    }

    static double CalcularModa(double[] notas)
    {
      double moda = 0;
      int[] vetor = new int[notas.Length];
      for (int i = 0; i < notas.Length; i++)
      {
        for (int j = 0; j < notas.Length; j++)
        {
          if (notas[i] == notas[j])
          {
            vetor[i]++;
          }
        }
      }
      
      int maior = 0;
      for (int i = 0; i < vetor.Length; i++)
      {
        if (vetor[i] > maior)
        {
          maior = vetor[i];
          moda = notas[i];
        }
      }
      return moda;
    }
  }
}


