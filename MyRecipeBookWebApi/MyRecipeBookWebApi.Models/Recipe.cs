using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBookWebApi.Models
{
    [DataContract]
    public class Recipe
    {
        private ICollection<Ingredient> ingredients;

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "deatails")]
        public string Details { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "ingredients")]
        public ICollection<Ingredient> Ingredients 
        { 
            get
            {
                return this.ingredients;
            }

            set
            {
                this.ingredients = value;
            }
        }

        public Recipe() 
        {
            this.ingredients = new HashSet<Ingredient>();
        }

    }
}
