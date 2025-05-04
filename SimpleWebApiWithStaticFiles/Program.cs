
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.UseDefaultFiles(); // Ενεργοποιεί default index.html
app.UseStaticFiles();  // Ενεργοποιεί το wwwroot
app.MapControllers();

app.Run();
