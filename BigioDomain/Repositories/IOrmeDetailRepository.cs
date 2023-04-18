using BigioDomain.Dto;
using BigioDomain.Entities;

namespace BigioDomain.Repositories
{
    public interface IOrmeDetailRepository
    {
        IEnumerable<OrmeDetail> FindAllOrmeDetail();
        Task<IEnumerable<OrmeDetail>> FindAllOrmeDetailAsync();
        OrmeDetail FindOrmeDetailById(int id);
        void Insert(NewOrderMenusDto orderMenusDto);
        void Edit(NewOrderMenusDto ormeDetail);
        void Remove(OrmeDetail ormeDetail);
        IEnumerable<OrmeDetail> FindLastOrmeDetailId();
    }
}
