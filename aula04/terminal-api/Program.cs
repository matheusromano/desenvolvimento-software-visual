namespace visual{
  class Program{
    static void Main(string[] args){
      Usuario u = new Usuario("admin", "123456");
      Usuario u2 = new Usuario("lalala", "98765");
      Console.WriteLine("{0}, {1}", u.GetUsername(), u.GetHash());
      Console.WriteLine(u.Serialize());

      UserBase ub = new UserBase("usuarios.txt");
      ub.AddUser(u);
      ub.AddUser(u2);

      ub.SaveUsers();

    }
  }
}
