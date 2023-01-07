using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bocso_Renata_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Author Last Name")]
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
