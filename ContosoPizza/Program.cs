using ContosoPizza.Data;
using ContosoPizza.Services;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Ajouter des services au conteneur.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PizzaContext>(options =>
    options.UseSqlite("Data Source=ContosoPizza.db"));
    
builder.Services.AddScoped<PizzaService>();

var app = builder.Build();

// Configurer le pipeline de requêtes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // La valeur HSTS par défaut est de 30 jours. Vous pouvez vouloir changer cela pour des scénarios de production, voir https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
