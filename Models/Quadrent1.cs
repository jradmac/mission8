using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mission8.Models;

public class Quadrent1
{
    [Key]
    public int Q1Id { get; set; }
    [Required]
    public string Task  { get; set; }
    [Required]
    public DateOnly DataType { get; set; }
    [Required]
    public int Quadrant { get; set; }
    
    [ForeignKey("TypeId")]
    public int TypeId { get; set; }
    public Type Type { get; set; }
    [Required]
    public bool TruFalse { get; set; }
    
    
    
}