using BigioDomain.Repositories;

namespace BigioDomain.Base
{
    public interface IRepositoryManager
    {
        IVendorRepository VendorRepository { get; }

        IRestoMenusRepository RestoMenusRepository { get; }

        IOrmeDetailRepository OrmeDetailRepository { get; }

        IOrderMenusRepository OrderMenusRepository { get; }

        IMenuPhotosRepository MenuPhotosRepository { get; }

        InilaiRepository nilaInilaiRepository { get; }
    }
}
