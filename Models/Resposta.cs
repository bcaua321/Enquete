using System.ComponentModel.DataAnnotations;

namespace Enquete.Models
{
    public class Resposta 
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool Alternativa { get; set; }
    } 
}
