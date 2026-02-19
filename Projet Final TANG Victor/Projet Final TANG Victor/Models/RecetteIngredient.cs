using Projet_Final_TANG_Victor.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Final_TANG_Victor.Models
{
    public class RecetteIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IngredientId { get; set; }

        [ForeignKey("IngredientId")]
        public Ingredient? Ingredient { get; set; }

        public int RecetteId { get; set; }
        [ForeignKey("RecetteId")]
        public Recette? Recette { get; set; }

        [Required(ErrorMessage = "Quantité requise")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantité non conforme")]
        public int Quantity { get; set; }

        public RecetteIngredient() { }
        public RecetteIngredient(int ingredientId, int recetteId, int quantity)
        {
            IngredientId = ingredientId;
            RecetteId = recetteId;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Recette n°{Id} - Ingredient : {Ingredient} - Recette : {Recette} - Quantité : {Quantity}";
        }
    }
}
