var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Configure Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Specify the Swagger endpoint
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Read RainFall");
    });
}

// Enable HTTPS redirection
app.UseHttpsRedirection();

// Enable authorization (if needed)
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();
