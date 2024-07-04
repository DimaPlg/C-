using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkerStatus.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 2), Required]
        public string? Surname { get; set; }

        [StringLength(60, MinimumLength = 2), Required]
        public string? Patronymic { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [StringLength(20, MinimumLength = 2), Required]
        public string? Position { get; set; }

        [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal HourlyRate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20, MinimumLength = 2)]
        public string? Team { get; set; }

    }
}
