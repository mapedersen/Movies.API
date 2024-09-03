using Microsoft.EntityFrameworkCore;
using Movies.API.Data;
using Movies.API.Services;

var builder = WebApplication.CreateBuilder(args);


// Register DbContext with the DI Container
builder.Services.AddDbContext<MoviesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesDB")));
    
// Register application services
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
