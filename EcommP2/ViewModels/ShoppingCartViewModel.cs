/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Siqian Yu 200286902
 * Date Modified: 08-12-2016
 * File Description: This is the ViewModel with stongly-typed class, having total price and all items in the cart.
 */

using EcommP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommP2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}