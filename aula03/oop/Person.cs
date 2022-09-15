class Person {
  private string name; //field
  private int age; // field

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }
  }

  //short-hand get and set
  public int Age { get; set; }
}