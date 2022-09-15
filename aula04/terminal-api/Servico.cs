namespace visual {
    class Usuario{
      static int UID = 0;

      int id;
      string username;
      string hash;

      public Usuario(string u, string p) {
          id = GetUID();
          SetUsername(u);
          ApplyHash(p);
      }

      static int GetUID() {
          UID++;
          return UID;
      }

      void ApplyHash(string password) {
        // TODO: implementar hash
        hash = password;
      }

      // getter and setters
      public string GetUsername() {
        return username;
      }

      public string GetHash() {
        return hash;
      }

      public void SetUsername(string u) {
        username = u;
      }

      public string Serialize () {
        return $"{id}, {username}, {hash}";
      }
    }

    class UserBase {

      string fileName;
      List<Usuario> usuarios;

      public UserBase(string f) {
        
        fileName = f;
        usuarios = new List<Usuario>();
        LoadUsers();
      }

      void LoadUsers() {
        //TODO: implementar leitura de arquivo
      }

      //Cria o usurario na base
      public void AddUser(Usuario u) {
        usuarios.Add(u);
      }

      //Salva a base de dados em arquivo
      public void SaveUsers() {
        string output = "";

        foreach (Usuario u in usuarios) {
          output += u.Serialize() + Environment.NewLine;
        }
        File.WriteAllText(fileName, output);
      }
    }

      
}
