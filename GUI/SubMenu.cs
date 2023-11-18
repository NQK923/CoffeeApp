using DTO;
using System;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;

namespace GUI
{
    public partial class SubMenu : Form
    {
        private ProductBLL ProductBLL = new ProductBLL();
        private DrinkOrderBLL DrinkOrderBLL = new DrinkOrderBLL();
        private OrderBLL OrderBLL = new OrderBLL();
        public UserDTO user { get; set; }
        int number = 0;
        private staff staff;
        private Management management;
        public SubMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentMethods.Items.Add("by Cash");
            Password.Visible = false;
            SetPriceAndName();
            this.KeyPreview = true;
            this.KeyDown += SubMenu_KeyDown;
        }
        public void SetDataFromLogin(UserDTO data)
        {
            user = data;
        }
        bool menuExpand = false;
        int total = 0;

        public void ClearAll()
        {
            numberAmericano.Text = "0";
            numberBlackCoffee.Text = "0";
            numberCappuccino.Text = "0";
            numberCaramelMacchiato.Text = "0";
            numberEspresso.Text = "0";
            numberLatte.Text = "0";
            labelTotal.Text = "0";
            numberGoldenLotusTea.Text = "0";
            numberPeachJellyTea.Text = "0";
            PaymentMethods.Text = "Payment methods";

        }

        public void SetPriceAndName()
        {
            labelLycheeJellyTea.Text = ProductBLL.GetProductById("1").DrinkName;
            labelGoldenLotusTea.Text = ProductBLL.GetProductById("2").DrinkName;
            labelPeachJellyTea.Text = ProductBLL.GetProductById("3").DrinkName;
            labelCappuccino.Text = ProductBLL.GetProductById("7").DrinkName;
            labelBlackCoffee.Text = ProductBLL.GetProductById("8").DrinkName;
            labelCaramelMacchiato.Text = ProductBLL.GetProductById("9").DrinkName;
            labelEspresso.Text = ProductBLL.GetProductById("10").DrinkName;
            labelLatte.Text = ProductBLL.GetProductById("11").DrinkName;
            labelAmericano.Text = ProductBLL.GetProductById("12").DrinkName;

            priceLycheeJellyTea.Text = ProductBLL.GetProductById("1").Price.ToString() + " VND";
            priceGoldenLotusTea.Text = ProductBLL.GetProductById("2").Price.ToString() + " VND";
            pricePeachJellyTea.Text = ProductBLL.GetProductById("3").Price.ToString() + " VND";
            priceCappuccino.Text = ProductBLL.GetProductById("7").Price.ToString() + " VND";
            priceBlackCoffee.Text = ProductBLL.GetProductById("8").Price.ToString() + " VND";
            priceCaramelMacchiato.Text = ProductBLL.GetProductById("9").Price.ToString() + " VND";
            priceEspresso.Text = ProductBLL.GetProductById("10").Price.ToString() + " VND";
            priceLatte.Text = ProductBLL.GetProductById("11").Price.ToString() + " VND";
            priceAmericano.Text = ProductBLL.GetProductById("12").Price.ToString() + " VND";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubMenu subMenu1 = new SubMenu();
            subMenu1.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Password.Visible = true;
            if (Password.Text == "Password" || Password.Text ==null)
            {
                MessageBox.Show("Enter password");
            }
            if (Password.Text == "123")
            {
                management = new Management();
                management.SetDataFromLogin(user);
                management.Show();
                Password.Text = "Password";
                Password.Visible = false;
            }
            if (Password.Text != "123" && Password.Text != "Password")
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnMinusAmericano_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberAmericano.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("12").Price);
            }
            numberAmericano.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusAmericano_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberAmericano.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelAmericano.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(ProductBLL.GetProductById("12").Price);
                numberAmericano.Text = Num.ToString();
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusEspresso_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberEspresso.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("10").Price);
            }
            numberEspresso.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusEsprosso_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberEspresso.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelEspresso.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberEspresso.Text = Num.ToString();
                total += Convert.ToInt32(ProductBLL.GetProductById("10").Price);
                labelTotal.Text = total.ToString() + " VND";

            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusCappuccino_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCappuccino.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("7").Price);
            }
            numberCappuccino.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusCappuccino_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCappuccino.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelCappuccino.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(ProductBLL.GetProductById("7").Price);
                numberCappuccino.Text = Num.ToString();
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusCaramelMacchiato_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCaramelMacchiato.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("9").Price);
            }
            numberCaramelMacchiato.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusCaramelMacchiato_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCaramelMacchiato.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelCaramelMacchiato.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(ProductBLL.GetProductById("9").Price);
                numberCaramelMacchiato.Text = Num.ToString();
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusLatte_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberLatte.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("11").Price);
            }
            numberLatte.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusLatte_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberLatte.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelLatte.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(ProductBLL.GetProductById("11").Price);
                numberLatte.Text = Num.ToString();
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusBlackCoffee_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberBlackCoffee.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("8").Price);
            }
            numberBlackCoffee.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusBlackCoffee_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberBlackCoffee.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelBlackCoffee.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(ProductBLL.GetProductById("8").Price);
                numberBlackCoffee.Text = Num.ToString();
                labelTotal.Text = total.ToString() + "  VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusPeachJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("3").Price);
            }
            numberPeachJellyTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusPeachJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelPeachJellyTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberPeachJellyTea.Text = Num.ToString();
                total += Convert.ToInt32(ProductBLL.GetProductById("3").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusGoldenLotusTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberGoldenLotusTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("2").Price);
            }
            numberGoldenLotusTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusGoldenLotusTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberGoldenLotusTea.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelGoldenLotusTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberGoldenLotusTea.Text = Num.ToString();
                total += Convert.ToInt32(ProductBLL.GetProductById("2").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusLycheeJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberLycheeJellyTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(ProductBLL.GetProductById("1").Price);
            }
            numberLycheeJellyTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusLycheeJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberLycheeJellyTea.Text);
            ProductDTO product = new ProductDTO();
            product = ProductBLL.GetProductByName(labelLycheeJellyTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberLycheeJellyTea.Text = Num.ToString();
                total += Convert.ToInt32(ProductBLL.GetProductById("1").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int DrinkId;
            int DrinkOrderId;
            int Quantity;

            List<int> drinkOrderList = new List<int>();
            drinkOrderList.Clear();
            DateTime time = DateTime.Now;
            if (total > 0)
            {

                if (int.Parse(numberCappuccino.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelCappuccino.Text.ToString());
                    Quantity = int.Parse(numberCappuccino.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelCappuccino.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);

                }
                if (int.Parse(numberBlackCoffee.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelBlackCoffee.Text.ToString());
                    Quantity = int.Parse(numberBlackCoffee.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelBlackCoffee.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberCaramelMacchiato.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelCaramelMacchiato.Text.ToString());
                    Quantity = int.Parse(numberCaramelMacchiato.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelCaramelMacchiato.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberEspresso.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelEspresso.Text.ToString());
                    Quantity = int.Parse(numberEspresso.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelEspresso.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberLatte.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelLatte.Text.ToString());
                    Quantity = int.Parse(numberLatte.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelLatte.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberAmericano.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelAmericano.Text.ToString());
                    Quantity = int.Parse(numberAmericano.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelAmericano.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberLycheeJellyTea.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelLycheeJellyTea.Text.ToString());
                    Quantity = int.Parse(numberLycheeJellyTea.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelLycheeJellyTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }

                if (int.Parse(numberGoldenLotusTea.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelGoldenLotusTea.Text.ToString());
                    Quantity = int.Parse(numberGoldenLotusTea.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelGoldenLotusTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                if (int.Parse(numberPeachJellyTea.Text) > 0)
                {
                    DrinkId = ProductBLL.GetDrinkID(labelPeachJellyTea.Text.ToString());
                    Quantity = int.Parse(numberPeachJellyTea.Text);
                    DrinkOrderBLL.CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = DrinkOrderBLL.GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    ProductDTO product = new ProductDTO();
                    product = ProductBLL.GetProductByName(labelPeachJellyTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    ProductBLL.UpdateProduct(product);
                }
                OrderDTO order = new OrderDTO();
                order.UserId = user.UserId;
                order.PointUse = 0;
                order.DateTime = DateTime.Now;
                order.Status = false;
                order.Total = total;
                OrderBLL.CreateOrder(order);

                string paymentMethods = PaymentMethods.Text.ToString();
                if (paymentMethods != "Payment methods")
                {
                    if (drinkOrderList != null)
                    {
                        ClearAll();
                        total = 0;
                        number += 1;
                        if (staff == null || staff.IsDisposed)
                        {
                            staff = new staff();
                            staff.SetDataFromUserOrder(drinkOrderList, order, number);
                            staff.Show();
                        }
                        else
                        {
                            staff.SetDataFromUserOrder(drinkOrderList, order, number);
                            staff.Update();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Choose payment method");
                }
            }
            else
            {
                MessageBox.Show("Choose at least one item");
            }
        }

        private void SubMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnManage_Click(sender, e);
            }
        }
    }
}
