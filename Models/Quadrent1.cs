using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mission8.Models;

public class Quadrent1
{
    [Key]
    public int Q1Id { get; set; }
    public string Task  { get; set; }
    public DateOnly DataType { get; set; }
    public int Quadrant { get; set; }
    
    [ForeignKey("TypeId")]
    public int TypeId { get; set; }
    public Type Type { get; set; }
    public bool TruFalse { get; set; }
    
    
    
}