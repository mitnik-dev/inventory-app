namespace InventoryApp.UserInterface
{
    partial class mainForm
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
            titleLabel = new Label();
            partsSearchButton = new Button();
            partsSearchTextBox = new TextBox();
            partsPanel = new Panel();
            partsLabel = new Label();
            partsDeleteButton = new Button();
            partsModifyButton = new Button();
            partsAddButton = new Button();
            partsDataGridView = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            productsLabel = new Label();
            productsDeleteButton = new Button();
            productsModifyButton = new Button();
            productsAddButton = new Button();
            productsDataGridView = new DataGridView();
            productsSearchButton = new Button();
            productsSearchTextBox = new TextBox();
            exitButton = new Button();
            partsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(283, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            partsSearchButton.BackColor = SystemColors.Control;
            partsSearchButton.Location = new Point(351, 29);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(75, 28);
            partsSearchButton.TabIndex = 0;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = false;
            partsSearchButton.Click += partsSearchButton_Click;
            // 
            // partsSearchTextBox
            // 
            partsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            partsSearchTextBox.Location = new Point(457, 29);
            partsSearchTextBox.Name = "partsSearchTextBox";
            partsSearchTextBox.Size = new Size(170, 27);
            partsSearchTextBox.TabIndex = 1;
            // 
            // partsPanel
            // 
            partsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            partsPanel.Controls.Add(partsLabel);
            partsPanel.Controls.Add(partsDeleteButton);
            partsPanel.Controls.Add(partsModifyButton);
            partsPanel.Controls.Add(partsAddButton);
            partsPanel.Controls.Add(partsDataGridView);
            partsPanel.Controls.Add(partsSearchButton);
            partsPanel.Controls.Add(partsSearchTextBox);
            partsPanel.Location = new Point(20, 84);
            partsPanel.Name = "partsPanel";
            partsPanel.Size = new Size(627, 319);
            partsPanel.TabIndex = 2;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsLabel.Location = new Point(0, 35);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(54, 28);
            partsLabel.TabIndex = 6;
            partsLabel.Text = "Parts";
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.BackColor = SystemColors.Control;
            partsDeleteButton.Location = new Point(533, 290);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(94, 29);
            partsDeleteButton.TabIndex = 5;
            partsDeleteButton.Text = "Delete";
            partsDeleteButton.UseVisualStyleBackColor = false;
            partsDeleteButton.Click += partsDeleteButton_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.BackColor = SystemColors.Control;
            partsModifyButton.Location = new Point(412, 290);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(94, 29);
            partsModifyButton.TabIndex = 4;
            partsModifyButton.Text = "Modify";
            partsModifyButton.UseVisualStyleBackColor = false;
            partsModifyButton.Click += partsModifyButton_Click;
            // 
            // partsAddButton
            // 
            partsAddButton.BackColor = SystemColors.Control;
            partsAddButton.Location = new Point(296, 290);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(94, 29);
            partsAddButton.TabIndex = 3;
            partsAddButton.Text = "Add";
            partsAddButton.UseVisualStyleBackColor = false;
            partsAddButton.Click += partsAddButton_Click;
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AllowUserToDeleteRows = false;
            partsDataGridView.AllowUserToResizeColumns = false;
            partsDataGridView.AllowUserToResizeRows = false;
            partsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            partsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGridView.Location = new Point(0, 76);
            partsDataGridView.MultiSelect = false;
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.ReadOnly = true;
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.RowHeadersWidth = 51;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.Size = new Size(627, 188);
            partsDataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(productsLabel);
            panel1.Controls.Add(productsDeleteButton);
            panel1.Controls.Add(productsModifyButton);
            panel1.Controls.Add(productsAddButton);
            panel1.Controls.Add(productsDataGridView);
            panel1.Controls.Add(productsSearchButton);
            panel1.Controls.Add(productsSearchTextBox);
            panel1.Location = new Point(689, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 319);
            panel1.TabIndex = 3;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsLabel.Location = new Point(0, 35);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(89, 28);
            productsLabel.TabIndex = 7;
            productsLabel.Text = "Products";
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.BackColor = SystemColors.Control;
            productsDeleteButton.Location = new Point(533, 290);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(94, 29);
            productsDeleteButton.TabIndex = 5;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = false;
            productsDeleteButton.Click += productsDeleteButton_Click;
            // 
            // productsModifyButton
            // 
            productsModifyButton.BackColor = SystemColors.Control;
            productsModifyButton.Location = new Point(412, 290);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(94, 29);
            productsModifyButton.TabIndex = 4;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = false;
            productsModifyButton.Click += productsModifyButton_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.BackColor = SystemColors.Control;
            productsAddButton.Location = new Point(296, 290);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(94, 29);
            productsAddButton.TabIndex = 3;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = false;
            productsAddButton.Click += productsAddButton_Click;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(0, 76);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(627, 188);
            productsDataGridView.TabIndex = 2;
            // 
            // productsSearchButton
            // 
            productsSearchButton.BackColor = SystemColors.Control;
            productsSearchButton.Location = new Point(350, 29);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(75, 28);
            productsSearchButton.TabIndex = 0;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = false;
            productsSearchButton.Click += productsSearchButton_Click;
            // 
            // productsSearchTextBox
            // 
            productsSearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            productsSearchTextBox.Location = new Point(457, 29);
            productsSearchTextBox.Name = "productsSearchTextBox";
            productsSearchTextBox.Size = new Size(170, 27);
            productsSearchTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.Control;
            exitButton.Location = new Point(1222, 435);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1353, 513);
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Controls.Add(partsPanel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            partsPanel.ResumeLayout(false);
            partsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button partsSearchButton;
        private TextBox partsSearchTextBox;
        private Panel partsPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView partsDataGridView;
        private Button partsDeleteButton;
        private Button partsModifyButton;
        private Button partsAddButton;
        private Panel panel1;
        private Button productsDeleteButton;
        private Button productsModifyButton;
        private Button productsAddButton;
        private DataGridView productsDataGridView;
        private Button productsSearchButton;
        private TextBox productsSearchTextBox;
        private Label partsLabel;
        private Label productsLabel;
        private Button exitButton;
    }
}
