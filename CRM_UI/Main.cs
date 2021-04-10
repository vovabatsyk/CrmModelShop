using System;
using System.Windows.Forms;
using CRM_Bl;
using CRM_Bl.Model;

namespace CRM_UI
{
    public partial class Main : Form
    {
        private AppDbContext _context;
        public Main()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var catalog = new Catalog<Product>(_context.Products);
           catalog.Show();
        }

        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalog = new Catalog<Customer>(_context.Customers);
            catalog.Show();
        }

        private void showAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var catalog = new Catalog<Seller>(_context.Sellers);
            catalog.Show();
        }

        private void newSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                _context.Customers.Add(customerForm.Customer);
                _context.SaveChanges();
            }
        }
    }
}
