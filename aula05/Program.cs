using aula05.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => Results.Ok(new Book(Guid.NewGuid(), "O Senhor dos Anéis", "J.R.R. Tolkien", 1178)));

app.MapGet("/v1/books", (AppDbContext context) =>
{
    var books = context.Books;
    return books is not null ? Results.Ok(books) : Results.NotFound();
});

app.MapGet("/v1/books/{id}", (AppDbContext context, Guid id) =>
{
    var book = context.Books.Find(id);
    return book is not null ? Results.Ok(book) : Results.NotFound();
});

app.MapPut("/v1/books", (AppDbContext context, CreateBookViewModel bookViewModel) =>
{
    var book = bookViewModel.MapTo();
    context.Books.Add(book);
    context.SaveChanges();
    return Results.Created($"/v1/books/{book.Id}", book);
});

app.MapDelete("/v1/books/{id}", (AppDbContext context, Guid id) =>
{
    var book = context.Books.Find(id);
    if (book is not null)
    {
        context.Books.Remove(book);
        context.SaveChanges();
        return Results.Ok();
    }
    return Results.NotFound();
});

app.MapPost("/v1/books", (AppDbContext context, CreateBookViewModel model) =>
{
    var book = model.MapTo();
    if (!model.IsValid)
        return Results.BadRequest(model.Notifications);

    context.Books.Add(book);
    context.SaveChanges();

    return Results.Created($"/v1/todos/{book.Id}", book);
});
app.Run();
