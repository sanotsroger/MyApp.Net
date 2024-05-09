using System.ComponentModel.DataAnnotations;
namespace MyAPP.Models;

public class City
{
    [Key]
    [ScaffoldColumn(false)]
    public int Id { get; set; }

    [Required(ErrorMessage = "The {0} field is required")]
    [StringLength(60, MinimumLength = 3)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "The {0} field is required")]
    [StringLength(2)]
    public string? State { get; set; }
    
    [DataType(DataType.DateTime)]
    [ScaffoldColumn(false)]
    public DateTime CreatedAt { get; set;}

    public bool Active { get; set; }
}
