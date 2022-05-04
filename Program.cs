using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>();


var app = builder.Build();

using (var db = new ApplicationDbContext())
{
    db.Database.EnsureCreated();
    db.Database.Migrate();
    db.SeedDatabaseIfEmpty();
}



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( options => 
    {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            options.RoutePrefix = string.Empty;
    }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
