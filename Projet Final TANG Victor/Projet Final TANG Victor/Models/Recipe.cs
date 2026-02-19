using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_Final_TANG_Victor.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nom de la Recette requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Instruction requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Instruction { get; set; }

        [Required(ErrorMessage = "Nom de l'auteur requis")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Author { get; set; }


        public Recipe() { }
        public Recipe(string title, string description, string instruction, string author)
        {
            Title = title;
            Description = description;
            Instruction = instruction;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Id} {Title} {Description} {Instruction} {Author}";
        }
    }
}
