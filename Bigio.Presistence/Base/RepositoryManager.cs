using Bigio.Persistence.RepositoryContext;
using Bigio.Presistence.Repositories;
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
        get;
        // {
        //     // if (_nilaiRepository == null)
        //     // {
        //     //     _nilaiRepository = new NilaiRepository(_adoContext);
        //     // }
        //     // return _nilaiRepository;
        // }
    }
    public IGuruRepository GuruRepository
    {
        get;
        // {
        //     // if (_guruRepository == null)
        //     // {
        //     //     _guruRepository = new GuruRepository(_adoContext);
        //     // }
        //     // return _guruRepository;
        // }
    }
    public IAdminRepository AdminRepository
    {
        get
        {
            if (_adminRepository == null)
            {
                _adminRepository = new AdminRepository(_adoContext);
            }
            return _adminRepository;
        }
    }
    public ISiswaRepository SiswaRepository
    {
        get
        {
            if (_siswaRepository == null)
            {
                _siswaRepository = new SiswaRepository(_adoContext);
            }
            return _siswaRepository;
        }
    }
}