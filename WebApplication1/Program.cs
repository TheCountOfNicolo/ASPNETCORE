var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Person> list = new List<Person>{
    new("Max","Alex"),
    new("Bonny","Clide"),
    new("Boris","Barbaris"),
    new("Elena","Carl"),
    new("Avalon","Asteroid"),
    new("Arkhimed","Asterix")
};

app.MapGet("/person{name}", (string name) => list.Where(p => p.firstName.StartsWith(name)));
app.Run();

public record Person(string firstName, string secondName);