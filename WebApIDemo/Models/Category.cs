using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApIDemo.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name should not be empty")]
        [MaxLength(100, ErrorMessage = "category Name should not be more than 100 characters")]
        public string CatName { get; set; }
    }
}
