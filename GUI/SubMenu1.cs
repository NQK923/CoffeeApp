using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubMenu1 : Form
    {
        public UserDTO user { get; set; }
        int number = 0;
        private staff staff;
        private Management management;
        public SubMenu1()
        {
            InitializeComponent();
            PaymentMethods.Items.Add("by Cash");
            Password.Visible = false;
            SetPriceAndName();
        }
        public void SetDataFromLogin(UserDTO data)
        {
            user = data;
        }
        bool menuExpand = false;
        int total = 0;
        string connectionString = "Data Source=DESKTOP-0HUV1DN\\SQLEXPRESS;Initial Catalog=Coffee;User ID=sa;Password=123;TrustServerCertificate=true;";


        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {
            Password.Visible = true;
            if (Password.Text == "Password")
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

        private void Menubutton_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    DashBoardpanel.Width = sidebar.Width;
                    Logoutpanel.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 211)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    DashBoardpanel.Width = sidebar.Width;

                    Logoutpanel.Width = sidebar.Width;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Submenu1button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubMenu1 subMenu1 = new SubMenu1();
            subMenu1.Show();
        }


        private void btnMinusEspresso_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberEspresso.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("10").Price);
            }
            numberEspresso.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusEspresso_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberEspresso.Text);
            Product product = new Product();
            product = GetProductByName(labelEspresso.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberEspresso.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("10").Price);
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
                total -= Convert.ToInt32(GetProductById("11").Price);
            }
            numberLatte.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusLatte_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberLatte.Text);
            Product product = new Product();
            product = GetProductByName(labelLatte.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(GetProductById("11").Price);
                numberLatte.Text = Num.ToString();
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
                total -= Convert.ToInt32(GetProductById("7").Price);
            }
            numberCappuccino.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusCappuccino_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCappuccino.Text);
            Product product = new Product();
            product = GetProductByName(labelCappuccino.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(GetProductById("7").Price);
                numberCappuccino.Text = Num.ToString();
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusAmericano_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberAmericano.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("12").Price);
            }
            numberAmericano.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusAmericano_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberAmericano.Text);
            Product product = new Product();
            product = GetProductByName(labelAmericano.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(GetProductById("12").Price);
                numberAmericano.Text = Num.ToString();
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
                total -= Convert.ToInt32(GetProductById("9").Price);
            }
            numberCaramelMacchiato.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";

        }

        private void btnPlusCaramelMacchiato_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberCaramelMacchiato.Text);
            Product product = new Product();
            product = GetProductByName(labelCaramelMacchiato.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(GetProductById("9").Price);
                numberCaramelMacchiato.Text = Num.ToString();
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
                total -= Convert.ToInt32(GetProductById("8").Price);
            }
            numberBlackCoffee.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusBlackCoffee_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberBlackCoffee.Text);
            Product product = new Product();
            product = GetProductByName(labelBlackCoffee.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                total += Convert.ToInt32(GetProductById("8").Price);
                numberBlackCoffee.Text = Num.ToString();
                labelTotal.Text = total.ToString() + "  VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }

        }
        private void btnMinusLycheeJellyTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("1").Price);
            }
            NumberLycheeJellyTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusLycheeJellyTea_Click_1(object sender, EventArgs e)
        {

            int Num = int.Parse(NumberLycheeJellyTea.Text);
            Product product = new Product();
            product = GetProductByName(labeLycheeJellyTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                NumberLycheeJellyTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("1").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }
        }

        private void btnMinusGoldenLotusTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberGoldenLotusTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("2").Price);
            }
            numberGoldenLotusTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusGoldenLotusTea_Click_1(object sender, EventArgs e)
        {

            int Num = int.Parse(numberGoldenLotusTea.Text);
            Product product = new Product();
            product = GetProductByName(labelGoldenLotusTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberGoldenLotusTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("2").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }

        }

        private void btnMinusPeachJellyTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("3").Price);
            }
            numberPeachJellyTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusPeachJellyTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            Product product = new Product();
            product = GetProductByName(labelPeachJellyTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberPeachJellyTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("3").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }

        }

        private void btnMinusRedBeanGreenTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberRedBeanGreenTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("4").Price);
            }
            numberRedBeanGreenTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusRedBeanGreenTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberRedBeanGreenTea.Text);
            Product product = new Product();
            product = GetProductByName(labelRedBeanGreenTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberRedBeanGreenTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("4").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }

        }

        private void btnMinusPeachTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("5").Price);
            }
            numberPeachTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusPeachTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachTea.Text);
            Product product = new Product();
            product = GetProductByName(labelPeachTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                numberPeachTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("5").Price);
                labelTotal.Text = total.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Limited number of products. Wish you sympathize");
            }

        }

        private void btnMinusLycheeTea_Click_1(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            if (Num > 0)
            {
                Num -= 1;
                total -= Convert.ToInt32(GetProductById("6").Price);
            }
            NumberLycheeJellyTea.Text = Num.ToString();
            labelTotal.Text = total.ToString() + " VND";
        }

        private void btnPlusLycheeTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            Product product = new Product();
            product = GetProductByName(labelLycheeTea.Text.ToString());
            int quantityRemaining = int.Parse(product.Provider);
            if (Num < quantityRemaining)
            {
                Num += 1;
                NumberLycheeJellyTea.Text = Num.ToString();
                total += Convert.ToInt32(GetProductById("6").Price);
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
                    DrinkId = GetDrinkID(labelCappuccino.Text.ToString());
                    Quantity = int.Parse(numberCappuccino.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelCappuccino.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);

                }
                if (int.Parse(numberBlackCoffee.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelBlackCoffee.Text.ToString());
                    Quantity = int.Parse(numberBlackCoffee.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelBlackCoffee.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberCaramelMacchiato.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelCaramelMacchiato.Text.ToString());
                    Quantity = int.Parse(numberCaramelMacchiato.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelCaramelMacchiato.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberEspresso.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelEspresso.Text.ToString());
                    Quantity = int.Parse(numberEspresso.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelEspresso.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberLatte.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelLatte.Text.ToString());
                    Quantity = int.Parse(numberLatte.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelLatte.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberAmericano.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelAmericano.Text.ToString());
                    Quantity = int.Parse(numberAmericano.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelAmericano.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(NumberLycheeJellyTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labeLycheeJellyTea.Text.ToString());
                    Quantity = int.Parse(NumberLycheeJellyTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labeLycheeJellyTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberPeachTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelPeachTea.Text.ToString());
                    Quantity = int.Parse(numberPeachTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelPeachTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberGoldenLotusTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelGoldenLotusTea.Text.ToString());
                    Quantity = int.Parse(numberGoldenLotusTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelGoldenLotusTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberLycheeTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelLycheeTea.Text.ToString());
                    Quantity = int.Parse(numberLycheeTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelLycheeTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberRedBeanGreenTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelRedBeanGreenTea.Text.ToString());
                    Quantity = int.Parse(numberRedBeanGreenTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelRedBeanGreenTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                if (int.Parse(numberPeachJellyTea.Text) > 0)
                {
                    DrinkId = GetDrinkID(labelPeachJellyTea.Text.ToString());
                    Quantity = int.Parse(numberPeachJellyTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time, user.UserId);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);

                    Product product = new Product();
                    product = GetProductByName(labelPeachJellyTea.Text.ToString());
                    int quantityRemaining = int.Parse(product.Provider);
                    quantityRemaining = quantityRemaining - Quantity;
                    product.Provider = quantityRemaining.ToString();
                    UpdateProduct(product);
                }
                Order order = new Order();
                order.UserId = user.UserId;
                order.PointUse = 0;
                order.DateTime = DateTime.Now;
                order.Status = false;
                order.Total = total;
                CreateOrder(order);

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

        private int GetDrinkID(String drinkName)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkId FROM Drink WHERE DrinkName = @DrinkName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkName", drinkName);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int drinkId;
                        if (int.TryParse(result.ToString(), out drinkId))
                        {
                            return drinkId;
                        }
                    }
                }
            }

            return -1; // Drink not found
        }

        public void CreateDrinkOrder(int DrinkId, int Quantity, DateTime Time, int UserId)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DrinkOrder ( DrinkId, Quantity,Time,UserId) " +
                                   "VALUES (@DrinkId, @Quantity,@Time,@UserId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DrinkId", DrinkId);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.Parameters.AddWithValue("@UserId", UserId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }




        public int GetDrinkOrderId(int drinkId, int quantity, DateTime time)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkOrderId FROM DrinkOrder WHERE DrinkId = @DrinkId AND Quantity = @Quantity AND Time = @Time";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkId", drinkId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Time", time);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int drinkOrderId;
                        if (int.TryParse(result.ToString(), out drinkOrderId))
                        {
                            return drinkOrderId;
                        }
                    }
                }
            }

            return -1; // Drink order not found
        }
        public void CreateOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Order] (UserId, DateTime, PointUse, Status, Total) " +
                               "VALUES (@UserId, @DateTime, @PointUse, @Status, @Total)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", order.UserId);
                    command.Parameters.AddWithValue("@DateTime", order.DateTime);
                    command.Parameters.AddWithValue("@PointUse", order.PointUse);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@Total", order.Total);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ClearAll()
        {
            numberAmericano.Text = "0";
            numberBlackCoffee.Text = "0";
            numberCappuccino.Text = "0";
            numberCaramelMacchiato.Text = "0";
            numberEspresso.Text = "0";
            numberLatte.Text = "0";
            labelTotal.Text = "0";
            NumberLycheeJellyTea.Text = "0";
            numberGoldenLotusTea.Text = "0";
            numberLycheeTea.Text = "0";
            numberPeachJellyTea.Text = "0";
            numberPeachTea.Text = "0";
            numberRedBeanGreenTea.Text = "0";
            PaymentMethods.Text = "Payment methods";

        }
        public Product GetProductByName(string productName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink WHERE DrinkName = @DrinkName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkName", productName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product
                            {
                                DrinkId = reader.GetInt32(0),
                                DrinkName = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Cost = reader.GetDecimal(3),
                                Provider = reader.GetString(4)
                            };

                            return product;
                        }
                    }
                }
            }

            return null;
        }
        public Product GetProductById(string productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DrinkId, DrinkName, Price, Cost, Provider FROM Drink WHERE DrinkId = @DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkId", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product
                            {
                                DrinkId = reader.GetInt32(0),
                                DrinkName = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Cost = reader.GetDecimal(3),
                                Provider = reader.GetString(4)
                            };

                            return product;
                        }
                    }
                }
            }

            return null;
        }
        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Drink SET DrinkName = @DrinkName, Price = @Price, Cost = @Cost, Provider = @Provider WHERE DrinkId = @DrinkId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DrinkId", product.DrinkId);
                    command.Parameters.AddWithValue("@DrinkName", product.DrinkName);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Cost", product.Cost);
                    command.Parameters.AddWithValue("@Provider", product.Provider);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void SetPriceAndName()
        {
            labeLycheeJellyTea.Text = GetProductById("1").DrinkName;
            labelGoldenLotusTea.Text = GetProductById("2").DrinkName;
            labelPeachJellyTea.Text = GetProductById("3").DrinkName;
            labelRedBeanGreenTea.Text = GetProductById("4").DrinkName;
            labelPeachTea.Text = GetProductById("5").DrinkName;
            labelLycheeTea.Text = GetProductById("6").DrinkName;
            labelCappuccino.Text = GetProductById("7").DrinkName;
            labelBlackCoffee.Text = GetProductById("8").DrinkName;
            labelCaramelMacchiato.Text = GetProductById("9").DrinkName;
            labelEspresso.Text = GetProductById("10").DrinkName;
            labelLatte.Text = GetProductById("11").DrinkName;
            labelAmericano.Text = GetProductById("12").DrinkName;

            priceLycheeJellyTea.Text = GetProductById("1").Price.ToString() + " VND";
            priceGoldenLotusTea.Text = GetProductById("2").Price.ToString() + " VND";
            pricePeachJellyTea.Text = GetProductById("3").Price.ToString() + " VND";
            priceRedBeanGreenTea.Text = GetProductById("4").Price.ToString() + " VND";
            pricePeachTea.Text = GetProductById("5").Price.ToString() + " VND";
            priceLycheeTea.Text = GetProductById("6").Price.ToString() + " VND";
            priceCappuccino.Text = GetProductById("7").Price.ToString() + " VND";
            priceBlackCoffee.Text = GetProductById("8").Price.ToString() + " VND";
            priceCaramelMacchiato.Text = GetProductById("9").Price.ToString() + " VND";
            priceEspresso.Text = GetProductById("10").Price.ToString() + " VND";
            priceLatte.Text = GetProductById("11").Price.ToString() + " VND";
            priceAmericano.Text = GetProductById("12").Price.ToString() + " VND";

        }


    }

}
