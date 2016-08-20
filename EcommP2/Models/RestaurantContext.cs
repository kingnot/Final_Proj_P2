/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Yiqi Zhang 200295414
 * Siqian Yu 200286902
 * Date Modified: 08-19-2016
 * File Description: This is the RestaurantContext model used as an aggregate model for the Foods, Carts, 
 *                   Orders, and Order Details
 */


namespace EcommP2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
