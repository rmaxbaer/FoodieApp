using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieApp.Models
{
    public class Review
    {
        //Attributes
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public int Rank { get; }
        public string? FavoriteDish { get; set; }
        [Required]
        public string  Address { get; set; } 
        public string? RestaurantPhone { get; set; } 
        public string? RestaurantLink { get; set; } = "Coming soon.";

        //Methods
        public Review(int rank) // this establishes that Rank can only be set in the declaration, making it read only
        {
            Rank = rank;
        }
        public static Review[] GetReviews()
        {
            // declare and initiate the top 5
            Review r1 = new Review(1)
            {
                RestaurantName = "Maria Bonita",
                FavoriteDish = "Chimichanga",
                Address = "3815 167 W 800 N, Orem, UT 84057",
                RestaurantPhone = "8014267338",
                RestaurantLink = "https://www.mariabonitagrill.com/"
            };

            Review r2 = new Review(2)
            {
                RestaurantName = "TRUReligion Pancake and Steakhouse",
                FavoriteDish = "Cinnamon Roll",
                Address = "360 S State St Suite 158, Orem, UT 84058",
                RestaurantPhone = "8015223738",
                RestaurantLink = "https://trureligionpancakeandsteakhouse.com/"
            };

            Review r3 = new Review(3)
            {
                RestaurantName = "Block Restaurant",
                FavoriteDish = "Mediteranean Pork",
                Address = "3330 N University Ave, Provo, UT 84604",
                RestaurantPhone = "8019923471",
                RestaurantLink = "https://www.blockrestaurantgroup.com/"
            };

            Review r4 = new Review(4)
            {
                RestaurantName = "Communal",
                FavoriteDish = "Lamb Chops",
                Address = "102 N University Ave, Provo, UT 84601",
                RestaurantPhone = "8014238940",
                RestaurantLink = "https://www.communalrestaurant.com/"
            };

            Review r5 = new Review(5)
            {
                RestaurantName = "DP Cheesesteaks",
                FavoriteDish = "The Original",
                Address = "1774 N University Pkwy, Provo, UT 84604",
                RestaurantPhone = "8019238567",
                RestaurantLink = "https://www.dpcheesesteaks.com/"
            };
            // return an array of Reviews containing the top 5
            return new Review[] { r1, r2, r3, r4, r5 };
        }
    }
}
