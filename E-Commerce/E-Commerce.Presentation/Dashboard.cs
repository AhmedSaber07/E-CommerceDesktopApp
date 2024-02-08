using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Enums;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}