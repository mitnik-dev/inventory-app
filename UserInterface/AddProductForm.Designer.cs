namespace InventoryApp.UserInterface
{
    partial class AddProductForm
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
            productsSearchButton = new Button();
            productsSearchTextBox = new TextBox();
            candidatePartsDataGridView = new DataGridView();
            partsAssociatedDataGridView = new DataGridView();
            productsDeleteButton = new Button();
            productsAddButton = new Button();
            cancelButton = new Button();
            saveButton = new Button();
            addProductLabel = new Label();
            candidatePartsLabel = new Label();
            partsAssociatedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partsAssociatedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // minTextBox
            // 
            minTextBox.BorderStyle = BorderStyle.FixedSingle;
            minTextBox.Location = new Point(337, 366);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(68, 27);
            minTextBox.TabIndex = 54;
            // 
            // maxTextBox
            // 
            maxTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxTextBox.Location = new Point(167, 366);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(68, 27);
            maxTextBox.TabIndex = 53;
            // 
            // priceCostTextBox
            // 
            priceCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceCostTextBox.Location = new Point(217, 317);
            priceCostTextBox.Name = "priceCostTextBox";
            priceCostTextBox.Size = new Size(125, 27);
            priceCostTextBox.TabIndex = 51;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            inventoryTextBox.Location = new Point(217, 268);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(125, 27);
            inventoryTextBox.TabIndex = 50;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(217, 219);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 49;
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(217, 170);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 48;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(266, 368);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 46;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.Location = new Point(89, 368);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(88, 20);
            maxLabel.TabIndex = 45;
            maxLabel.Text = "Max";
            maxLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // priceCostLabel
            // 
            priceCostLabel.Location = new Point(89, 319);
            priceCostLabel.Name = "priceCostLabel";
            priceCostLabel.Size = new Size(88, 20);
            priceCostLabel.TabIndex = 44;
            priceCostLabel.Text = "Price";
            priceCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inventoryLabel
            // 
            inventoryLabel.Location = new Point(89, 270);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(88, 20);
            inventoryLabel.TabIndex = 43;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(89, 221);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 20);
            nameLabel.TabIndex = 42;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            idLabel.Location = new Point(89, 172);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(88, 20);
            idLabel.TabIndex = 41;
            idLabel.Text = "ID";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productsSearchButton
            // 
            productsSearchButton.BackColor = SystemColors.Control;
            productsSearchButton.Location = new Point(773, 42);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(75, 28);
            productsSearchButton.TabIndex = 55;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = false;
            productsSearchButton.Click += productsSearchButton_Click;
            // 
            // productsSearchTextBox
            // 
            productsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            productsSearchTextBox.Location = new Point(863, 42);
            productsSearchTextBox.Name = "productsSearchTextBox";
            productsSearchTextBox.Size = new Size(209, 27);
            productsSearchTextBox.TabIndex = 56;
            // 
            // candidatePartsDataGridView
            // 
            candidatePartsDataGridView.AllowUserToAddRows = false;
            candidatePartsDataGridView.AllowUserToDeleteRows = false;
            candidatePartsDataGridView.AllowUserToResizeColumns = false;
            candidatePartsDataGridView.AllowUserToResizeRows = false;
            candidatePartsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            candidatePartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidatePartsDataGridView.Location = new Point(520, 93);
            candidatePartsDataGridView.MultiSelect = false;
            candidatePartsDataGridView.Name = "candidatePartsDataGridView";
            candidatePartsDataGridView.ReadOnly = true;
            candidatePartsDataGridView.RowHeadersVisible = false;
            candidatePartsDataGridView.RowHeadersWidth = 51;
            candidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatePartsDataGridView.Size = new Size(552, 188);
            candidatePartsDataGridView.TabIndex = 57;
            // 
            // partsAssociatedDataGridView
            // 
            partsAssociatedDataGridView.AllowUserToAddRows = false;
            partsAssociatedDataGridView.AllowUserToDeleteRows = false;
            partsAssociatedDataGridView.AllowUserToResizeColumns = false;
            partsAssociatedDataGridView.AllowUserToResizeRows = false;
            partsAssociatedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsAssociatedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsAssociatedDataGridView.Location = new Point(520, 369);
            partsAssociatedDataGridView.MultiSelect = false;
            partsAssociatedDataGridView.Name = "partsAssociatedDataGridView";
            partsAssociatedDataGridView.ReadOnly = true;
            partsAssociatedDataGridView.RowHeadersVisible = false;
            partsAssociatedDataGridView.RowHeadersWidth = 51;
            partsAssociatedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsAssociatedDataGridView.Size = new Size(552, 188);
            partsAssociatedDataGridView.TabIndex = 58;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.BackColor = SystemColors.Control;
            productsDeleteButton.Location = new Point(978, 573);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(94, 29);
            productsDeleteButton.TabIndex = 60;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = false;
            productsDeleteButton.Click += productsDeleteButton_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.BackColor = SystemColors.Control;
            productsAddButton.Location = new Point(978, 296);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(94, 29);
            productsAddButton.TabIndex = 59;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = false;
            productsAddButton.Click += productsAddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.Location = new Point(974, 628);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 62;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Control;
            saveButton.Location = new Point(863, 628);
            saveButton.Margin = new Padding(0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 61;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductLabel.Location = new Point(42, 42);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(106, 23);
            addProductLabel.TabIndex = 63;
            addProductLabel.Text = "Add Product";
            // 
            // candidatePartsLabel
            // 
            candidatePartsLabel.AutoSize = true;
            candidatePartsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            candidatePartsLabel.Location = new Point(520, 60);
            candidatePartsLabel.Name = "candidatePartsLabel";
            candidatePartsLabel.Size = new Size(136, 20);
            candidatePartsLabel.TabIndex = 64;
            candidatePartsLabel.Text = "All candidate Parts";
            // 
            // partsAssociatedLabel
            // 
            partsAssociatedLabel.AutoSize = true;
            partsAssociatedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            partsAssociatedLabel.Location = new Point(520, 337);
            partsAssociatedLabel.Name = "partsAssociatedLabel";
            partsAssociatedLabel.Size = new Size(238, 20);
            partsAssociatedLabel.TabIndex = 65;
            partsAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 694);
            Controls.Add(partsAssociatedLabel);
            Controls.Add(candidatePartsLabel);
            Controls.Add(addProductLabel);
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
            Name = "AddProductForm";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)partsAssociatedDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button productsSearchButton;
        private TextBox productsSearchTextBox;
        private DataGridView candidatePartsDataGridView;
        private DataGridView partsAssociatedDataGridView;
        private Button productsDeleteButton;
        private Button productsAddButton;
        private Button cancelButton;
        private Button saveButton;
        private Label addProductLabel;
        private Label candidatePartsLabel;
        private Label partsAssociatedLabel;
    }
}