using BigioDomain.Entities;

namespace BigioDomain.Repositories
{
    public interface IVendorRepository
    {
        IEnumerable<Vendor> FindAllVendor();
        Task<IEnumerable<Vendor>> FindAllVendorAsync();
        Vendor FindVendorById(int id);
        void Insert(Vendor vendor);
        void Edit(Vendor vendor);
        void Remove(Vendor vendor);
    }
}
