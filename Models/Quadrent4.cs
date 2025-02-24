using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission8.Models;

public class Quadrent4
{
    [Key]
    public int Q4Id { get; set; }
    public DateOnly DataType { get; set; }
    public int Quadrent { get; set; }
    
    [ForeignKey("TypeId")]
    public int TypeId { get; set; }
    public Type Type { get; set; }
    public bool TruFalse { get; set; }
}