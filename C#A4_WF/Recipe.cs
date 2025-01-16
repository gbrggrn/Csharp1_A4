using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A4_WF
{
    /// <summary>
    /// Provides the structure for how recipe-objects store data.
    /// </summary>
    public class Recipe
    {
        private FoodCategory.Category category;
        private string name;
        private string description;
        private string[] ingredientsArr;
        private int numOfIngredients;
        private string imgFileName;
        //private string ingredientsAsString;

        public Recipe(int maxNumOfIngredients)
        {
            this.category = FoodCategory.Category.Other;
            this.ingredientsArr = new string[maxNumOfIngredients];
            this.name = string.Empty;
            this.description = string.Empty;
            this.imgFileName = string.Empty;
            //this.ingredientsAsString = string.Empty;
        }

        /// <summary>
        /// Properties for Category. Has default value - does not need validation.
        /// </summary>
        public FoodCategory.Category Category
        {
            get { return this.category; }
            set
        {
                this.category = value;
            }
        }

        /// <summary>
        /// Properties for Name. Validation logic in mainForm.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
        
        /// <summary>
        /// Properties for Description. Can be empty - does not need validation.
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set
            {
               this.description = value;
            }
        }

        /// <summary>
        /// Properties for ingredientsArr. Can be empty and is already initialized - does not need validation.
        /// </summary>
        public string[] IngredientsArr
        {
            get { return this.ingredientsArr.Take(numOfIngredients).ToArray(); }
            set
            {
                this.ingredientsArr = value;
            }
        }

        /// <summary>
        /// Properties for numOfIngredients. Can be "0" and is already initialized - does not need validation.
        /// </summary>
        public int NumOfIngredients
        {
            get { return this.numOfIngredients; }
            set
            {
                this.numOfIngredients = value;
            }
        }

        public string ImgFileName
        {
            get { return this.imgFileName; }
            set
            {
                this.imgFileName = value;
            }
        }

        /// <summary>
        /// Returns the occopied spaces of the ingredientsArray as a string.
        /// </summary>
        public string IngredientsAsString
        {
            get { return string.Join(", ", ingredientsArr.Take(numOfIngredients)); }
        }
    }
}
