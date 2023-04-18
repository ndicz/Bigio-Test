using BigioDomain.Entities;

namespace BigioDomain.Repositories;

public interface ISiswaRepository
{
    Task<IEnumerable<Siswa>> FindAllSiswaAsync();
    Siswa FindSiswaById(int id);
    void Insert(Siswa siswa);
    void Edit(Siswa siswa);
    void Remove(Siswa siswa);
    IEnumerable<Siswa> FindAllSiswa();
    IEnumerable<Siswa> FindLastSiswaId();
}