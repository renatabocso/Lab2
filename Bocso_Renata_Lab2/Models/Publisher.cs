using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bocso_Renata_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publishing Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
