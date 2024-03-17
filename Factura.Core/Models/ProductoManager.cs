namespace FacturaApp.Models
{
    using Abp.Domain.Repositories;
    using Abp.Domain.Services;
    using Abp.UI;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class ProductoManager : DomainService, IProductoManager {
        private readonly IRepository<ProductoModel> _repositoryProducto;

        public ProductoManager(IRepository<ProductoModel> repositoryProducto)
        {
            _repositoryProducto = repositoryProducto;
        }

        public async Task<ProductoModel> Create(ProductoModel entity)
        {
            var Producto = _repositoryProducto.FirstOrDefault(x => x.idProducto == entity.idProducto);
            if (Producto != null)
            {
                throw new UserFriendlyException("Ya existe");
            }
            else
            {
                return await _repositoryProducto.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var Producto = _repositoryProducto.FirstOrDefault(x => x.idProducto == id);
            if (Producto == null)
            {
                throw new UserFriendlyException("No encontraron Data");
            }
            else
            {
                _repositoryProducto.Delete(Producto);

            }
        }

        public IEnumerable<ProductoModel> GetAlllist()
        {
            return _repositoryProducto.GetAllIncluding(x => x.idProducto);
        }

        public ProductoModel GetProductoByID(int id)
        {
            return _repositoryProducto.Get(id);
        }

        public void Update(ProductoModel entidy)
        {
            _repositoryProducto.Update(entidy);
        }
    }

}

