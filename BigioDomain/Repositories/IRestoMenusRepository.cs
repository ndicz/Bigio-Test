using BigioDomain.Entities;
using BigioDomain.RequestFeatures;

namespace BigioDomain.Repositories
{
    public interface IRestoMenusRepository
    {

        IEnumerable<RestoMenus> FindAllRestoMenus();
        Task<IEnumerable<RestoMenus>> FindAllRestoAsync();
        RestoMenus FindRestoById(int id);

    
        Task<IEnumerable<RestoMenus>> GetRestoMenuPaging(RestoMenusParameters restoMenusParameters);

        Task<PagedList<RestoMenus>> GetRestoMenuPagelist(RestoMenusParameters restoMenusParameters);


        void Insert(RestoMenus restoMenus);
        void Edit(RestoMenus restoMenus);
        void Remove(RestoMenus restoMenus);
        IEnumerable<RestoMenus> FindLastMenusId();

        int GetIdSequence();
    }
}
