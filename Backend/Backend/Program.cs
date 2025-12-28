using Backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Define a policy name
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:5175", "http://localhost:8081") // Specify the allowed origins
                  .AllowAnyHeader() // Allow any header to be sent
                  .AllowAnyMethod(); // Allow any HTTP method (GET, POST, PUT, DELETE, etc.)
        });
});


//services
builder.Services.AddControllers();
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

//middlewares
app.MapControllers();

app.Run();
