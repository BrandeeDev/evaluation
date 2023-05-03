using System.ComponentModel.DataAnnotations;

namespace BNP.SeniorEvaluation.Domain;


public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Title { get; set; }
    
    public DateTime? DateCreated { get; set; }
    
    public DateTime? DateUpdated { get; set; }
    
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}