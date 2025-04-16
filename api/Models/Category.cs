using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Category
    {
        public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Slug { get; set; } = "";

    public required ICollection<Image> Images { get; set; }
    }
}