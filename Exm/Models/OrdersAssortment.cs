using System;
using System.Collections.Generic;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Exm.Models
{
    public partial class OrdersAssortment
    {
        public int IdOrder { get; set; }
        public int? IdAssortmentPizza { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public double? House { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOrder { get; set; }
        public double? Cost { get; set; }

        public virtual AssortmentPizza IdAssortmentPizzaNavigation { get; set; }

        public string FullFoi => $"{Lastname} {Firstname} {Surname}";
        public string FullAdress => $"Адрес: {Street}, {House}, {Room}";

        public string SumDiscount => $"Итого: {CalculatingDiscount()}";

        public double? CalculatingDiscount()
        {
            using(var db= new MorozovaPM04Context())
            {
                double? total = db.AssortmentPizza
                    .Where(ap => ap.IdAssortmentPizza == IdAssortmentPizza)
                    .Sum(ap => ap.Price);

                if (total > 4000)
                {
                    double? sum = total * 0.07;
                    return sum;
                }
                else if (total > 2000)
                {
                    double? sum = total * 0.05;
                    return sum;
                }
                else
                    return total;
            }
        }
    }
}
