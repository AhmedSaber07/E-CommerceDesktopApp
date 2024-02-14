using AutoMapper;
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
	public partial class Home : Form
	{
		IMapper mapper = Mapping.MappingAddCustomer();
		UserService userService = new UserService(new UserRepository(new ApplicationDbContext()));
		CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
		public Home()
		{
			InitializeComponent();
			SelectHomePage();
			BindCategories();
		}
		private void BindCategories()
		{
			var categories = categoryService.GetCategories().ToList();

			comboxCategory.DataSource = categories;
			comboxCategory.DisplayMember = "Name";
			comboxCategory.ValueMember = "ID";
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
				tabControl1.SelectedTab = pageRegister;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (btnLogin.Text == "LogOut")
				WhenUserLogOut();
			else
				tabControl1.SelectedTab = pageLogin;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			SelectHomePage();
		}
		private void SelectHomePage()
		{
			tabControl1.SelectedTab = pageHome;
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
	}
}
