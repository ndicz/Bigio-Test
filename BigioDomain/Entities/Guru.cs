using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities;

[Table("guru")]
public class Guru
{
    [Key]
    public int id_guru { get; set; }
    public string nama { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}