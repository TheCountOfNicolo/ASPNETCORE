using System.Net.Mime;

WebApplicationBuilder build = WebApplication.CreateBuilder(args);
var app = build.Build();

app.MapGet("/", (HttpResponse httpResponse) =>
{
    httpResponse.StatusCode = 418;
    httpResponse.ContentType = MediaTypeNames.Text.Plain;
    return httpResponse.WriteAsync("I am a teapot!");
});

app.Run();