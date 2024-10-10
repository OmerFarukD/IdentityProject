using IdentityProject.WebApi.Contexts;
using IdentityProject.WebApi.Repository.Abtstracts;
using IdentityProject.WebApi.Repository.Concretes;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<MsSqlContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
