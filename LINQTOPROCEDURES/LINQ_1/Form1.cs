using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext northwind = new DataClasses1DataContext();
        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void cargarCombo()
        {
            var cargaCombo = from p in northwind.Products
                             select p.ProductName;
            comboNombreProd.DataSource = cargaCombo;
        }

        void cargarGrid()
        {
            var cargaGrid = from p in northwind.Products
                            select p;
            GridDatos.DataSource = cargaGrid;

        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = textProd.Text;
            MyProduct.UnitPrice = int.Parse(textPrec.Text);
            MyProduct.UnitsInStock = short.Parse(textStock.Text);
            MyProduct.CategoryID = int.Parse(textCat.Text);
            northwind.Products.InsertOnSubmit(MyProduct);
            northwind.SubmitChanges();
            cargarGrid();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboNombreProd.SelectedItem.ToString());
            Products MyProduct = northwind.Products.Single(p=> p.ProductName==comboNombreProd.SelectedItem.ToString());
            MyProduct.ProductName = comboNombreProd.SelectedItem.ToString();
            MyProduct.UnitPrice = int.Parse(textPrec.Text);
            MyProduct.UnitsInStock = short.Parse(textStock.Text);
            MyProduct.CategoryID = int.Parse(textCat.Text);
            northwind.SubmitChanges();
            cargarGrid();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Products MyProduct = northwind.Products.Single(p=> p.ProductName==comboNombreProd.SelectedItem.ToString());
            northwind.Products.DeleteOnSubmit(MyProduct);
            northwind.SubmitChanges();
            cargarGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }
    }
}

