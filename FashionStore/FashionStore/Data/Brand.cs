using System.ComponentModel.DataAnnotations;

namespace FashionStore.Data
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int IsDeleted { get; set; }
    }
}
