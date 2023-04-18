using BigioDomain.Base;
using BigioDomain.Repositories;

namespace Bigio.Presistence.Base;

public class RepositoryManager : IRepositoryManager
{
    private AdoDbContext _adoContext;
    private INilaiRepository _nilaiRepository;
    private IGuruRepository _guruRepository;
    private IAdminRepository _adminRepository;
    private ISiswaRepository _siswaRepository;

    public RepositoryManager()
    {
    }

    public RepositoryManager(AdoDbContext adoContext)
    {
        _adoContext = adoContext;
    }

    public INilaiRepository NilaiRepository
    {
        get
        {
            if (_nilaiRepository == null)
            {
                _nilaiRepository = new NilaiRepository(_adoContext);
            }
            return _nilaiRepository;
        }
    }
    public IGuruRepository GuruRepository { get; }
    public IAdminRepository AdminRepository { get; }
    public ISiswaRepository SiswaRepository { get; }
}