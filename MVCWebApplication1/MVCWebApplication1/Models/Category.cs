using System.ComponentModel.DataAnnotations;

namespace MVCWebApplication1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;  


    }
}
