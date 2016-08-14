/**
 * Authors & Student Number:
 * Mayank Raval 200300508
 * Fei Wang 200278460
 * Mayank Bhardwaj 200305245
 * Siqian Yu 200286902
 * Date Modified: 08-05-2016
 * File Description: This is the Model of Food, with all the info to describ a food item
 */

namespace EcommP2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        public int foodID { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        public decimal price { get; set; }

        [Required]
        public string image { get; set; }
    }
}
