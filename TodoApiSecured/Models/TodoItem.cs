using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [Key]   //assume identity
        [Column(TypeName = "int")]
        public int Id { get; set; }
        
        [Required]
        [StringLength(70)]
        [Column(TypeName = "nvarchar(70)")]
        public string Title { get; set; }
        
        [Required]
        [Column(TypeName = "Is Sale")]
        public bool IsSale { get; set; }
    }
}
