using Microsoft.EntityFrameworkCore;
using Potfolio.Project.Data;


var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    WebRootPath = "FrontEnd" // Set FrontEnd as the web root
});

// Add services to the container.
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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

// Serve index.html at root
app.UseDefaultFiles(); // Looks for index.html by default
app.UseStaticFiles();  // Serves static files from FrontEnd

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
