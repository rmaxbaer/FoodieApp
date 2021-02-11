using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieApp.Models
{
    public class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();
        public static IEnumerable<Suggestion> Suggestions => suggestions;
        public static void SubmitSuggestion(Suggestion newSuggestion)
        {
            suggestions.Add(newSuggestion);
        }
    }
}
