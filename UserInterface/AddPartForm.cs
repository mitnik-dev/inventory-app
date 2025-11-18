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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            idTextBox.Text = Inventory.AutoPartID.ToString();
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                variableLabel.Text = "Machine ID";
            }
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRadio.Checked)
            {
                variableLabel.Text = "Company Name";
            }
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

            if (inHouseRadio.Checked)
            {
                if (!int.TryParse(variableTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.", "Invalid Input");
                    return;
                }

                Inhouse inhouse = new Inhouse(name, price, inventory, min, max, machineID);
                Inventory.AddPart(inhouse);
            }
            else
            {
                string companyName = variableTextBox.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Company Name cannot be blank.", "Invalid Input");
                    return;
                }

                Outsourced outsourced = new Outsourced(name, price, inventory, min, max, companyName);
                Inventory.AddPart(outsourced);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
