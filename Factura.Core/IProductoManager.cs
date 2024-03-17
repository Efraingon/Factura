
namespace FacturaApp.Models
{
    using Abp.Domain.Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductoManager : IDomainService {

        IEnumerable<ProductoModel> GetAlllist();
        ProductoModel GetProductoByID(int id);
        Task<ProductoModel> Create(ProductoModel entity);
        void Update(ProductoModel entidy);
        void Delete(int id);
    }
}
