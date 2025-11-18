namespace InventoryApp.UserInterface
{
    partial class ModifyPartForm
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
            cancelButton = new Button();
            saveButton = new Button();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            variableTextBox = new TextBox();
            priceCostTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            variableLabel = new Label();
            minLabel = new Label();
            maxLabel = new Label();
            priceCostLabel = new Label();
            inventoryLabel = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            outsourcedRadio = new RadioButton();
            inHouseRadio = new RadioButton();
            modifyPartLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.Location = new Point(441, 391);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Control;
            saveButton.Location = new Point(330, 391);
            saveButton.Margin = new Padding(0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 36;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // minTextBox
            // 
            minTextBox.BorderStyle = BorderStyle.FixedSingle;
            minTextBox.Location = new Point(386, 287);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(68, 27);
            minTextBox.TabIndex = 35;
            // 
            // maxTextBox
            // 
            maxTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxTextBox.Location = new Point(239, 289);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(68, 27);
            maxTextBox.TabIndex = 34;
            // 
            // variableTextBox
            // 
            variableTextBox.BorderStyle = BorderStyle.FixedSingle;
            variableTextBox.Location = new Point(239, 333);
            variableTextBox.Name = "variableTextBox";
            variableTextBox.Size = new Size(125, 27);
            variableTextBox.TabIndex = 33;
            // 
            // priceCostTextBox
            // 
            priceCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceCostTextBox.Location = new Point(239, 238);
            priceCostTextBox.Name = "priceCostTextBox";
            priceCostTextBox.Size = new Size(125, 27);
            priceCostTextBox.TabIndex = 32;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            inventoryTextBox.Location = new Point(239, 189);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(125, 27);
            inventoryTextBox.TabIndex = 31;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(239, 140);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 30;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(239, 91);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 29;
            // 
            // variableLabel
            // 
            variableLabel.Location = new Point(64, 335);
            variableLabel.Name = "variableLabel";
            variableLabel.Size = new Size(135, 20);
            variableLabel.TabIndex = 28;
            variableLabel.Text = "Machine ID";
            variableLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(330, 291);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 27;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.Location = new Point(64, 289);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(135, 20);
            maxLabel.TabIndex = 26;
            maxLabel.Text = "Max";
            maxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceCostLabel
            // 
            priceCostLabel.Location = new Point(64, 240);
            priceCostLabel.Name = "priceCostLabel";
            priceCostLabel.Size = new Size(135, 20);
            priceCostLabel.TabIndex = 25;
            priceCostLabel.Text = "Price / Cost";
            priceCostLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inventoryLabel
            // 
            inventoryLabel.Location = new Point(64, 191);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(135, 20);
            inventoryLabel.TabIndex = 24;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(64, 142);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(135, 20);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            idLabel.Location = new Point(64, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(135, 20);
            idLabel.TabIndex = 22;
            idLabel.Text = "ID";
            idLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.Location = new Point(258, 30);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(106, 24);
            outsourcedRadio.TabIndex = 21;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.Checked = true;
            inHouseRadio.Location = new Point(150, 30);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(90, 24);
            inHouseRadio.TabIndex = 20;
            inHouseRadio.TabStop = true;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            // 
            // modifyPartLabel
            // 
            modifyPartLabel.AutoSize = true;
            modifyPartLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyPartLabel.Location = new Point(23, 30);
            modifyPartLabel.Name = "modifyPartLabel";
            modifyPartLabel.Size = new Size(101, 23);
            modifyPartLabel.TabIndex = 19;
            modifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPartForm
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
            Controls.Add(modifyPartLabel);
            Name = "ModifyPartForm";
            Text = "ModifyPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private TextBox variableTextBox;
        private TextBox priceCostTextBox;
        private TextBox inventoryTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label variableLabel;
        private Label minLabel;
        private Label maxLabel;
        private Label priceCostLabel;
        private Label inventoryLabel;
        private Label nameLabel;
        private Label idLabel;
        private RadioButton outsourcedRadio;
        private RadioButton inHouseRadio;
        private Label modifyPartLabel;
    }
}