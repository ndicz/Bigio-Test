using BigioDomain.Entities;

namespace BigioDomain.Repositories
{
    public interface IMenuPhotosRepository
    {
        IEnumerable<MenuPhotos> FindAllMenuPhotos();
        Task<IEnumerable<MenuPhotos>> FindAllMenuPhotosAsync();
        MenuPhotos FindMenuPhotosById(int id);
        void Insert(MenuPhotos menuPhotos);
        void Edit(MenuPhotos menuPhotos);
        void Remove(MenuPhotos menuPhotos);
        IEnumerable<MenuPhotos> FindLastMenuPhotosId();
    }
}
