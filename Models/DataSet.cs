using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRISPR.Models
{
    public class DataSet
    {
        [Key]
        public int id { get; set; }
        public string Tilte { get; set; }
        public string SubTilte { get; set; }
        public string Description { get; set; }
        public string RepositoryURL { get; set; }
        public string Licenses { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public string FileURL { get; set; }
        public float Accuracy { get; set; }
        [NotMapped]
        public List<string> Tags { get; set; }
        [NotMapped]
        public List<Comment> Comments { get; set; }
        [NotMapped]
        public List<Code> Codes { get; set; }

    }
}
