namespace C_A4_WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addRecipeBox = new GroupBox();
            addIngrInstrButton = new Button();
            addCategoryComboBox = new ComboBox();
            addRecipeNameTextBox = new TextBox();
            categoryLabel = new Label();
            recipeNameLabel = new Label();
            addRecipeButton = new Button();
            recipeListBox = new ListBox();
            changeButton = new Button();
            deleteRecipeButton = new Button();
            clearInputButton = new Button();
            recipePictureBox = new PictureBox();
            addImageButton = new Button();
            shortRecipeRichTextBox = new RichTextBox();
            addRecipeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipePictureBox).BeginInit();
            SuspendLayout();
            // 
            // addRecipeBox
            // 
            addRecipeBox.Controls.Add(addIngrInstrButton);
            addRecipeBox.Controls.Add(addCategoryComboBox);
            addRecipeBox.Controls.Add(addRecipeNameTextBox);
            addRecipeBox.Controls.Add(categoryLabel);
            addRecipeBox.Controls.Add(recipeNameLabel);
            addRecipeBox.Location = new Point(39, 37);
            addRecipeBox.Name = "addRecipeBox";
            addRecipeBox.Size = new Size(324, 173);
            addRecipeBox.TabIndex = 0;
            addRecipeBox.TabStop = false;
            addRecipeBox.Text = "Add New Recipe";
            // 
            // addIngrInstrButton
            // 
            addIngrInstrButton.Location = new Point(28, 108);
            addIngrInstrButton.Name = "addIngrInstrButton";
            addIngrInstrButton.Size = new Size(252, 43);
            addIngrInstrButton.TabIndex = 4;
            addIngrInstrButton.Text = "Add Ingredients and Instructions";
            addIngrInstrButton.UseVisualStyleBackColor = true;
            addIngrInstrButton.Click += addIngrInstrButton_Click;
            // 
            // addCategoryComboBox
            // 
            addCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addCategoryComboBox.FormattingEnabled = true;
            addCategoryComboBox.Location = new Point(159, 70);
            addCategoryComboBox.Name = "addCategoryComboBox";
            addCategoryComboBox.Size = new Size(121, 23);
            addCategoryComboBox.TabIndex = 3;
            // 
            // addRecipeNameTextBox
            // 
            addRecipeNameTextBox.Location = new Point(109, 41);
            addRecipeNameTextBox.Name = "addRecipeNameTextBox";
            addRecipeNameTextBox.Size = new Size(171, 23);
            addRecipeNameTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(28, 73);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(55, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Location = new Point(28, 44);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(75, 15);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "Recipe name";
            // 
            // addRecipeButton
            // 
            addRecipeButton.Location = new Point(92, 237);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(200, 43);
            addRecipeButton.TabIndex = 5;
            addRecipeButton.Text = "Add Recipe";
            addRecipeButton.UseVisualStyleBackColor = true;
            addRecipeButton.Click += addRecipeButton_Click;
            // 
            // recipeListBox
            // 
            recipeListBox.BackColor = SystemColors.ControlLight;
            recipeListBox.FormattingEnabled = true;
            recipeListBox.ItemHeight = 15;
            recipeListBox.Location = new Point(39, 305);
            recipeListBox.Name = "recipeListBox";
            recipeListBox.Size = new Size(324, 244);
            recipeListBox.TabIndex = 6;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(39, 572);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(83, 43);
            changeButton.TabIndex = 7;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.Location = new Point(159, 572);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(83, 43);
            deleteRecipeButton.TabIndex = 8;
            deleteRecipeButton.Text = "Delete";
            deleteRecipeButton.UseVisualStyleBackColor = true;
            deleteRecipeButton.Click += deleteRecipeButton_Click;
            // 
            // clearInputButton
            // 
            clearInputButton.Location = new Point(280, 572);
            clearInputButton.Name = "clearInputButton";
            clearInputButton.Size = new Size(83, 43);
            clearInputButton.TabIndex = 9;
            clearInputButton.Text = "Clear Input";
            clearInputButton.UseVisualStyleBackColor = true;
            clearInputButton.Click += clearInputButton_Click;
            // 
            // recipePictureBox
            // 
            recipePictureBox.Location = new Point(391, 37);
            recipePictureBox.Name = "recipePictureBox";
            recipePictureBox.Size = new Size(247, 197);
            recipePictureBox.TabIndex = 10;
            recipePictureBox.TabStop = false;
            // 
            // addImageButton
            // 
            addImageButton.Location = new Point(413, 257);
            addImageButton.Name = "addImageButton";
            addImageButton.Size = new Size(200, 43);
            addImageButton.TabIndex = 11;
            addImageButton.Text = "Add Image";
            addImageButton.UseVisualStyleBackColor = true;
            // 
            // shortRecipeRichTextBox
            // 
            shortRecipeRichTextBox.BackColor = SystemColors.ControlLight;
            shortRecipeRichTextBox.Enabled = false;
            shortRecipeRichTextBox.ForeColor = Color.Black;
            shortRecipeRichTextBox.Location = new Point(391, 320);
            shortRecipeRichTextBox.Name = "shortRecipeRichTextBox";
            shortRecipeRichTextBox.Size = new Size(247, 229);
            shortRecipeRichTextBox.TabIndex = 12;
            shortRecipeRichTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(684, 661);
            Controls.Add(shortRecipeRichTextBox);
            Controls.Add(addImageButton);
            Controls.Add(recipePictureBox);
            Controls.Add(clearInputButton);
            Controls.Add(deleteRecipeButton);
            Controls.Add(changeButton);
            Controls.Add(recipeListBox);
            Controls.Add(addRecipeButton);
            Controls.Add(addRecipeBox);
            Name = "MainForm";
            Text = "Cookbook by Gustaf Berggren";
            addRecipeBox.ResumeLayout(false);
            addRecipeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addRecipeBox;
        private Button addIngrInstrButton;
        private ComboBox addCategoryComboBox;
        private TextBox addRecipeNameTextBox;
        private Label categoryLabel;
        private Label recipeNameLabel;
        private Button addRecipeButton;
        private ListBox recipeListBox;
        private Button changeButton;
        private Button deleteRecipeButton;
        private Button clearInputButton;
        private PictureBox recipePictureBox;
        private Button addImageButton;
        private RichTextBox shortRecipeRichTextBox;
    }
}
