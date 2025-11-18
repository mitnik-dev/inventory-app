using InventoryApp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.UserInterface
{
    public partial class mainForm : Form
    {
        private readonly BindingSource _partsInventory = new BindingSource();
        private readonly BindingSource _productsInventory = new BindingSource();
        public mainForm()
        {
            InitializeComponent();

            partsDataGridView.AutoGenerateColumns = false;
            partsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Part ID", DataPropertyName = "PartID" });
            AddColumns(partsDataGridView);

            productsDataGridView.AutoGenerateColumns = false;
            productsDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Product ID", DataPropertyName = "ProductID" });
            AddColumns(productsDataGridView);

            _partsInventory.DataSource = Inventory.AllParts;
            partsDataGridView.DataSource = _partsInventory;


            _productsInventory.DataSource = Inventory.Products;
            productsDataGridView.DataSource = _productsInventory;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void AddColumns(DataGridView grid)
        {
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Inventory", DataPropertyName = "InStock" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price", DefaultCellStyle = { Format = "C2" } });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min", DataPropertyName = "Min" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max", DataPropertyName = "Max" });
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)partsDataGridView.CurrentRow.DataBoundItem;

            if (part != null)
            {

                List<String> associatedProducts = new();

                foreach (Product product in Inventory.Products)
                {
                    foreach (Part item in product.AssociatedParts)
                    {
                        if (item.PartID == part.PartID)
                        {
                            associatedProducts.Add(product.Name);
                        }
                    }
                }

                if (associatedProducts.Count > 0)
                {
                    MessageBox.Show("The part you are trying to delete is associated with the following products" +
                        $"{string.Join(", ", associatedProducts)}", "Delete", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult confirm = MessageBox.Show($"Delete '{part.Name}'", "Delete", MessageBoxButtons.OKCancel);

                    if (confirm == DialogResult.OK)
                    {

                        Inventory.DeletePart(part);
                    }
                }
            }
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;

            if (product != null)
            {
                DialogResult confirm = MessageBox.Show($"Delete '{product.Name}'?", "Delete", MessageBoxButtons.OKCancel);

                if (confirm == DialogResult.Yes)
                {
                    Inventory.RemoveProduct(product.ProductID);
                }

            }
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            String query = partsSearchTextBox.Text;


            if (string.IsNullOrWhiteSpace(query))
            {

                _partsInventory.DataSource = Inventory.AllParts;

            }
            else
            {
                BindingList<Part> matches = new BindingList<Part>();
                if (int.TryParse(query, out int result))
                {
                    Part? part = Inventory.LookupPart(result);
                    if (part != null)
                    {
                        matches.Add(part);
                    }
                }
                else
                {
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                        {
                            matches.Add(part);
                        }
                    }
                }

                if (matches.Count > 0)
                {
                    _partsInventory.DataSource = matches;
                }
                else
                {
                    MessageBox.Show("No results found", "Search Results", MessageBoxButtons.OK);
                }

            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            string query = productsSearchTextBox.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                _productsInventory.DataSource = Inventory.Products;
            }
            else
            {
                BindingList<Product> matches = new BindingList<Product>();

                if (int.TryParse(query, out int result))
                {
                    Product? product = Inventory.LookupProduct(result);

                    if (product != null)
                    {
                        matches.Add(product);
                    }
                }
                else
                {
                    foreach (Product product in Inventory.Products)
                    {
                        if (product.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                        {
                            matches.Add(product);
                        }
                    }
                }

                if (matches.Count > 0)
                {
                    _productsInventory.DataSource = matches;
                }
                else
                {
                    MessageBox.Show("No results found", "Search Results",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            ModifyPartForm modifyPartForm = new ModifyPartForm((Part)partsDataGridView.CurrentRow.DataBoundItem);
            modifyPartForm.ShowDialog();
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            ModifyProductForm modifyProductForm = new ModifyProductForm((Product)productsDataGridView.CurrentRow.DataBoundItem);
            modifyProductForm.ShowDialog();
        }
    }
}
