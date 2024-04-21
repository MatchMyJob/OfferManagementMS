using Domain.Entities;

namespace Application.Interfaces
{
        public interface IProvinceQuery
        {
            public Task<List<Provinces>> GetAllProvince();
            public Task<Provinces> GetProvinceById(int provinceId);

        }
}