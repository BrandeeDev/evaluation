using System.ComponentModel.DataAnnotations;

namespace BNP.SeniorEvaluation.Domain;



public class Author
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    public ICollection<Book> Books { get; set; }
    
    public DateTime? DateCreated { get; set; }
    
    public DateTime? DateUpdated { get; set; }
}
