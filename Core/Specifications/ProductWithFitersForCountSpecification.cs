using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFitersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFitersForCountSpecification(ProductSpecParams productParams)
            :base(x =>
                  (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) 
                    && (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
                 )
        {
            
        }
    }
}