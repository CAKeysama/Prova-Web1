using Microsoft.EntityFrameworkCore;
using ProvaWeb1.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do banco em memória
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("UsuariosDB"));

// Adiciona suporte a Controllers e Views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração do pipeline de requisições
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Define a rota padrão do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
