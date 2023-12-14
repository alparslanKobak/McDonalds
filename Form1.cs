using McDonalds.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McDonalds.Entity.Models;

namespace McDonalds
{

    public partial class Form1 : Form
    {
        public List<Product> basket = new List<Product>();

        public Form1(List<Product> basket)
        {
            this.basket = basket;
        }

        public string size;
        Functions functions = new Functions();
        OrderCrud oc = new OrderCrud(); 
        OrderProductCrud opc = new OrderProductCrud();  
        ProductCrud pc = new ProductCrud(); 
        MenuProductCrud mp = new MenuProductCrud();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void SizeSmallBtn_Click(object sender, EventArgs e)
        {
            size = "small";
            SizeSmallBtn.ForeColor = Color.Red;
            SizeSmallBtn.BackColor = Color.Yellow;

            SizeMediumBtn.ForeColor = Color.Yellow;
            SizeMediumBtn.BackColor = Color.Red;

            SizeLargeBtn.ForeColor = Color.Yellow;
            SizeLargeBtn.BackColor = Color.Red;
            

        }

        private void SizeMediumBtn_Click(object sender, EventArgs e)
        {
            size = "medium";
            SizeMediumBtn.ForeColor = Color.Red;
            SizeMediumBtn.BackColor = Color.Yellow;

            SizeLargeBtn.ForeColor = Color.Yellow;
            SizeLargeBtn.BackColor = Color.Red;

            SizeSmallBtn.ForeColor = Color.Yellow;
            SizeSmallBtn.BackColor = Color.Red;
        }

        private void SizeLargeBtn_Click(object sender, EventArgs e)
        {
            size = "large";
            SizeLargeBtn.ForeColor = Color.Red; 
            SizeLargeBtn.BackColor = Color.Yellow;

            SizeMediumBtn.ForeColor = Color.Yellow;
            SizeMediumBtn.BackColor = Color.Red;

            SizeSmallBtn.ForeColor = Color.Yellow;
            SizeSmallBtn.BackColor = Color.Red;
        }

        private void OrderDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you want the delete current order?","Delete Order",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if (ask == DialogResult.OK)
            {

                basket.Clear();
                LoadForm();
            }


        }

        private void OrderConfirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you want the confirm current order?", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ask == DialogResult.OK)
            {

                functions.BuyProduct(basket);

                basket.Clear();
                LoadForm();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            size = "medium";
            SizeMediumBtn.ForeColor = Color.Red;
            SizeMediumBtn.BackColor = Color.Yellow;
           
        }
        public void LoadForm()
        {



            
            //dataGridView1.Columns.Remove("Id");
            //dataGridView1.Columns.Remove("CategoryId");
            //dataGridView1.Columns.Remove("PreparationTime");
            //dataGridView1.Columns.Remove("Image");
            double price = 0;
            foreach (var item in basket)
            {
                price += item.Price;
            }

            TotalPriceLbl.Text = "Total: " + price.ToString();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = this.basket;
        }



        private void BigMacBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(1);
            this.basket.Add(item);
            
            LoadForm();
            

        }

        private void McChickenBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(2);
            this.basket.Add(item);

            LoadForm();

        }

        private void CheeseBurgerBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(3);
            this.basket.Add(item);

            LoadForm();

        }

        private void QuarterPounderBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(4);
            this.basket.Add(item);

            LoadForm();
        }

        private void DoubleCheeseBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(5);
            this.basket.Add(item);

            LoadForm();
        }

        private void MilliBurgerBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(6);
            this.basket.Add(item);

            LoadForm();
        }

        private void DoubleMcChiBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(8);
            this.basket.Add(item);

            LoadForm();
        }

        private void DoubleQuarterPounderBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(11);
            this.basket.Add(item);

            LoadForm();
        }

        private void IceTeaLemonBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 21 : size == "medium" ? 22 : 23;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 24 : size == "medium" ? 25 : 26;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();

        }

        private void CokeZeroBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 27 : size == "medium" ? 28 : 29;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void CokeBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 30 : size == "medium" ? 31 : 32;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void SodaBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 33 : size == "medium" ? 34 : 35;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void FantaBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 36 : size == "medium" ? 37 : 38;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void AyranBtn_Click(object sender, EventArgs e)
        {
            

            Product item = pc.GetById(39);
            this.basket.Add(item);

            LoadForm();
        }

        private void FriesBtn_Click(object sender, EventArgs e)
        {
            int id = size == "small" ? 40 : size == "medium" ? 41 : 42;

            Product item = pc.GetById(id);
            this.basket.Add(item);

            LoadForm();
        }

        private void OnionRingsBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(43);
            this.basket.Add(item);

            LoadForm();
        }

        private void NuggetSixBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(44);
            this.basket.Add(item);

            LoadForm();
        }

        private void NuggetNineBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(45);
            this.basket.Add(item);

            LoadForm();
        }

        private void BigMacMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 1).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }

           

            

            LoadForm();
        }

        private void McChickenMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 2).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();

        }

        private void CheeseburgerMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 3).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void QurterPounderMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 4).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void DoubleCheeseBurgerMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 5).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void MilliBurgerMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 6).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void DoubleMcChikenMenuBtn_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 7).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = mp.GetAll().Where(x => x.MenuId == 8).ToList();
            foreach (var item in items)
            {
                this.basket.Add(pc.GetById(item.ProductId));
            }





            LoadForm();
        }

        private void MustardBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(12);
            this.basket.Add(item);

            LoadForm();

        }

        private void RanchBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(13);
            this.basket.Add(item);

            LoadForm();
        }

        private void BbBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(14);
            this.basket.Add(item);

            LoadForm();
        }

        private void KetchupBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(15);
            this.basket.Add(item);

            LoadForm();
        }

        private void GarlicMAyoBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(16);
            this.basket.Add(item);

            LoadForm();
        }

        private void BuffaloBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(17);
            this.basket.Add(item);

            LoadForm();
        }

        private void HoneyMustartBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(18);
            this.basket.Add(item);

            LoadForm();
        }

        private void HotSoucceBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(19);
            this.basket.Add(item);

            LoadForm();
        }

        private void MayoBtn_Click(object sender, EventArgs e)
        {
            Product item = pc.GetById(20);
            this.basket.Add(item);

            LoadForm();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Product selectedProduct = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                basket.Remove(selectedProduct);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = basket;
            }
        }
    }
}
