using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities;

[Table("nilai")]
public class Nilai
{
    [Key]
    public int id_nilai { get; set; }
    public int id_siswa { get; set; }
    public int id_guru { get; set; }
    public int nilai { get; set; }
}