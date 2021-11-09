using Microsoft.EntityFrameworkCore;

namespace Core.Entities
{
    [Keyless]
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; }
    }
}