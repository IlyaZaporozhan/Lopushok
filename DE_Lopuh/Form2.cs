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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DE_Lopuh
{
    public partial class Form2 : Form
    {
        private Product _product;
        private Model1 ef = new Model1();
        private string imagePath;
        public Form2(Product product)
        {
            InitializeComponent();
            _product = product;
            imagePath = product.Image;
            articleNumberTextBox.Text = product.ArticleNumber;
            descriptionTextBox.Text = product.Description;
            iDTextBox.Text = product.ID.ToString();
            minCostForAgentTextBox.Text = product.MinCostForAgent.ToString();
            productionPersonCountTextBox.Text = product.ProductionPersonCount.ToString();
            productionWorkshopNumberTextBox.Text = product.ProductionWorkshopNumber.ToString();
            titleTextBox.Text = product.Title;
            pictureBox1.Image = Image.FromFile(string.IsNullOrEmpty(product.Image) ? @"products\Лопушок.png" : product.Image);

            var productType = ef.ProductType.Select(m => m.Title).ToList();
            productTypeIDComboBox.DataSource = productType;
            productTypeIDComboBox.SelectedIndex = product.ProductTypeID - 1 ?? 0;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ef.Product.Remove(ef.Product.First(p => p.ID == _product.ID));
            ef.SaveChanges();
            MessageBox.Show("Вы молодцы! Товар был удалён.");
            Program.form1.PrepareData();
            Close();
        }

        private void redactButton_Click(object sender, EventArgs e)
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

            _product.Title = titleTextBox.Text;
            _product.Description = descriptionTextBox.Text;
            _product.ProductionWorkshopNumber = productionWorkshopNumber;
            _product.ProductionPersonCount = productionPersonCount;
            _product.MinCostForAgent = minCostForAgent;
            _product.ArticleNumber = articleNumberTextBox.Text;

            _product.ProductTypeID = productTypeIDComboBox.SelectedIndex + 1;
            _product.Image = imagePath;

            ef.SaveChanges();
            MessageBox.Show("Данные сохранены");
            Program.form1.PrepareData();
            Close();
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
    }
}
