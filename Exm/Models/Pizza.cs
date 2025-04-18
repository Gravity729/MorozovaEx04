using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            AssortmentPizza = new HashSet<AssortmentPizza>();
        }

        public int IdPizza { get; set; }
        public string NamePizza { get; set; }
        public string Ingredients { get; set; }

        public virtual ICollection<AssortmentPizza> AssortmentPizza { get; set; }
    }
}
