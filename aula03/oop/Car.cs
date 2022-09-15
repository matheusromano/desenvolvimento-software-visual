class Car : Vehicle {
  public string model;
  // Class member fields
  public string color;
  public int year;

  string privateVariable; // private variable
  

  // Class constructor
  public Car(string model, string color, int year) {
    this.model = model;
    this.color = color;
    this.year = year;
  }

  public void fullThrottle() {
    Console.WriteLine("The car is going as fast as it can!");
  }
}