namespace oop
{
  class Program
  {
    static void Main(string[] args)
    {
      // Car ford = new Car();
      // ford.color = "blue";
      // ford.model = "Fiesta";
      // ford.year = 2018;

      // Car audi = new Car();
      // audi.color = "black";
      // audi.model = "A4";
      // audi.year = 2019;

      // Console.WriteLine(ford.model);
      // Console.WriteLine(audi.model);

      Car carWithConstructor = new Car("Celta","blue", 2018);
      Console.WriteLine(carWithConstructor.model + " " + carWithConstructor.color + " " + carWithConstructor.year);

      Car ford = new Car("Fiesta", "blue", 2018);
      Car audi = new Car("A4", "black", 2019);
      Console.WriteLine(ford.model + " " + ford.color + " " + ford.year);
      Console.WriteLine(audi.model + " " + audi.color + " " + audi.year);
      ford.honk();
      Console.WriteLine(ford.brand + " " + ford.model + " " + ford.color + " " + ford.year);

      Console.WriteLine("===============================\n");

      Person me = new Person();
      me.Name = "Matheus";
      Console.WriteLine(me.Name);
      me.Age = 21;
      Console.WriteLine(me.Age);
    
    }
  }
}
