﻿using AutoMapper;
using E_Commerce.Applications.Mapper;
using E_Commerce.Applications.Services;
using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using E_Commerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_Commerce.Presentation
{
    public partial class Home : Form
    {
        IMapper mapper = Mapping.MappingAddCustomer();
        UserService userService = new UserService(new UserRepository(new ApplicationDbContext()));
        CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
        ProductService productService = new ProductService(new ProductRepository(new ApplicationDbContext()));
        OrderService orderService = new OrderService(new OrderRepository(new ApplicationDbContext()));
        private List<CartItems> CartItemsproducts = new List<CartItems>();
        private static User LoginedUser;

        public Home()
        {
            InitializeComponent();
            SelectHomePage();
            BindCategories();
            BindProducts();

        }
        private void BindCategories()
        {
            var categories = categoryService.GetCategories().ToList();

            comboxCategory.DataSource = categories;
            comboxCategory.DisplayMember = "Name";
            comboxCategory.ValueMember = "ID";
        }
        private void BindProducts()
        {
            flowLayoutProductPanel.Controls.Clear();
            var Products = productService.GetProducts().ToList();
            foreach (var p in Products)
            {
                ProductDisplayControl product = new ProductDisplayControl();
                product.Id = p.ID;
                product.pname = p.Name;
                product.Price = p.Price;
                product.Quantity = p.Quantity;
                product.CategoryName = p.Category.Name;
                product.image = Image.FromFile(p.Image);
                if (product.Quantity <= 0)
                {
                    product.button1.Text = "Out Of Stock";
                    product.button1.BackColor = Color.Red;
                    product.button1.Enabled =false;
                }
                else
                {
                    product.button1.Text = "Add to Card";
                    product.button1.BackColor = Color.Green;
                    product.button1.Enabled = true;
                }
                product.ADDProductIdToCart += BindTOCart;
                    flowLayoutProductPanel.Controls.Add(product);
            }
        }
        public void BindTOCart(int id)
        {
            var product = productService.GetProduct(id);
            bool checkProductAddedToCartBefore = CartItemsproducts.Any(e => e.Id == id);
            if (!checkProductAddedToCartBefore)
            {
                CartItems cartItem = new CartItems();
                cartItem.Id = product.ID;
                cartItem.Title = product.Name;
                cartItem.Description = product.Description;
                cartItem.Price = product.Price;
                cartItem.image = Image.FromFile(product.Image);
                cartItem.Quantity = product.Quantity;
                CartItemsproducts.Add(cartItem);
                flowLayoutPanel1.Controls.Add(cartItem);
                cartItem.RemoveProductIdToCart += RemoveFromCart;
                ProductDisplayControl.counter += 1;
                lableEclips1.Visible = true;
                lableEclips1.Text = ProductDisplayControl.counter.ToString();
            }

        }
        public void RemoveFromCart(int id)
        {
            var productControl = CartItemsproducts.FirstOrDefault(p => p.Id == id);
            CartItemsproducts.Remove(productControl);
            flowLayoutPanel1.Controls.Remove(productControl);
            ProductDisplayControl.counter -= 1;
            if (ProductDisplayControl.counter == 0)
                lableEclips1.Visible = false;
            lableEclips1.Text = ProductDisplayControl.counter.ToString();
        }
        private void BindToOrder()
        {
            var orders = orderService;

           
        }
        private void isRequired(Label label)
        {
            label.Visible = true;
            label.Text = "Field is Required";
        }
        private void isValid(Label label, string message)
        {
            label.Visible = true;
            label.Text = message;
        }
        private void FullNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTxt.Text))
            {
                isRequired(ErrorFullName);
            }
            else if (!FullNameTxt.Text.All(char.IsLetter))
            {
                isValid(ErrorFullName, "Name is not valid!");
            }
            else
                ErrorFullName.Visible = false;
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidEmail = Regex.IsMatch(EmailTxt.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (string.IsNullOrEmpty(EmailTxt.Text))
            {
                isRequired(ErrorEmail);
            }
            else if (!isValidEmail)
            {
                isValid(ErrorEmail, "Email Address is not valid!");
            }
            else
                ErrorEmail.Visible = false;
        }

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidPhoneNumber = Regex.IsMatch(PhoneNumberTxt.Text, @"^[0-9]+$");
            if (string.IsNullOrEmpty(PhoneNumberTxt.Text))
            {
                isRequired(ErrorPhoneNumber);
            }
            else if (!isValidPhoneNumber)
            {
                isValid(ErrorPhoneNumber, "Phone Number is not valid!");
            }
            else if (PhoneNumberTxt.Text.Length != 11)
            {
                isValid(ErrorPhoneNumber, "PhoneNumber Must be 11 Numbers");
            }
            else
                ErrorPhoneNumber.Visible = false;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidPassword = Regex.IsMatch(PasswordTxt.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (string.IsNullOrEmpty(PasswordTxt.Text))
            {
                isRequired(ErrorPassword);
            }
            else if (!isValidPassword)
            {
                isValid(ErrorPassword, "Please Enter Strong Password");
            }
            else
                ErrorPassword.Visible = false;
        }

        private void ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPasswordTxt.Text))
            {
                isRequired(ErrorConfirmPassword);
            }
            else if (ConfirmPasswordTxt.Text != PasswordTxt.Text)
            {
                isValid(ErrorConfirmPassword, "Password and Confirm Password Not Match!");
            }
            else
                ErrorConfirmPassword.Visible = false;
        }

        private void CreateCustomerbtn_Click(object sender, EventArgs e)
        {
            bool isInValidData = pageRegister.Controls.OfType<TextBox>().Any(e => e.Text == "");
            bool allLabelsNotVisible = pageRegister.Controls.OfType<Label>().All(label => !label.Visible);
            if (allLabelsNotVisible && !isInValidData)
            {
                AddCustomerDto addCustomer = new AddCustomerDto
                {
                    Email = EmailTxt.Text,
                    Name = FullNameTxt.Text,
                    Password = PasswordTxt.Text,
                    PhoneNumber = PhoneNumberTxt.Text
                };
                //send this dto to service to add it;
                User customer = mapper.Map<User>(addCustomer);
                customer = userService.UserRegister(customer);
                if (customer is not null)
                {
                    MessageBox.Show("Welcome To E-Commerce", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WhenUserLoginOrRegister(customer.Name);
                    SelectHomePage();
                    foreach (TextBox textBox in pageRegister.Controls.OfType<TextBox>())
                    {
                        textBox.Text = "";
                    }
                    foreach (Label label in pageRegister.Controls.OfType<Label>())
                    {
                        label.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("This Email is Already Exist!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Complete Data!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (btnRegister.Text == "Register")
                Orders.SelectedTab = pageRegister;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "LogOut")
                WhenUserLogOut();
            else
                Orders.SelectedTab = pageLogin;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectHomePage();
        }
        private void SelectHomePage()
        {
            Orders.SelectedTab = pageHome;
        }

        private void WhenUserLoginOrRegister(string FullName)
        {
            btnLogin.Text = "LogOut";
            btnRegister.Text = FullName;
        }

        private void WhenUserLogOut()
        {
            btnLogin.Text = "Login";
            btnRegister.Text = "Register";
            Program.userAuthentication = false;
        }

        private void btnECommerce_Click(object sender, EventArgs e)
        {
            SelectHomePage();
        }

        private void EmailTxt2_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(EmailTxt2.Text))
            {
                isRequired(ErrorEmail1);
            }
            else
                ErrorEmail1.Visible = false;
        }

        private void PasswordTxt2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTxt2.Text))
            {
                isRequired(ErrorPassword1);
            }
            else
                ErrorPassword1.Visible = false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool isInValidData = pageLogin.Controls.OfType<TextBox>().Any(e => e.Text == "");
            bool allLabelsNotVisible = pageLogin.Controls.OfType<Label>().All(label => !label.Visible);
            if (allLabelsNotVisible && !isInValidData)
            {
                LoginDto userLogin = new LoginDto
                {
                    Email = EmailTxt2.Text,
                    Password = PasswordTxt2.Text
                };
                //send this dto to service to add it;
                User user = userService.Login(userLogin.Email, userLogin.Password);
                LoginedUser = userService.GetUserById(user.ID);
                if (user is not null)
                {

                    MessageBox.Show("Welcome To E-Commerce", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (user.UserType == UserType.Admin)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        WhenUserLoginOrRegister(user.Name);
                        SelectHomePage();
                    }
                    foreach (TextBox textBox in pageLogin.Controls.OfType<TextBox>())
                    {
                        textBox.Text = "";
                    }
                    foreach (Label label in pageLogin.Controls.OfType<Label>())
                    {
                        label.Visible = false;
                    }
                    Program.userAuthentication = true;
                }
                else
                {
                    MessageBox.Show("invalid email or password !!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Complete Data!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            Orders.SelectedTab = Cart;
        }

        private void PlaceOrderCartbtn_Click(object sender, EventArgs e)
        {

            List<OrderDetails> orderProducts = new List<OrderDetails>();
            decimal totalInvoice = 0;
            int itemcount = 0;

            foreach (CartItems item in CartItemsproducts)
            {

                OrderDetails details = new OrderDetails();
                details.ProductId = item.Id;
                details.Quantity = item.Amount;
                productService.updateQuantity(item.Id, item.Amount);
                details.TotalPrice = item.ProductTotal;
                totalInvoice += item.ProductTotal;
                itemcount += 1;
                orderProducts.Add(details);
            }

            Order placeOrder = new Order()
            {
                FinalPrice = totalInvoice,
                Date = DateTime.Now,
                OrderDetails = orderProducts,
                State = OrderState.Pending,
                UserID = LoginedUser.ID
            };


            orderService.CreateOrder(placeOrder);

            foreach (var item in CartItemsproducts)
            {
                flowLayoutPanel1.Controls.Remove(item);
            }

            CartItemsproducts.Clear();
            BindProducts();
        }
    }
}
