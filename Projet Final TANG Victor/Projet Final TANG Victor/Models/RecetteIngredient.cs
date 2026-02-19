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

        public int IngredientId {  get; set; }
        
        [ForeignKey("IngredientId")]
        public Ingredient? Ingredient { get; set; }

        public int RecetteId {  get; set; }
        [ForeignKey("RecetteId")]
        public Recette? Recette { get; set; }

        public RecetteIngredient() { }
        public RecetteIngredient(int ingredientId, int recetteId)
        {
            IngredientId = ingredientId;
            RecetteId = recetteId;
        }

        public override string ToString()
        {
            return $"Recette n°{Id} - Ingredient : {Ingredient} - Recette : {Recette}";
        }
    }
}
