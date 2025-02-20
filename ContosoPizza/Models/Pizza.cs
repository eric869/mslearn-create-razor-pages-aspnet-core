using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

// Classe représentant une pizza
public class Pizza
{
    // Identifiant unique de la pizza
    public int Id { get; set; }

    // Nom de la pizza, requis
    [Required]
    public string? Name { get; set; }

    // Taille de la pizza
    public PizzaSize Size { get; set; }

    // Indique si la pizza est sans gluten
    public bool IsGlutenFree { get; set; }

    // Prix de la pizza, doit être compris entre 0.01 et 9999.99
    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}

// Enumération représentant les tailles de pizza
public enum PizzaSize { Small, Medium, Large }