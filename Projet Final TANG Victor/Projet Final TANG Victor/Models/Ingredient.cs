using System.ComponentModel.DataAnnotations;

namespace Projet_Final_TANG_Victor.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nom de l'ingrédient requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Catégorie requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Category {  get; set; }
        //public string Quantity {  get; set; }

        public Ingredient() { }
        public Ingredient(int id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Category}";
        }
    }
}
