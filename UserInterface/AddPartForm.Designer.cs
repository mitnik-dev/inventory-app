namespace InventoryApp.UserInterface
{
    partial class AddPartForm
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
            addPartLabel = new Label();
            inHouseRadio = new RadioButton();
            outsourcedRadio = new RadioButton();
            idLabel = new Label();
            nameLabel = new Label();
            inventoryLabel = new Label();
            priceCostLabel = new Label();
            maxLabel = new Label();
            minLabel = new Label();
            variableLabel = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            priceCostTextBox = new TextBox();
            variableTextBox = new TextBox();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPartLabel.Location = new Point(12, 20);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(77, 23);
            addPartLabel.TabIndex = 0;
            addPartLabel.Text = "Add Part";
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.Checked = true;
            inHouseRadio.Location = new Point(139, 20);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(90, 24);
            inHouseRadio.TabIndex = 1;
            inHouseRadio.TabStop = true;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            inHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.Location = new Point(247, 20);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(106, 24);
            outsourcedRadio.TabIndex = 2;
            outsourcedRadio.TabStop = true;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            outsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // idLabel
            // 
            idLabel.Location = new Point(53, 83);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(135, 20);
            idLabel.TabIndex = 3;
            idLabel.Text = "ID";
            idLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(53, 132);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(135, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inventoryLabel
            // 
            inventoryLabel.Location = new Point(53, 181);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(135, 20);
            inventoryLabel.TabIndex = 5;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceCostLabel
            // 
            priceCostLabel.Location = new Point(53, 230);
            priceCostLabel.Name = "priceCostLabel";
            priceCostLabel.Size = new Size(135, 20);
            priceCostLabel.TabIndex = 6;
            priceCostLabel.Text = "Price / Cost";
            priceCostLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maxLabel
            // 
            maxLabel.Location = new Point(53, 279);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(135, 20);
            maxLabel.TabIndex = 7;
            maxLabel.Text = "Max";
            maxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(319, 281);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 8;
            minLabel.Text = "Min";
            // 
            // variableLabel
            // 
            variableLabel.Location = new Point(53, 325);
            variableLabel.Name = "variableLabel";
            variableLabel.Size = new Size(135, 20);
            variableLabel.TabIndex = 9;
            variableLabel.Text = "Machine ID";
            variableLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(228, 81);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(228, 130);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 11;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            inventoryTextBox.Location = new Point(228, 179);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(125, 27);
            inventoryTextBox.TabIndex = 12;
            // 
            // priceCostTextBox
            // 
            priceCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceCostTextBox.Location = new Point(228, 228);
            priceCostTextBox.Name = "priceCostTextBox";
            priceCostTextBox.Size = new Size(125, 27);
            priceCostTextBox.TabIndex = 13;
            // 
            // variableTextBox
            // 
            variableTextBox.BorderStyle = BorderStyle.FixedSingle;
            variableTextBox.Location = new Point(228, 323);
            variableTextBox.Name = "variableTextBox";
            variableTextBox.Size = new Size(125, 27);
            variableTextBox.TabIndex = 14;
            // 
            // maxTextBox
            // 
            maxTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxTextBox.Location = new Point(228, 279);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(68, 27);
            maxTextBox.TabIndex = 15;
            // 
            // minTextBox
            // 
            minTextBox.BorderStyle = BorderStyle.FixedSingle;
            minTextBox.Location = new Point(375, 277);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(68, 27);
            minTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Control;
            saveButton.Location = new Point(319, 381);
            saveButton.Margin = new Padding(0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.Location = new Point(430, 381);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(variableTextBox);
            Controls.Add(priceCostTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(variableLabel);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(priceCostLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(outsourcedRadio);
            Controls.Add(inHouseRadio);
            Controls.Add(addPartLabel);
            Name = "AddPartForm";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartLabel;
        private RadioButton inHouseRadio;
        private RadioButton outsourcedRadio;
        private Label idLabel;
        private Label nameLabel;
        private Label inventoryLabel;
        private Label priceCostLabel;
        private Label maxLabel;
        private Label minLabel;
        private Label variableLabel;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox inventoryTextBox;
        private TextBox priceCostTextBox;
        private TextBox variableTextBox;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}