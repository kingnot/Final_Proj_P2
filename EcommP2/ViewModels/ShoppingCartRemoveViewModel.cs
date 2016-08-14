/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Siqian Yu 200286902
 * Date Modified: 08-05-2016
 * File Description: This is the ViewModel with stongly-typed class, 
 * having total price and other info for removing items from cart.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommP2.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteId { get; set; }
    }
}