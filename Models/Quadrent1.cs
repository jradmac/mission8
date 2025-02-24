using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace mission8.Models;

public class Quadrent1
{
    [Key]
    public int Q1Id { get; set; }
    public DateOnly DataType { get; set; }
    public int Quadrent { get; set; }
    
    [ForeignKey("TypeId")]
    public int TypeId { get; set; }
    public Type Type { get; set; }
    public bool TruFalse { get; set; }
    
    
    
}