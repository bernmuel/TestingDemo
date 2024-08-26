namespace WinFormUI
{
    partial class Dashboard
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
            calculateSection = new GroupBox();
            divideButton = new Button();
            multiplyButton = new Button();
            subtractButton = new Button();
            addButton = new Button();
            resultsLabel = new Label();
            resultsText = new TextBox();
            secondNumberValue = new NumericUpDown();
            firstNumberValue = new NumericUpDown();
            secondNumberLabel = new Label();
            firstNumberLabel = new Label();
            databaseSectionGroup = new GroupBox();
            addPersonButton = new Button();
            lastNameText = new TextBox();
            firstNameText = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            usersDropdown = new ComboBox();
            usersLabel = new Label();
            calculateSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondNumberValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstNumberValue).BeginInit();
            databaseSectionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // calculateSection
            // 
            calculateSection.Controls.Add(divideButton);
            calculateSection.Controls.Add(multiplyButton);
            calculateSection.Controls.Add(subtractButton);
            calculateSection.Controls.Add(addButton);
            calculateSection.Controls.Add(resultsLabel);
            calculateSection.Controls.Add(resultsText);
            calculateSection.Controls.Add(secondNumberValue);
            calculateSection.Controls.Add(firstNumberValue);
            calculateSection.Controls.Add(secondNumberLabel);
            calculateSection.Controls.Add(firstNumberLabel);
            calculateSection.Location = new Point(22, 24);
            calculateSection.Name = "calculateSection";
            calculateSection.Size = new Size(483, 389);
            calculateSection.TabIndex = 19;
            calculateSection.TabStop = false;
            calculateSection.Text = "Calculate Section";
            // 
            // divideButton
            // 
            divideButton.Location = new Point(156, 284);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(94, 29);
            divideButton.TabIndex = 27;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(156, 249);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(94, 29);
            multiplyButton.TabIndex = 26;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(156, 214);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(94, 29);
            subtractButton.TabIndex = 25;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(156, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 24;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(298, 196);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(55, 20);
            resultsLabel.TabIndex = 23;
            resultsLabel.Text = "Results";
            // 
            // resultsText
            // 
            resultsText.Location = new Point(304, 222);
            resultsText.Name = "resultsText";
            resultsText.Size = new Size(145, 27);
            resultsText.TabIndex = 22;
            // 
            // secondNumberValue
            // 
            secondNumberValue.Location = new Point(300, 114);
            secondNumberValue.Name = "secondNumberValue";
            secondNumberValue.Size = new Size(108, 27);
            secondNumberValue.TabIndex = 21;
            // 
            // firstNumberValue
            // 
            firstNumberValue.Location = new Point(300, 75);
            firstNumberValue.Name = "firstNumberValue";
            firstNumberValue.Size = new Size(108, 27);
            firstNumberValue.TabIndex = 20;
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Location = new Point(156, 121);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.Size = new Size(116, 20);
            secondNumberLabel.TabIndex = 19;
            secondNumberLabel.Text = "Second Number";
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Location = new Point(156, 82);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.Size = new Size(94, 20);
            firstNumberLabel.TabIndex = 18;
            firstNumberLabel.Text = "First Number";
            // 
            // databaseSectionGroup
            // 
            databaseSectionGroup.Controls.Add(addPersonButton);
            databaseSectionGroup.Controls.Add(lastNameText);
            databaseSectionGroup.Controls.Add(firstNameText);
            databaseSectionGroup.Controls.Add(lastNameLabel);
            databaseSectionGroup.Controls.Add(firstNameLabel);
            databaseSectionGroup.Controls.Add(usersDropdown);
            databaseSectionGroup.Controls.Add(usersLabel);
            databaseSectionGroup.Location = new Point(528, 29);
            databaseSectionGroup.Name = "databaseSectionGroup";
            databaseSectionGroup.Size = new Size(480, 384);
            databaseSectionGroup.TabIndex = 20;
            databaseSectionGroup.TabStop = false;
            databaseSectionGroup.Text = "Database Section";
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(147, 246);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Size = new Size(134, 29);
            addPersonButton.TabIndex = 25;
            addPersonButton.Text = "Add Person";
            addPersonButton.UseVisualStyleBackColor = true;
            addPersonButton.Click += addPersonButton_Click;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(187, 191);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(197, 27);
            lastNameText.TabIndex = 24;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(187, 154);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(197, 27);
            firstNameText.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(97, 197);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(97, 158);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name";
            // 
            // usersDropdown
            // 
            usersDropdown.FormattingEnabled = true;
            usersDropdown.Location = new Point(147, 109);
            usersDropdown.Name = "usersDropdown";
            usersDropdown.Size = new Size(237, 28);
            usersDropdown.TabIndex = 20;
            // 
            // usersLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.Location = new Point(97, 109);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(44, 20);
            usersLabel.TabIndex = 19;
            usersLabel.Text = "Users";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 529);
            Controls.Add(databaseSectionGroup);
            Controls.Add(calculateSection);
            Name = "Dashboard";
            Text = "Dashboard";
            calculateSection.ResumeLayout(false);
            calculateSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondNumberValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstNumberValue).EndInit();
            databaseSectionGroup.ResumeLayout(false);
            databaseSectionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox calculateSection;
        private Button divideButton;
        private Button multiplyButton;
        private Button subtractButton;
        private Button addButton;
        private Label resultsLabel;
        private TextBox resultsText;
        private NumericUpDown secondNumberValue;
        private NumericUpDown firstNumberValue;
        private Label secondNumberLabel;
        private Label firstNumberLabel;
        private GroupBox databaseSectionGroup;
        private Button addPersonButton;
        private TextBox lastNameText;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private ComboBox usersDropdown;
        private Label usersLabel;
    }
}
