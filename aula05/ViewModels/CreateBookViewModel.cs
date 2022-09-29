using Flunt.Notifications;
using Flunt.Validations;

public class CreateBookViewModel : Notifiable<Notification>

{
  public string Title { get; set; }
  public string Author { get; set; }

  public int Pages { get; set; }

  public Book MapTo()
  {
    AddNotifications(new Contract<Notification>()
      .Requires()
      .IsNotNullOrEmpty(Title, "Title", "O título é obrigatório")
      .IsNotNullOrEmpty(Author, "Author", "O autor é obrigatório")
      .IsGreaterThan(Pages, 0, "Pages", "O número de páginas deve ser maior que zero")
    );
    return new Book(Guid.NewGuid(), Title, Author, Pages);
  }
}