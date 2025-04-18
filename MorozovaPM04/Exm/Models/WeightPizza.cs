using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class WeightPizza
    {
        public WeightPizza()
        {
            AssortmentPizza = new HashSet<AssortmentPizza>();
        }

        public int IdWeightPizza { get; set; }
        public double? NameWeight { get; set; }

        public virtual ICollection<AssortmentPizza> AssortmentPizza { get; set; }
    }
}
