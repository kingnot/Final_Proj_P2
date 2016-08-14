/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Siqian Yu 200286902
 * Date Modified: 08-12-2016
 * File Description: This is the Model of Cart, which describe Order class with user and address info
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommP2.Models
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual string Username { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual decimal Total { get; set; }
        public virtual System.DateTime OrderDate { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}