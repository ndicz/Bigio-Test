using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigioDomain.Entities
{
    [Table("siswa")]
    public class Siswa
    {
        [Key] public int id_siswa { get; set; }
        public string nama { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}