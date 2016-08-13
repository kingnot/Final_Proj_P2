using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommP2.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }    
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int foodID { get; set; }
        public virtual Food Food { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}