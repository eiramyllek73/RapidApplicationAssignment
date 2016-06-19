using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidApplicationAssignment
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzAFlynShopDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.furzAFlynShopDBDataSet.Customers);

        }
    }
}
