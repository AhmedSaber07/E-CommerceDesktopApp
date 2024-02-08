namespace E_Commerce.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            DashBoard = new Button();
            AddAdminBtn = new Button();
            OrderBtn = new Button();
            CategoryBtn = new Button();
            productBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pageSetupDialog1 = new PageSetupDialog();
            tabControl = new TabControl();
            HomePage = new TabPage();
            CategoriesPage = new TabPage();
            ProductsPage = new TabPage();
            OrdersPage = new TabPage();
            dgrViewOrders = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AddAdminPage = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 66, 194);
            panel1.Controls.Add(DashBoard);
            panel1.Controls.Add(AddAdminBtn);
            panel1.Controls.Add(OrderBtn);
            panel1.Controls.Add(CategoryBtn);
            panel1.Controls.Add(productBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 509);
            panel1.TabIndex = 0;
            // 
            // DashBoard
            // 
            DashBoard.BackColor = Color.FromArgb(83, 66, 194);
            DashBoard.Cursor = Cursors.Hand;
            DashBoard.FlatAppearance.BorderSize = 0;
            DashBoard.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            DashBoard.FlatStyle = FlatStyle.Flat;
            DashBoard.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DashBoard.ForeColor = Color.White;
            DashBoard.Location = new Point(12, 88);
            DashBoard.Name = "DashBoard";
            DashBoard.Size = new Size(213, 52);
            DashBoard.TabIndex = 7;
            DashBoard.Text = "Dashboard";
            DashBoard.UseVisualStyleBackColor = false;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.BackColor = Color.FromArgb(83, 66, 194);
            AddAdminBtn.Cursor = Cursors.Hand;
            AddAdminBtn.FlatAppearance.BorderSize = 0;
            AddAdminBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            AddAdminBtn.FlatStyle = FlatStyle.Flat;
            AddAdminBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddAdminBtn.ForeColor = Color.White;
            AddAdminBtn.Location = new Point(12, 420);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(213, 52);
            AddAdminBtn.TabIndex = 6;
            AddAdminBtn.Text = "Add Admin";
            AddAdminBtn.UseVisualStyleBackColor = false;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.FromArgb(83, 66, 194);
            OrderBtn.Cursor = Cursors.Hand;
            OrderBtn.FlatAppearance.BorderSize = 0;
            OrderBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            OrderBtn.FlatStyle = FlatStyle.Flat;
            OrderBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(12, 332);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(213, 52);
            OrderBtn.TabIndex = 5;
            OrderBtn.Text = "Orders";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // CategoryBtn
            // 
            CategoryBtn.BackColor = Color.FromArgb(83, 66, 194);
            CategoryBtn.Cursor = Cursors.Hand;
            CategoryBtn.FlatAppearance.BorderSize = 0;
            CategoryBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            CategoryBtn.FlatStyle = FlatStyle.Flat;
            CategoryBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryBtn.ForeColor = Color.White;
            CategoryBtn.Location = new Point(12, 167);
            CategoryBtn.Name = "CategoryBtn";
            CategoryBtn.Size = new Size(213, 52);
            CategoryBtn.TabIndex = 4;
            CategoryBtn.Text = "Categories";
            CategoryBtn.UseVisualStyleBackColor = false;
            CategoryBtn.Click += CategoryBtn_Click;
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.FromArgb(83, 66, 194);
            productBtn.Cursor = Cursors.Hand;
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(12, 246);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(213, 52);
            productBtn.TabIndex = 3;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(100, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "E-Commerce";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(HomePage);
            tabControl.Controls.Add(CategoriesPage);
            tabControl.Controls.Add(ProductsPage);
            tabControl.Controls.Add(OrdersPage);
            tabControl.Controls.Add(AddAdminPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(241, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(715, 509);
            tabControl.TabIndex = 1;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(4, 4);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3);
            HomePage.Size = new Size(707, 481);
            HomePage.TabIndex = 1;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // CategoriesPage
            // 
            CategoriesPage.Location = new Point(4, 4);
            CategoriesPage.Name = "CategoriesPage";
            CategoriesPage.Padding = new Padding(3);
            CategoriesPage.Size = new Size(707, 481);
            CategoriesPage.TabIndex = 2;
            CategoriesPage.Text = "Categories";
            CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // ProductsPage
            // 
            ProductsPage.Location = new Point(4, 4);
            ProductsPage.Name = "ProductsPage";
            ProductsPage.Padding = new Padding(3);
            ProductsPage.Size = new Size(707, 481);
            ProductsPage.TabIndex = 3;
            ProductsPage.Text = "Products";
            ProductsPage.UseVisualStyleBackColor = true;
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(dgrViewOrders);
            OrdersPage.Location = new Point(4, 4);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(707, 481);
            OrdersPage.TabIndex = 4;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // dgrViewOrders
            // 
            dgrViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrViewOrders.Columns.AddRange(new DataGridViewColumn[] { Name, FinalPrice, Date, Email });
            dgrViewOrders.Dock = DockStyle.Fill;
            dgrViewOrders.Location = new Point(3, 3);
            dgrViewOrders.Name = "dgrViewOrders";
            dgrViewOrders.RowTemplate.Height = 25;
            dgrViewOrders.Size = new Size(701, 475);
            dgrViewOrders.TabIndex = 0;
            // 
            // Name
            // 
            Name.DataPropertyName = "FullName";
            Name.HeaderText = "Full Name";
            Name.MinimumWidth = 10;
            Name.Name = "Name";
            // 
            // FinalPrice
            // 
            FinalPrice.DataPropertyName = "FinalPrice";
            FinalPrice.HeaderText = "FinalPrice";
            FinalPrice.Name = "FinalPrice";
            // 
            // Date
            // 
            Date.DataPropertyName = "OrderDate";
            Date.HeaderText = "Order Date";
            Date.Name = "Date";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // AddAdminPage
            // 
            AddAdminPage.Location = new Point(4, 4);
            AddAdminPage.Name = "AddAdminPage";
            AddAdminPage.Padding = new Padding(3);
            AddAdminPage.Size = new Size(707, 481);
            AddAdminPage.TabIndex = 5;
            AddAdminPage.Text = "AddAdmin";
            AddAdminPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 509);
            Controls.Add(tabControl);
            Controls.Add(panel1);
           // Name = "Form1";
            Text = "E-Commerce";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button productBtn;
        private Button AddAdminBtn;
        private Button OrderBtn;
        private Button CategoryBtn;
        private Button DashBoard;
        private PageSetupDialog pageSetupDialog1;
        private TabControl tabControl;
        private TabPage HomePage;
        private TabPage CategoriesPage;
        private TabPage ProductsPage;
        private TabPage OrdersPage;
        private TabPage AddAdminPage;
        private DataGridView dgrViewOrders;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn FinalPrice;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Email;
    }
}