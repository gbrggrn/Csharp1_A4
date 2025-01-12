using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A4_WF
{
    /// <summary>
    /// Responsible for manipulating the array of recipe-objects.
    /// </summary>
    internal class RecipeManager
    {
        private readonly int maxNumOfRecipes;
        private int recipeCount;
        private Recipe[] recipes;

        /// <summary>
        /// Initializes the fields.
        /// </summary>
        /// <param name="maxNumOfRecipes">The maximum number of recipes allowed</param>
        public RecipeManager(int maxNumOfRecipes)
        {
            this.maxNumOfRecipes = maxNumOfRecipes;

            recipes = new Recipe[maxNumOfRecipes];

            recipeCount = 0;
        }

        /// <summary>
        /// If there is space in the array - adds the current recipe.
        /// </summary>
        /// <param name="currentRecipe">The current recipe being manipulated</param>
        public void AddRecipe(Recipe currentRecipe)
        {
            if (recipeCount < recipes.Length)
            {
                recipes[recipeCount++] = currentRecipe;
            }
        }

        /// <summary>
        /// Changes a changed current recipe to its original index in the array.
        /// </summary>
        /// <param name="saveToIndex">The index of the changed recipe</param>
        /// <param name="currentRecipe">The current recipe</param>
        public void AddRecipeChanges(int saveToIndex, Recipe currentRecipe)
        {
            recipes[saveToIndex] = currentRecipe;
        }

        /// <summary>
        /// Returns the objects of the currently occupied spaces of the array, as an array.
        /// </summary>
        /// <returns>The objects of the occupied spaces of the array, as an array</returns>
        public Recipe[] GetRecipes()
        {
            return recipes.Take(recipeCount).ToArray();
        }

        /// <summary>
        /// Returns a specific recipe object from the array.
        /// </summary>
        /// <param name="index">The index of the recipe</param>
        /// <returns>The recipe object at index</returns>
        public Recipe GetRecipe(int index)
        {
            return recipes[index];
        }

        /// <summary>
        /// Copies every object, except at index, to a new array.
        /// Saves the copied array to the 
        /// </summary>
        /// <param name="index"></param>
        public void DeleteRecipe(int index)
        {
            int startIndex = 0;
            int endIndex = recipeCount;

            Recipe[] newRecipesArray = new Recipe[maxNumOfRecipes];

            Array.Copy(recipes, startIndex, newRecipesArray, startIndex, index); //copies array up to, but not including index.
            Array.Copy(recipes, index + 1, newRecipesArray, index, recipeCount - index - 1); //copies array from index+1 until end of array.

            recipes = newRecipesArray;

            recipeCount--;
        }
    }
}
