using DE_Lopuh.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Lopuh
{
    public partial class AddForm : Form
    {
        private string imagePath;
        private Model1 ef = new Model1();
        public AddForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"products\Лопушок.png");
            imagePath = @"products\Лопушок.png";
            var productType = ef.ProductType.Select(m => m.Title).ToList();
            productTypeIDComboBox.DataSource = productType;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Картинки (*.jpeg)|*.jpeg|Картинки (*.png)|*.png";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
            }

            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Поле название неверно");
                return;
            }

            decimal minCostForAgent;
            int productionPersonCount;
            int productionWorkshopNumber;

            try
            {
                minCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
                productionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
                productionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Цифры введены неверено");
                return;
            }

            if (minCostForAgent <= 0 || productionPersonCount <= 0 || productionWorkshopNumber <= 0)
            {
                MessageBox.Show("Цифры введены неверено");
                return;
            }

            Product product = new Product();

            product.Title = titleTextBox.Text;
            product.Description = descriptionTextBox.Text;
            product.ProductionWorkshopNumber = productionWorkshopNumber;
            product.ProductionPersonCount = productionPersonCount;
            product.MinCostForAgent = minCostForAgent;
            product.ArticleNumber = articleNumberTextBox.Text;

            product.ProductTypeID = productTypeIDComboBox.SelectedIndex + 1;
            product.Image = imagePath;

            ef.Product.Add(product);
            try
            {
                ef.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("Поле не прошло валидацию");
                ef.Product.Remove(product);
                return;
            }
            MessageBox.Show("Товар добавлен");
            Program.form1.PrepareData();
            Close();

        }
    }
}
