using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Data.Const.Category;

namespace Library.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(NameCategoryMaxLength)]
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
