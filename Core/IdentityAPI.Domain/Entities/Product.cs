using IdentityAPI.Domain.Entities.Common;

namespace IdentityAPI.Domain.Entities
{
    public class Product:Entity
    {
        public string  ProductName { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
