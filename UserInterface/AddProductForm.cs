using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.UserInterface
{
    public partial class AddProductForm : Form
    {
        private readonly BindingSource _candidatePartsInventory = new BindingSource();
        private readonly BindingSource _partsAssociatedInventory = new BindingSource();
        private Product _product = new Product();
        public AddProductForm()
        {
            InitializeComponent();

            candidatePartsDataGridView.AutoGenerateColumns = false;
            AddColumns(candidatePartsDataGridView);

            partsAssociatedDataGridView.AutoGenerateColumns = false;
            AddColumns(partsAssociatedDataGridView);


            _candidatePartsInventory.DataSource = Inventory.AllParts;
            candidatePartsDataGridView.DataSource = _candidatePartsInventory;


            _partsAssociatedInventory.DataSource = _product.AssociatedParts;
            partsAssociatedDataGridView.DataSource = _partsAssociatedInventory;

            idTextBox.Text = Inventory.AutoProductID.ToString();
        }

        private static void AddColumns(DataGridView grid)
        {
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Part ID", DataPropertyName = "PartID" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Inventory", DataPropertyName = "InStock" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price", DefaultCellStyle = { Format = "C2" } });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min", DataPropertyName = "Min" });
            grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max", DataPropertyName = "Max" });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int inventory, min, max;
            decimal price;
            string name = nameTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be blank.", "Invalid Input");
                return;
            }

            if (!int.TryParse(inventoryTextBox.Text, out inventory))
            {
                MessageBox.Show("Inventory must be a whole number.", "Invalid Input");
                return;
            }

            if (!decimal.TryParse(priceCostTextBox.Text, out price))
            {
                MessageBox.Show("Price must be a decimal.", "Invalid Input");
                return;
            }

            if (!int.TryParse(maxTextBox.Text, out max))
            {
                MessageBox.Show("Max must be a whole number.", "Invalid Input");
                return;
            }

            if (!int.TryParse(minTextBox.Text, out min))
            {
                MessageBox.Show("Min must be a whole number.", "Invalid Input");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.", "Invalid Input");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.", "Invalid Input");
                return;
            }

            _product.Name = name;
            _product.Price = price;
            _product.InStock = inventory;
            _product.Min = min;
            _product.Max = max;

            Inventory.AddProduct(_product);

            this.Close();
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)candidatePartsDataGridView.CurrentRow.DataBoundItem;

            if (part != null)
            {
                if (_product.LookupAssociatedPart(part.PartID) != null)
                {
                    MessageBox.Show("Selected part already associated with product", "Invalid Selection");
                    return;
                }
                else
                {
                    _product.AddAssociatedPart(part);
                    _partsAssociatedInventory.ResetBindings(false);
                }
            }
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)partsAssociatedDataGridView.CurrentRow.DataBoundItem;

            if (part != null)
            {
                DialogResult confirm = MessageBox.Show($"Remove '{part.Name}' from associated parts?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    _product.RemoveAssociatedPart(part.PartID);
                    _partsAssociatedInventory.ResetBindings(false);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            string query = productsSearchTextBox.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                _candidatePartsInventory.DataSource = Inventory.AllParts;
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
                    _candidatePartsInventory.DataSource = matches;
                }
                else
                {
                    MessageBox.Show("No results found", "Search Results",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
