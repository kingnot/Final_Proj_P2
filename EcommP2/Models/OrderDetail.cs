/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Siqian Yu 200286902
 * Date Modified: 08-12-2016
 * File Description: This is the Model of OrderDetail, which describe the detail of an order
 *      with quantity, unit price and reference food and order
 */

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