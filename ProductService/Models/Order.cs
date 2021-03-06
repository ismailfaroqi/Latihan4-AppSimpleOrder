using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string TransCode { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime Created { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
