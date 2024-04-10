using DE_Lopuh.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Lopuh
{
    public partial class Form1 : Form
    {
        private int currentPage = 0;
        private int productsOnPage = 20;
        private Model1 ef = new Model1();

        public Form1()
        {
            InitializeComponent();
            var productType = ef.ProductType.Select(m => m.Title).ToList();
            productType.Insert(0, "Все продукты");
            comboBox2.DataSource = productType;
            comboBox1.SelectedIndex = 0;
            PrepareData();
        }


        public void PrepareData()
        {
            var products = ef.Product.ToList();

            products = products.Where(p => p.Title.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            if (comboBox2.SelectedIndex != 0)
                products = products.Where(p => p.ProductTypeID == comboBox2.SelectedIndex).ToList();

            if (comboBox1.SelectedIndex == 1)
                products = products.OrderBy(p => p.Title).OrderBy(p => p.ProductionWorkshopNumber).OrderBy(p => p.MinCostForAgent).ToList();
            else if (comboBox1.SelectedIndex == 2)
                products = products.OrderByDescending(p => p.Title).OrderByDescending(p => p.ProductionWorkshopNumber).OrderByDescending(p => p.MinCostForAgent).ToList();

            var countPages = products.Count % productsOnPage == 0 ? products.Count / productsOnPage : products.Count / productsOnPage + 1;

            if (currentPage <= 0)
                currentPage = 1;
            else if (currentPage > countPages)
                currentPage = countPages;

            products = products.Skip((currentPage - 1) * productsOnPage).Take(productsOnPage).ToList();

            var pageInfo = new List<string>();
            for (int i = 1; i <= countPages; i++)
            {
                if (i == currentPage)
                    pageInfo.Add($"({i})");
                else
                    pageInfo.Add(i.ToString());
            }
            label2.Text = string.Join(" ", pageInfo);
            
            panel1.Controls.Clear();
            foreach (var product in products)
            {
                panel1.Controls.Add(new UserControl1(product));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareData();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            currentPage--;
            PrepareData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentPage++;
            PrepareData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           new AddForm().ShowDialog();
        }
    }
}
