namespace C_A4_WF
{
    partial class FormRecipeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameAmountLabel = new Label();
            nameAmountTextBox = new TextBox();
            addNameAmountButton = new Button();
            editNameAmountButton = new Button();
            deleteNameAmountButton = new Button();
            ingredientsListBox = new ListBox();
            numOfIngredientsLabel = new Label();
            numOfIngredientsDisplayLabel = new Label();
            descriptionOrInstructionsLabel = new Label();
            descriptionOrInstructionsRichTextBox = new RichTextBox();
            OKRecipeDetailsButton = new Button();
            cancelRecipeDetailsButton = new Button();
            SuspendLayout();
            // 
            // nameAmountLabel
            // 
            nameAmountLabel.AutoSize = true;
            nameAmountLabel.Location = new Point(33, 31);
            nameAmountLabel.Name = "nameAmountLabel";
            nameAmountLabel.Size = new Size(107, 15);
            nameAmountLabel.TabIndex = 0;
            nameAmountLabel.Text = "Name and amount";
            // 
            // nameAmountTextBox
            // 
            nameAmountTextBox.Location = new Point(33, 49);
            nameAmountTextBox.Name = "nameAmountTextBox";
            nameAmountTextBox.Size = new Size(237, 23);
            nameAmountTextBox.TabIndex = 1;
            // 
            // addNameAmountButton
            // 
            addNameAmountButton.Location = new Point(33, 78);
            addNameAmountButton.Name = "addNameAmountButton";
            addNameAmountButton.Size = new Size(75, 23);
            addNameAmountButton.TabIndex = 2;
            addNameAmountButton.Text = "Add";
            addNameAmountButton.UseVisualStyleBackColor = true;
            addNameAmountButton.Click += addNameAmountButton_Click;
            // 
            // editNameAmountButton
            // 
            editNameAmountButton.Location = new Point(114, 78);
            editNameAmountButton.Name = "editNameAmountButton";
            editNameAmountButton.Size = new Size(75, 23);
            editNameAmountButton.TabIndex = 3;
            editNameAmountButton.Text = "Edit";
            editNameAmountButton.UseVisualStyleBackColor = true;
            editNameAmountButton.Click += editNameAmountButton_Click;
            // 
            // deleteNameAmountButton
            // 
            deleteNameAmountButton.Location = new Point(195, 78);
            deleteNameAmountButton.Name = "deleteNameAmountButton";
            deleteNameAmountButton.Size = new Size(75, 23);
            deleteNameAmountButton.TabIndex = 4;
            deleteNameAmountButton.Text = "Delete";
            deleteNameAmountButton.UseVisualStyleBackColor = true;
            deleteNameAmountButton.Click += deleteNameAmountButton_Click;
            // 
            // ingredientsListBox
            // 
            ingredientsListBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientsListBox.FormattingEnabled = true;
            ingredientsListBox.ItemHeight = 15;
            ingredientsListBox.Location = new Point(33, 114);
            ingredientsListBox.Name = "ingredientsListBox";
            ingredientsListBox.Size = new Size(237, 274);
            ingredientsListBox.TabIndex = 5;
            // 
            // numOfIngredientsLabel
            // 
            numOfIngredientsLabel.AutoSize = true;
            numOfIngredientsLabel.Location = new Point(33, 407);
            numOfIngredientsLabel.Name = "numOfIngredientsLabel";
            numOfIngredientsLabel.Size = new Size(127, 15);
            numOfIngredientsLabel.TabIndex = 6;
            numOfIngredientsLabel.Text = "Number of ingredients";
            // 
            // numOfIngredientsDisplayLabel
            // 
            numOfIngredientsDisplayLabel.AutoSize = true;
            numOfIngredientsDisplayLabel.Location = new Point(270, 407);
            numOfIngredientsDisplayLabel.Name = "numOfIngredientsDisplayLabel";
            numOfIngredientsDisplayLabel.Size = new Size(0, 15);
            numOfIngredientsDisplayLabel.TabIndex = 7;
            // 
            // descriptionOrInstructionsLabel
            // 
            descriptionOrInstructionsLabel.AutoSize = true;
            descriptionOrInstructionsLabel.Location = new Point(291, 52);
            descriptionOrInstructionsLabel.Name = "descriptionOrInstructionsLabel";
            descriptionOrInstructionsLabel.Size = new Size(188, 15);
            descriptionOrInstructionsLabel.TabIndex = 8;
            descriptionOrInstructionsLabel.Text = "Description / Cooking instructions";
            // 
            // descriptionOrInstructionsRichTextBox
            // 
            descriptionOrInstructionsRichTextBox.Location = new Point(291, 79);
            descriptionOrInstructionsRichTextBox.Name = "descriptionOrInstructionsRichTextBox";
            descriptionOrInstructionsRichTextBox.Size = new Size(257, 309);
            descriptionOrInstructionsRichTextBox.TabIndex = 9;
            descriptionOrInstructionsRichTextBox.Text = "";
            // 
            // OKRecipeDetailsButton
            // 
            OKRecipeDetailsButton.Location = new Point(392, 450);
            OKRecipeDetailsButton.Name = "OKRecipeDetailsButton";
            OKRecipeDetailsButton.Size = new Size(75, 23);
            OKRecipeDetailsButton.TabIndex = 10;
            OKRecipeDetailsButton.Text = "OK";
            OKRecipeDetailsButton.UseVisualStyleBackColor = true;
            OKRecipeDetailsButton.Click += OKRecipeDetailsButton_Click;
            // 
            // cancelRecipeDetailsButton
            // 
            cancelRecipeDetailsButton.Location = new Point(473, 450);
            cancelRecipeDetailsButton.Name = "cancelRecipeDetailsButton";
            cancelRecipeDetailsButton.Size = new Size(75, 23);
            cancelRecipeDetailsButton.TabIndex = 11;
            cancelRecipeDetailsButton.Text = "Cancel";
            cancelRecipeDetailsButton.UseVisualStyleBackColor = true;
            cancelRecipeDetailsButton.Click += cancelRecipeDetailsButton_Click;
            // 
            // FormRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(584, 494);
            Controls.Add(cancelRecipeDetailsButton);
            Controls.Add(OKRecipeDetailsButton);
            Controls.Add(descriptionOrInstructionsRichTextBox);
            Controls.Add(descriptionOrInstructionsLabel);
            Controls.Add(numOfIngredientsDisplayLabel);
            Controls.Add(numOfIngredientsLabel);
            Controls.Add(ingredientsListBox);
            Controls.Add(deleteNameAmountButton);
            Controls.Add(editNameAmountButton);
            Controls.Add(addNameAmountButton);
            Controls.Add(nameAmountTextBox);
            Controls.Add(nameAmountLabel);
            Name = "FormRecipeDetails";
            Text = "FormRecipeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameAmountLabel;
        private TextBox nameAmountTextBox;
        private Button addNameAmountButton;
        private Button editNameAmountButton;
        private Button deleteNameAmountButton;
        private ListBox ingredientsListBox;
        private Label numOfIngredientsLabel;
        private Label numOfIngredientsDisplayLabel;
        private Label descriptionOrInstructionsLabel;
        private RichTextBox descriptionOrInstructionsRichTextBox;
        private Button OKRecipeDetailsButton;
        private Button cancelRecipeDetailsButton;
    }
}