using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Api.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public TransactionType Type { get; set; }

            // Relacionamento com User
        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

            // Relacionamento com Category
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}