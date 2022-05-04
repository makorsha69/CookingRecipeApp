using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CookingRecipeApp.Entity
{
    public class UserDetails
    {
        [Key] //Creating Primary Key Column
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Creating Identity Column
        public int user_id { get; set; }

        public string user_name { get; set; }

        public string password { get; set; }

        public string role { get; set; }

        public string email_id { get; set; }
    }
}
