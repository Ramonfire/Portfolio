using Microsoft.EntityFrameworkCore;
using Portfolio.Project.Repositories.impl;
using Portfolio.Project.Repositories.Interfaces;
using Potfolio.Project.Data;


var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
});

// Add services to the container.
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IProjectsRepository, ProjectRepository>();
builder.Services.AddScoped<IMasteredLanguageRepository, MasteredLanguagesRepository>();

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
