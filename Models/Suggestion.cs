using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieApp.Models
{
    public class Suggestion
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; }
        [Required]
        //only allow phone numbers in the format xxx-xxx-xxxx
        [RegularExpression("^\\(?[0-9]{3}\\)?-[0-9]{3}-[0-9]{4}$", ErrorMessage = "The Phone number must be in the format xxx-xxx-xxxx")]
        public string RestaurantPhone { get; set; }
    }
}
