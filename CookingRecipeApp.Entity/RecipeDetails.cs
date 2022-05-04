using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CookingRecipeApp.Entity
{
    class RecipeDetails
    {
        public int recipe_id { get; set; }

        public string recipe_name { get; set; }

        public string recipe_description { get; set; }

        public string recipe_ratings { get; set; }
    }
}
