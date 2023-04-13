using System.ComponentModel.DataAnnotations.Schema;

namespace CRISPER.Models
{
    public class Model
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        [NotMapped]
        public IFormFile MyFile { get; set; }
    }
}
