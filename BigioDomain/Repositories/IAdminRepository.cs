using BigioDomain.Entities;

namespace BigioDomain.Repositories
{

    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> FindAllAdminAsync();
        Admin FindAdminById(int id);
        void Insert(Admin admin);
        void Edit(Admin admin);
        void Remove(Admin admin);
        IEnumerable<Admin> FindAllAdmin();
        IEnumerable<Admin> FindLastAdminId();
    }
}