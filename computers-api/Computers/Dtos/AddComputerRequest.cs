using System.ComponentModel.DataAnnotations;

namespace computers_api.Computers.Dtos
{
    public class AddComputerRequest
    {
        [Required(ErrorMessage = "Type ul este null, trebuie sa il completezi")]
        [StringLength(100, ErrorMessage = "Trebuie sa aiba maxim 100 de caractere")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Model ul este null, trebuie sa il completezi")]
        [StringLength(100, ErrorMessage = "Trebuie sa aiba maxim 100 de caractere")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Price este null, trebuie sa il completezi")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Trebuie o valoare mai mare de 0")]
        public int? Price { get; set; }
    }
}
