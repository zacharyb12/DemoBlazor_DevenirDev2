using System.ComponentModel.DataAnnotations;

namespace DemoBlazor_DevenirDev2.Models
{
    public class UpdateComputerDTOs
    {
        [Required(ErrorMessage = "Le nom est obligatoire")]
        [MinLength(3, ErrorMessage = "Le nom doit faire au moins 3 caractères")]
        [MaxLength(50, ErrorMessage = "Le nom doit faire au maximum 50 caractères")]
        public string Name { get; set; }


        [Required(ErrorMessage = "La ram  est obligatoire")]
        [Range(8, 128, ErrorMessage = "La ram doit avoir au minimum 8gb et maximum 128gb ")]
        public int Ram { get; set; }

        [Required(ErrorMessage = "la Memoire  est obligatoire")]
        [Range(1, 200, ErrorMessage = "La memoire doit être entre 1Tb et 200 Tb ")]
        public int Memory { get; set; }

        [Required(ErrorMessage = "Le prix  est obligatoire")]
        [Range(1, 9999, ErrorMessage = "Le prix doit être entre 1 et 9999 €")]
        public double Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
