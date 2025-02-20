using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    // Contexte de base de données pour l'application ContosoPizza
    public class PizzaContext : DbContext
    {
        // Constructeur qui accepte les options de configuration du contexte
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        // DbSet représentant la collection de pizzas dans la base de données
        public DbSet<ContosoPizza.Models.Pizza>? Pizzas { get; set; }
    }
}
