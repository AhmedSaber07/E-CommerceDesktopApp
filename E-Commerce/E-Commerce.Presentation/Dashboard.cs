using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Enums;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Commerce.Presentation
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            BindOrders();
        }
        private List<DisplayOrderDto> GetOrders()
        {
            return new List<DisplayOrderDto>
            {
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Confirmed},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
                new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending}
            };
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

        private void BindOrders()
        {
            var orders = GetOrders();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Order State";
            comboBoxColumn.DataPropertyName = "OrderState";
            comboBoxColumn.DataSource = Enum.GetValues(typeof(OrderState));
            // comboBoxColumn.ReadOnly = false;
            foreach (DataGridViewColumn column in dgrViewOrders.Columns)
            {
                if (column != dgrViewOrders.Columns[3])
                    column.ReadOnly = true;
            }
            dgrViewOrders.Columns.Add(comboBoxColumn);

            dgrViewOrders.DataSource = orders;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = OrdersPage;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ProductsPage;
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = CategoriesPage;
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddAdminPage;
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

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            bool isInValidData = AddAdminPage.Controls.OfType<TextBox>().Any(e => e.Text == "");
            bool allLabelsNotVisible = AddAdminPage.Controls.OfType<Label>().All(label => !label.Visible);
            if (allLabelsNotVisible && !isInValidData)
            {
                AddAdminDto addAdmin = new AddAdminDto
                {
                    Email = EmailTxt.Text,
                    Name = FullNameTxt.Text,
                    Password = PasswordTxt.Text,
                    PhoneNumber = PasswordTxt.Text
                };
                //send this dto to service to add it;
                MessageBox.Show("Admin Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (TextBox textBox in AddAdminPage.Controls.OfType<TextBox>())
                {
                    textBox.Text = "";
                }
                foreach (Label label in AddAdminPage.Controls.OfType<Label>())
                {
                    label.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Complete Data!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}