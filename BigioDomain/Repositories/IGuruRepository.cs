using BigioDomain.Entities;

namespace BigioDomain.Repositories
{

    public interface IGuruRepository
    {
        Task<IEnumerable<Guru>> FindAllGuruAsync();
        Guru FindGuruById(int id);
        void Insert(Guru guru);
        void Edit(Guru guru);
        void Remove(Guru guru);
        IEnumerable<Guru> FindAllGuru();
        IEnumerable<Guru> FindLastGuruId();
    }
}