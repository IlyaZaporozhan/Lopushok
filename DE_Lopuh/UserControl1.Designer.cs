namespace DE_Lopuh
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductType1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductName1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cost1 = new System.Windows.Forms.Label();
            this.Article = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.material1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductType1
            // 
            this.ProductType1.AutoSize = true;
            this.ProductType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductType1.Location = new System.Drawing.Point(262, 48);
            this.ProductType1.Name = "ProductType1";
            this.ProductType1.Size = new System.Drawing.Size(147, 25);
            this.ProductType1.TabIndex = 0;
            this.ProductType1.Text = "Тип продукта";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ProductName1
            // 
            this.ProductName1.AutoSize = true;
            this.ProductName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductName1.Location = new System.Drawing.Point(464, 48);
            this.ProductName1.Name = "ProductName1";
            this.ProductName1.Size = new System.Drawing.Size(259, 25);
            this.ProductName1.TabIndex = 2;
            this.ProductName1.Text = "Наименование продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(428, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1010, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Стоимость";
            // 
            // Cost1
            // 
            this.Cost1.AutoSize = true;
            this.Cost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost1.Location = new System.Drawing.Point(989, 73);
            this.Cost1.Name = "Cost1";
            this.Cost1.Size = new System.Drawing.Size(156, 25);
            this.Cost1.TabIndex = 5;
            this.Cost1.Text = "Тут сама цена";
            // 
            // Article
            // 
            this.Article.AutoSize = true;
            this.Article.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Article.Location = new System.Drawing.Point(263, 73);
            this.Article.Name = "Article";
            this.Article.Size = new System.Drawing.Size(72, 20);
            this.Article.TabIndex = 6;
            this.Article.Text = "Артикул";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(263, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Материалы:";
            // 
            // material1
            // 
            this.material1.AutoSize = true;
            this.material1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.material1.Location = new System.Drawing.Point(370, 105);
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(95, 20);
            this.material1.TabIndex = 8;
            this.material1.Text = "Материал1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.material1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Article);
            this.Controls.Add(this.Cost1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductType1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1171, 186);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductType1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Cost1;
        private System.Windows.Forms.Label Article;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label material1;
    }
}
