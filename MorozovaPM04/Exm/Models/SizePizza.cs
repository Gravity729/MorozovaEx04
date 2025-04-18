using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class SizePizza
    {
        public SizePizza()
        {
            AssortmentPizza = new HashSet<AssortmentPizza>();
        }

        public int IdSizePizza { get; set; }
        public string NameSize { get; set; }

        public virtual ICollection<AssortmentPizza> AssortmentPizza { get; set; }
    }
}
