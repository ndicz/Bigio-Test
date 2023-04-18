using BigioDomain.Entities;

namespace BigioDomain.Repositories;

public interface INilaiRepository
{
    Task<IEnumerable<Nilai>> FindAllNilaiAsync();
    Nilai FindNilaiById(int id);
    void Insert(Nilai nilai);
    void Edit(Nilai nilai);
    void Remove(Nilai nilai);
    IEnumerable<Nilai> FindAllNilai();
    IEnumerable<Nilai> FindLastNilaiId();
}