using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAdmin.Windows.UI
{
    public partial class Form1 : Form
    {
        private IRepository _products;
        public Form1()
        {
            InitializeComponent();

            _products = new SqlRepo();
            foreach (var item in _products.GetProducts()) {
                listBox1.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _products.Add(new Product { Name = "Testobject", Price = 1000 });
            listBox1.Items.Clear();
            foreach (var item in _products.GetProducts())
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
