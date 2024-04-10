using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE_Lopuh.ModelEF;

namespace DE_Lopuh
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;
        public UserControl1(Product product)
        {
            InitializeComponent();
            _product = product;
            Fill(product);

            foreach(Control item in Controls)
            {
                item.Click += (s, e) => UserControl1_Click(s, e);
            }
        }
        public void Fill (Product product)
        {
            var model1 = new Model1();
            ProductType1.Text = product.ProductTypeID.ToString();
            ProductName1.Text = product.Title;
            Article.Text = product.ArticleNumber.ToString();
            Cost1.Text = product.MinCostForAgent.ToString();
            var materials = model1.ProductMaterial.Where(pm => pm.ProductID == product.ID).Select(pm => pm.Material.Title).ToList();
            material1.Text = materials.Count == 0 ? "Нет материалов" : string.Join(", ", materials);
            pictureBox1.Image = Image.FromFile(string.IsNullOrEmpty(product.Image) ? @"products\Лопушок.png": product.Image);
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            new Form2(_product).ShowDialog();
        }
    }
}
