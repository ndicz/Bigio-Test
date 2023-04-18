using BigioDomain.Repositories;

namespace BigioDomain.Base
{
    public interface IRepositoryManager
    {

        INilaiRepository NilaiRepository { get; }
        IGuruRepository GuruRepository { get; }
        IAdminRepository AdminRepository { get; }
        ISiswaRepository SiswaRepository { get; }
    }
}
