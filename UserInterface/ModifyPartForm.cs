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
    public partial class ModifyPartForm : Form
    {
        private Part _partToModify;
        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            _partToModify = part;

            idTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceCostTextBox.Text = part.Price.ToString();
            minTextBox.Text = part.Min.ToString();
            maxTextBox.Text = part.Max.ToString();

            if (part is Inhouse inhouse)
            {
                inHouseRadio.Checked = true;
                variableTextBox.Text = inhouse.MachineID.ToString();
            }
            else if (part is Outsourced outsourced)
            {
                outsourcedRadio.Checked = true;
                variableTextBox.Text = outsourced.CompanyName;
            }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

            _partToModify.Name = name;
            _partToModify.InStock = inventory;
            _partToModify.Price = price;
            _partToModify.Min = min;
            _partToModify.Max = max;

            if (inHouseRadio.Checked && _partToModify is Inhouse inhouse)
            {
                if (!int.TryParse(variableTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.", "Invalid Input");
                    return;
                }
                inhouse.MachineID = machineID;
            }
            else if (outsourcedRadio.Checked && _partToModify is Outsourced outsourced)
            {
                string companyName = variableTextBox.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Company Name cannot be blank.", "Invalid Input");
                    return;
                }
                outsourced.CompanyName = companyName;
            }

            this.Close();
        }
    }
}
