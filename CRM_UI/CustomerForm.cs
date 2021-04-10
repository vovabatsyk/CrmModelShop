using System.Windows.Forms;
using CRM_Bl.Model;

namespace CRM_UI
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Customer = new Customer() { Name = textBox1.Text };

            Close();
        }
    }
}
