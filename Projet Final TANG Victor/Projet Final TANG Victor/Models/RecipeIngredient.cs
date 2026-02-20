
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Final_TANG_Victor.Models
{
    public class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IngredientId { get; set; }

        [ForeignKey("IngredientId")]
        public Ingredient? Ingredient { get; set; }

        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe? Recipe { get; set; }

        [Required(ErrorMessage = "Quantité requise")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantité non conforme")]
        public int Quantity { get; set; }

        public RecipeIngredient() { }
        public RecipeIngredient(int ingredientId, int recipeId, int quantity)
        {
            IngredientId = ingredientId;
            RecipeId = recipeId;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Recette n°{Id} - Ingredient : {Ingredient} - Recette : {Recipe} - Quantité : {Quantity}";
        }
    }
}
