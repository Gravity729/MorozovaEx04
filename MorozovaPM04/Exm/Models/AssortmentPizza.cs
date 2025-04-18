using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class AssortmentPizza
    {
        public AssortmentPizza()
        {
            OrdersAssortment = new HashSet<OrdersAssortment>();
        }

        public int IdAssortmentPizza { get; set; }
        public int? IdPizza { get; set; }
        public int? IdSizePizza { get; set; }
        public int? IdWeightPizza { get; set; }
        public double? Price { get; set; }

        public virtual Pizza IdPizzaNavigation { get; set; }
        public virtual SizePizza IdSizePizzaNavigation { get; set; }
        public virtual WeightPizza IdWeightPizzaNavigation { get; set; }
        public virtual ICollection<OrdersAssortment> OrdersAssortment { get; set; }
    }
}
