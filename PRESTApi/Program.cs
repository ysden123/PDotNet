using PRESTApi.Data;
using PRESTApi.Service;

namespace PRESTApi
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/readPerson", () => PersonService.ReadPerson());
            app.MapGet("/person/{name}", (string name) => PersonService.ReadPerson(name));
            app.MapGet("/allPersons", () => PersonService.ReadAllPersons());

            app.MapPost("/addPerson", (Person person) => PersonService.AddPerson(person));

            app.Run();
        }
    }
}
