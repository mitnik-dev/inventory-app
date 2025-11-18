namespace InventoryApp.UserInterface
{
    partial class ModifyProductForm
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
            partsAssociatedLabel = new Label();
            candidatePartsLabel = new Label();
            modifyProductLabel = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            productsDeleteButton = new Button();
            productsAddButton = new Button();
            partsAssociatedDataGridView = new DataGridView();
            candidatePartsDataGridView = new DataGridView();
            productsSearchButton = new Button();
            productsSearchTextBox = new TextBox();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            priceCostTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            minLabel = new Label();
            maxLabel = new Label();
            priceCostLabel = new Label();
            inventoryLabel = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)partsAssociatedDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // partsAssociatedLabel
            // 
            partsAssociatedLabel.AutoSize = true;
            partsAssociatedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            partsAssociatedLabel.Location = new Point(540, 335);
            partsAssociatedLabel.Name = "partsAssociatedLabel";
            partsAssociatedLabel.Size = new Size(238, 20);
            partsAssociatedLabel.TabIndex = 88;
            partsAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // candidatePartsLabel
            // 
            candidatePartsLabel.AutoSize = true;
            candidatePartsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            candidatePartsLabel.Location = new Point(540, 58);
            candidatePartsLabel.Name = "candidatePartsLabel";
            candidatePartsLabel.Size = new Size(136, 20);
            candidatePartsLabel.TabIndex = 87;
            candidatePartsLabel.Text = "All candidate Parts";
            // 
            // modifyProductLabel
            // 
            modifyProductLabel.AutoSize = true;
            modifyProductLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyProductLabel.Location = new Point(62, 40);
            modifyProductLabel.Name = "modifyProductLabel";
            modifyProductLabel.Size = new Size(130, 23);
            modifyProductLabel.TabIndex = 86;
            modifyProductLabel.Text = "Modify Product";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.Location = new Point(994, 626);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 85;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Control;
            saveButton.Location = new Point(883, 626);
            saveButton.Margin = new Padding(0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 84;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.BackColor = SystemColors.Control;
            productsDeleteButton.Location = new Point(998, 571);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(94, 29);
            productsDeleteButton.TabIndex = 83;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = false;
            productsDeleteButton.Click += productsDeleteButton_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.BackColor = SystemColors.Control;
            productsAddButton.Location = new Point(998, 294);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(94, 29);
            productsAddButton.TabIndex = 82;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = false;
            productsAddButton.Click += productsAddButton_Click;
            // 
            // partsAssociatedDataGridView
            // 
            partsAssociatedDataGridView.AllowUserToAddRows = false;
            partsAssociatedDataGridView.AllowUserToDeleteRows = false;
            partsAssociatedDataGridView.AllowUserToResizeColumns = false;
            partsAssociatedDataGridView.AllowUserToResizeRows = false;
            partsAssociatedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsAssociatedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsAssociatedDataGridView.Location = new Point(540, 367);
            partsAssociatedDataGridView.MultiSelect = false;
            partsAssociatedDataGridView.Name = "partsAssociatedDataGridView";
            partsAssociatedDataGridView.ReadOnly = true;
            partsAssociatedDataGridView.RowHeadersVisible = false;
            partsAssociatedDataGridView.RowHeadersWidth = 51;
            partsAssociatedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsAssociatedDataGridView.Size = new Size(552, 188);
            partsAssociatedDataGridView.TabIndex = 81;
            // 
            // candidatePartsDataGridView
            // 
            candidatePartsDataGridView.AllowUserToAddRows = false;
            candidatePartsDataGridView.AllowUserToDeleteRows = false;
            candidatePartsDataGridView.AllowUserToResizeColumns = false;
            candidatePartsDataGridView.AllowUserToResizeRows = false;
            candidatePartsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            candidatePartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidatePartsDataGridView.Location = new Point(540, 91);
            candidatePartsDataGridView.MultiSelect = false;
            candidatePartsDataGridView.Name = "candidatePartsDataGridView";
            candidatePartsDataGridView.ReadOnly = true;
            candidatePartsDataGridView.RowHeadersVisible = false;
            candidatePartsDataGridView.RowHeadersWidth = 51;
            candidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatePartsDataGridView.Size = new Size(552, 188);
            candidatePartsDataGridView.TabIndex = 80;
            // 
            // productsSearchButton
            // 
            productsSearchButton.BackColor = SystemColors.Control;
            productsSearchButton.Location = new Point(793, 40);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(75, 28);
            productsSearchButton.TabIndex = 78;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = false;
            productsSearchButton.Click += productsSearchButton_Click;
            // 
            // productsSearchTextBox
            // 
            productsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            productsSearchTextBox.Location = new Point(883, 40);
            productsSearchTextBox.Name = "productsSearchTextBox";
            productsSearchTextBox.Size = new Size(209, 27);
            productsSearchTextBox.TabIndex = 79;
            // 
            // minTextBox
            // 
            minTextBox.BorderStyle = BorderStyle.FixedSingle;
            minTextBox.Location = new Point(357, 364);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(68, 27);
            minTextBox.TabIndex = 77;
            // 
            // maxTextBox
            // 
            maxTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxTextBox.Location = new Point(187, 364);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(68, 27);
            maxTextBox.TabIndex = 76;
            // 
            // priceCostTextBox
            // 
            priceCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceCostTextBox.Location = new Point(237, 315);
            priceCostTextBox.Name = "priceCostTextBox";
            priceCostTextBox.Size = new Size(125, 27);
            priceCostTextBox.TabIndex = 75;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            inventoryTextBox.Location = new Point(237, 266);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(125, 27);
            inventoryTextBox.TabIndex = 74;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(237, 217);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 73;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(237, 168);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 72;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(286, 366);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 71;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.Location = new Point(109, 366);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(88, 20);
            maxLabel.TabIndex = 70;
            maxLabel.Text = "Max";
            maxLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceCostLabel
            // 
            priceCostLabel.Location = new Point(109, 317);
            priceCostLabel.Name = "priceCostLabel";
            priceCostLabel.Size = new Size(88, 20);
            priceCostLabel.TabIndex = 69;
            priceCostLabel.Text = "Price";
            priceCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryLabel
            // 
            inventoryLabel.Location = new Point(109, 268);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(88, 20);
            inventoryLabel.TabIndex = 68;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(109, 219);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 20);
            nameLabel.TabIndex = 67;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            idLabel.Location = new Point(109, 170);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(88, 20);
            idLabel.TabIndex = 66;
            idLabel.Text = "ID";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 694);
            Controls.Add(partsAssociatedLabel);
            Controls.Add(candidatePartsLabel);
            Controls.Add(modifyProductLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(productsDeleteButton);
            Controls.Add(productsAddButton);
            Controls.Add(partsAssociatedDataGridView);
            Controls.Add(candidatePartsDataGridView);
            Controls.Add(productsSearchButton);
            Controls.Add(productsSearchTextBox);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceCostTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(priceCostLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)partsAssociatedDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label partsAssociatedLabel;
        private Label candidatePartsLabel;
        private Label modifyProductLabel;
        private Button cancelButton;
        private Button saveButton;
        private Button productsDeleteButton;
        private Button productsAddButton;
        private DataGridView partsAssociatedDataGridView;
        private DataGridView candidatePartsDataGridView;
        private Button productsSearchButton;
        private TextBox productsSearchTextBox;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private TextBox priceCostTextBox;
        private TextBox inventoryTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label minLabel;
        private Label maxLabel;
        private Label priceCostLabel;
        private Label inventoryLabel;
        private Label nameLabel;
        private Label idLabel;
    }
}