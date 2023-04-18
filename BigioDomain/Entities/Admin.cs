using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities;

[Table("admin")]
public class Admin
{
    [Key]
    public int id_admin { get; set; }
    public string nama { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}