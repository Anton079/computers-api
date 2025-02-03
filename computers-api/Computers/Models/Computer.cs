using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace computers_api.Computers.Models
{
    [Table("computer")]
    public class Computer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [Column("model")]
        public string model { get; set; }

        [Required]
        [Column("Price")]
        public int Price { get; set; }

    }
}
