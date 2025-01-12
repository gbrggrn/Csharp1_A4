using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_A4_WF
{
    /// <summary>
    /// Responsible for the secondary window GUI logic.
    /// </summary>
    public partial class FormRecipeDetails : Form
    {
        private const int minNameAmountLength = 1;
        private const int maxNameAmountLength = 40;
        private readonly int maxNumOfIngredients;
        private readonly string notValidInput = "Not valid input";
        private int numOfIngredients;
        private bool trueIfChangingRecipe;
        private Recipe currentRecipe;
        private MainForm mainForm;

        private string[] ingredients;

        /// <summary>
        /// Initiates the necessary fields.
        /// </summary>
        /// <param name="currentRecipeIn">The current recipe being manipulated</param>
        /// <param name="mainFormIn">The main form</param>
        /// <param name="maxNumOfIngredientsIn">The maximum number of ingredients allowed in a recipe</param>
        public FormRecipeDetails(Recipe currentRecipeIn, MainForm mainFormIn, int maxNumOfIngredientsIn)
        {
            InitializeComponent();

            this.currentRecipe = currentRecipeIn;

            this.mainForm = mainFormIn;

            this.maxNumOfIngredients = maxNumOfIngredientsIn;

            numOfIngredients = 0;

            ingredients = new string[maxNumOfIngredients];

            this.trueIfChangingRecipe = false;
        }

        /// <summary>
        /// Clears the field and exits the form when "cancel" is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelRecipeDetailsButton_Click(object sender, EventArgs e)
        {
            nameAmountTextBox.Clear();
            ingredientsListBox.Items.Clear();
            descriptionOrInstructionsRichTextBox.Clear();

            this.Close();
        }

        /// <summary>
        /// If length is within limits, adds an ingredient to the ingredients list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNameAmountButton_Click(object sender, EventArgs e)
        {
            if (nameAmountTextBox.Text.Length > minNameAmountLength && nameAmountTextBox.Text.Length < maxNameAmountLength)
            {
                ingredientsListBox.Items.Add(nameAmountTextBox.Text);
                nameAmountTextBox.Clear();
                UpdateNumOfIngredients(1, true);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "The ingredient description has to be between 1-40 characters long",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                nameAmountTextBox.PlaceholderText = notValidInput;
            }
        }

        /// <summary>
        /// Lets the user edit the ingredient corresponding to the selected index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNameAmountButton_Click(object sender, EventArgs e)
        {
            if (ingredientsListBox.SelectedItems.ToString() != null)
            {
                nameAmountTextBox.Text = ingredientsListBox.GetItemText(ingredientsListBox.SelectedItem);

                ToggleEditControls(false); //disable all controls but "OK"

                editNameAmountButton.Click -= editNameAmountButton_Click; //Unsubscribe this event
                editNameAmountButton.Click += editNameAmountButton_SecondClick; //Subscribe edit...SecondClick
            }
        }

        /// <summary>
        /// Allows the user to save any changes made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNameAmountButton_SecondClick(object sender, EventArgs e)
        {
            int selectedIndex = ingredientsListBox.SelectedIndex;
            ingredientsListBox.Items[selectedIndex] = nameAmountTextBox.Text;

            ToggleEditControls(true); //enable all controls

            editNameAmountButton.Click -= editNameAmountButton_SecondClick; //Unsubscribe this event
            editNameAmountButton.Click += editNameAmountButton_Click; //Subscribe edit...Click
        }

        /// <summary>
        /// Allows the user to remove the ingredient corresponding to the selected index (item).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteNameAmountButton_Click(object sender, EventArgs e)
        {
            if (ingredientsListBox.SelectedItem != null)
            {
                ingredientsListBox.Items.Remove(ingredientsListBox.SelectedItem);
                UpdateNumOfIngredients(1, false);
            }
        }

        /// <summary>
        /// Saves the inputs made in this form to the current recipe, or a recipe loaded into the form to be changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKRecipeDetailsButton_Click(object sender, EventArgs e)
        {
            if (ingredientsListBox.Items != null && descriptionOrInstructionsRichTextBox.Text != null)
            {
                AddInputsToCurrentRecipe(); //add inputs from this form to currentRecipe

                ClearAll();

                mainForm.DisplayOrUpdateRecipeList(); //update recipe list in mainform

                if (trueIfChangingRecipe) //if a specific recipe is being changed
                {
                    mainForm.SaveChangedRecipe();

                    mainForm.clearInputButton_Click(sender, new EventArgs()); //set a new recipe in the mainform and deselect the recipe list
                }

                this.Close();
            }
        }

        /// <summary>
        /// Adds the ingredients list to the ingredients array.
        /// Saves description, ingredients array and number of ingredients to the current recipe.
        /// </summary>
        private void AddInputsToCurrentRecipe()
        {
            for (int i = 0; i < ingredientsListBox.Items.Count; i++)
            {
                ingredients[i] = ingredientsListBox.Items[i].ToString();
            }

            currentRecipe.Description = descriptionOrInstructionsRichTextBox.Text;

            currentRecipe.IngredientsArr = ingredients;

            currentRecipe.NumOfIngredients = numOfIngredients;
        }

        /// <summary>
        /// Loads the current recipe into this form if a recipe is being changed.
        /// Sets the boolean flag for trueIfChangingRecipe.
        /// </summary>
        public void LoadRecipe()
        {
            string[] tempIngredientsArr = currentRecipe.IngredientsArr;

            for (int i = 0; i < tempIngredientsArr.Length; i++)
            {
                ingredientsListBox.Items.Add(tempIngredientsArr[i].ToString());

                ingredients[i] = tempIngredientsArr[i];
            }

            numOfIngredients = currentRecipe.NumOfIngredients;

            numOfIngredientsDisplayLabel.Text = numOfIngredients.ToString();

            descriptionOrInstructionsRichTextBox.Text = currentRecipe.Description;

            trueIfChangingRecipe = true;
        }

        /// <summary>
        /// Toggles all buttons and changes the name of the "edit" button.
        /// </summary>
        /// <param name="toggle"></param>
        private void ToggleEditControls(bool toggle)
        {
            if (toggle)
            {
                nameAmountTextBox.Clear();
                ingredientsListBox.Enabled = true;
                addNameAmountButton.Enabled = true;
                deleteNameAmountButton.Enabled = true;
                OKRecipeDetailsButton.Enabled = true;
                cancelRecipeDetailsButton.Enabled = true;
                editNameAmountButton.Text = "Edit";
            }
            else
            {
                ingredientsListBox.Enabled = false;
                addNameAmountButton.Enabled = false;
                deleteNameAmountButton.Enabled = false;
                OKRecipeDetailsButton.Enabled = false;
                cancelRecipeDetailsButton.Enabled = false;
                editNameAmountButton.Text = "OK";
            }
        }

        /// <summary>
        /// Updates the number of ingredients-field and the label displaying it.
        /// </summary>
        /// <param name="interval">The interval to increment or decrement</param>
        /// <param name="addIfTrue">Boolean where true = ++ and false = --</param>
        public void UpdateNumOfIngredients(int interval, bool addIfTrue)
        {
            if (addIfTrue)
            {
                numOfIngredients++;
                numOfIngredientsDisplayLabel.Text = numOfIngredients.ToString();
            }
            else
            {
                numOfIngredients--;
                numOfIngredientsDisplayLabel.Text = numOfIngredients.ToString();
            }
        }

        /// <summary>
        /// Clears all fields.
        /// </summary>
        public void ClearAll()
        {
            ingredientsListBox.Items.Clear();

            descriptionOrInstructionsRichTextBox.Clear();

            nameAmountTextBox.Clear();
        }
    }
}
