using System.ComponentModel.DataAnnotations;

namespace mission8.Models;

public class Type
{
    [Key]
    public int TypeId { get; set; }
    public string TypeName { get; set; }
}