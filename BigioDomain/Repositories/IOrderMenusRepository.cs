using BigioDomain.Dto;
using BigioDomain.Entities;

namespace BigioDomain.Repositories
{
    public interface IOrderMenusRepository
    {
        IEnumerable<OrderMenus> FindAllOrderMenus();
        Task<IEnumerable<OrderMenus>> FindAllOrderMenusAsync();
        OrderMenus FindOrderMenusById(int id);
        void Insert(OrderMenus orderMenus);
        void Edit(OrderMenus orderMenus);
        void Remove(OrderMenus orderMenus);
        IEnumerable<OrderMenus> FindLastOrderMenusId();

        OrderMenusNestedMenusDetail GetOrmeNestedMenuDetail (int id);
    }
}
