using Microsoft.EntityFrameworkCore;
using AsysYa.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// InMemory DB (mínimo indispensable)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("AsysYaDb"));

var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();

// DbContext mínimo
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Provider> Providers => Set<Provider>();
}
