namespace C_A4_WF
{
    /// <summary>
    /// Responsible for the main window GUI logic.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int maxNumOfRecipes = 200;
        private const int maxNumOfIngredients = 50;
        private const int minLengthOfRecipeName = 1;
        private const int maxLengthOfRecipeName = 40;
        private int changedRecipeIndex;
        private RecipeManager recipeManager;
        private Recipe currentRecipe;
        private FormRecipeDetails? frmRecipeDetails;
        private readonly string notValidInput = "Not valid input";

        /// <summary>
        /// Initializes the GUI
        /// Calls the load-method
        /// Creates necessary instances of other classes
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            MainForm_Load();

            currentRecipe = new(maxNumOfIngredients);

            this.recipeManager = new RecipeManager(maxNumOfRecipes);

            recipeListBox.SelectedIndexChanged += RecipeListBox_SelectedIndexChanged; //Subscribe to method (executes when recipeListBox index is changed)
        }

        /// <summary>
        /// Loads the necessary enum values to addCategoryComboBox
        /// </summary>
        private void MainForm_Load()
        {
            addCategoryComboBox.DataSource = Enum.GetValues(typeof(FoodCategory.Category));
        }

        /// <summary>
        /// If given name of recipe is within limits:
        /// Initiates new instance of FormRecipeDetails and displays that window.
        /// else: prompts user with error-messagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addIngrInstrButton_Click(object sender, EventArgs e)
        {

            if (addRecipeNameTextBox.Text.Length > minLengthOfRecipeName && addRecipeNameTextBox.Text.Length < maxLengthOfRecipeName)
            {
                frmRecipeDetails = new(currentRecipe, this, maxNumOfIngredients);

                frmRecipeDetails.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "The name of the recipe has to be between 0-40 characters long",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                addRecipeNameTextBox.Clear();
            }

        }

        /// <summary>
        /// If a name is set for the recipe:
        /// Adds name/category
        /// Adds current recipe to the array
        /// Updates the recipe list
        /// Creates a new current recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            if (addRecipeNameTextBox.Text != null && addRecipeNameTextBox.Text != string.Empty)
            {
                currentRecipe.Name = addRecipeNameTextBox.Text;

                currentRecipe.Category = (FoodCategory.Category)addCategoryComboBox.SelectedItem;

                recipeManager.AddRecipe(currentRecipe);

                DisplayOrUpdateRecipeList();

                addRecipeNameTextBox.Clear();

                addCategoryComboBox.SelectedIndex = 0;

                currentRecipe = new(maxNumOfIngredients);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "The recipe needs a name first",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgFileDialog = new OpenFileDialog()
            {
                Title = "Choose an image",
                Filter = "Image Files (*.jpeg;*.png)|*.jpeg;*.png"
            };

            if (imgFileDialog.ShowDialog() == DialogResult.OK)
            {
                recipeManager.AddImg(imgFileDialog.FileName, recipeListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Could not save image",
                    "Img Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears necessary fields, deselects the recipe list
        /// Creates a new current recipe
        /// Toggles addbuttons (so as to work).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clearInputButton_Click(object sender, EventArgs e)
        {
            addRecipeNameTextBox.Clear();

            shortRecipeRichTextBox.Clear();

            recipeListBox.SelectedIndex = -1;

            currentRecipe = new(maxNumOfIngredients);

            ToggleAddButtons(true);
        }

        /// <summary>
        /// Updates the recipe list.
        /// </summary>
        public void DisplayOrUpdateRecipeList()
        {
            recipeListBox.Items.Clear();

            Recipe[] recipes = recipeManager.GetRecipes();

            for (int i = 0; i < recipes.Length; i++)
            {
                string name = recipes[i].Name;
                string foodCategory = recipes[i].Category.ToString();
                string numOfIngredients = recipes[i].NumOfIngredients.ToString();

                string formattedListRecipe = string.Format("{0, -20} {1, 15} {2, 15}", name, foodCategory, numOfIngredients);

                recipeListBox.Items.Add(formattedListRecipe);
            }
        }

        /// <summary>
        /// When highlighted index of recipe list is changed:
        /// Updates the textbox with ingredients/descriptions
        /// Displays the recipe name, and chosen category.
        /// Toggles addbuttons (so as to not work)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeListBox.SelectedIndex != -1)
            {
                int index = recipeListBox.SelectedIndex;

                this.currentRecipe = recipeManager.GetRecipe(index);

                shortRecipeRichTextBox.Text = currentRecipe.IngredientsAsString + "\n\n" + currentRecipe.Description;

                addRecipeNameTextBox.Text = currentRecipe.Name;

                addCategoryComboBox.SelectedItem = currentRecipe.Category;

                ToggleAddButtons(false);
            }
        }

        /// <summary>
        /// Deletes a recipe from the list based on the selected index of recipe list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeListBox.SelectedIndex >= 0)
            {
                int indexToRemove = recipeListBox.SelectedIndex;

                recipeManager.DeleteRecipe(indexToRemove);

                DisplayOrUpdateRecipeList();

                clearInputButton_Click(sender, new EventArgs());
            }
        }

        /// <summary>
        /// Loads the data of the recipe corresponding to the selected index of recipe list to FormRecipeDetails
        /// else: displays error-message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (recipeListBox.SelectedIndex >= 0)
            {
                int indexToLoad = recipeListBox.SelectedIndex;

                changedRecipeIndex = indexToLoad;

                currentRecipe = recipeManager.GetRecipe(indexToLoad);

                if (currentRecipe != null)
                {
                    frmRecipeDetails = new(currentRecipe, this, maxNumOfIngredients);

                    frmRecipeDetails.LoadRecipe();

                    frmRecipeDetails.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "You need to add recipes first",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Toggles addbuttons (on = true, off = false)
        /// </summary>
        /// <param name="toogle"></param>
        private void ToggleAddButtons(bool toogle)
        {
            addIngrInstrButton.Enabled = toogle;
            addRecipeButton.Enabled = toogle;
        }

        /// <summary>
        /// Landing method from FormRecipeDetails if recipe has been changed.
        /// Saves the changes and resets changedRecipeIndex to "0"
        /// </summary>
        public void SaveChangedRecipe()
        {
            recipeManager.AddRecipeChanges(changedRecipeIndex, currentRecipe);
            changedRecipeIndex = 0;
        }
    }
}
