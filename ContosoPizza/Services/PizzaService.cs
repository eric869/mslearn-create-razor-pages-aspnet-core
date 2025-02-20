using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    // Service pour gérer les opérations liées aux pizzas
    public class PizzaService
    {
        private readonly PizzaContext _context = default!;

        // Constructeur qui initialise le contexte de la base de données
        public PizzaService(PizzaContext context) 
        {
            _context = context;
        }
        
        // Méthode pour obtenir la liste des pizzas
        public IList<Pizza> GetPizzas()
        {
            if(_context.Pizzas != null)
            {
                return _context.Pizzas.ToList();
            }
            return new List<Pizza>();
        }

        // Méthode pour ajouter une nouvelle pizza
        public void AddPizza(Pizza pizza)
        {
            if (_context.Pizzas != null)
            {
                _context.Pizzas.Add(pizza);
                _context.SaveChanges();
            }
        }

        // Méthode pour supprimer une pizza par son identifiant
        public void DeletePizza(int id)
        {
            if (_context.Pizzas != null)
            {
                var pizza = _context.Pizzas.Find(id);
                if (pizza != null)
                {
                    _context.Pizzas.Remove(pizza);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
