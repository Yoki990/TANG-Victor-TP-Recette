using System.ComponentModel.DataAnnotations;

namespace Projet_Final_TANG_Victor.Models
{
    public class Recette
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nom de la Recette requise")]
        [StringLength(255,ErrorMessage = "Saisie incorrecte")]
        public string Title {  get; set; }
        
        [Required(ErrorMessage = "Nom de la Recette requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Nom de la Recette requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Instruction {  get; set; }
        
        [Required(ErrorMessage = "Nom de la Recette requise")]
        [StringLength(255, ErrorMessage = "Saisie incorrecte")]
        public string Author {  get; set; }


        public Recette() { }
        public Recette(string title, string description, string instruction, string author)
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
