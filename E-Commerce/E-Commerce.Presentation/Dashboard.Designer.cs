namespace E_Commerce.Presentation
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
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
            FullName = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AddAdminPage = new TabPage();
            btnAddAdmin = new Button();
            ErrorConfirmPassword = new Label();
            ConfirmPasswordTxt = new TextBox();
            ErrorPassword = new Label();
            PasswordTxt = new TextBox();
            ErrorPhoneNumber = new Label();
            PhoneNumberTxt = new TextBox();
            ErrorEmail = new Label();
            EmailTxt = new TextBox();
            ErrorFullName = new Label();
            FullNameTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).BeginInit();
            AddAdminPage.SuspendLayout();
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
            AddAdminBtn.Click += AddAdminBtn_Click;
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
            dgrViewOrders.Columns.AddRange(new DataGridViewColumn[] { FullName, FinalPrice, Date, Email });
            dgrViewOrders.Dock = DockStyle.Fill;
            dgrViewOrders.Location = new Point(3, 3);
            dgrViewOrders.Name = "dgrViewOrders";
            dgrViewOrders.RowTemplate.Height = 25;
            dgrViewOrders.Size = new Size(701, 475);
            dgrViewOrders.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 10;
            FullName.Name = "FullName";
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
            AddAdminPage.Controls.Add(btnAddAdmin);
            AddAdminPage.Controls.Add(ErrorConfirmPassword);
            AddAdminPage.Controls.Add(ConfirmPasswordTxt);
            AddAdminPage.Controls.Add(ErrorPassword);
            AddAdminPage.Controls.Add(PasswordTxt);
            AddAdminPage.Controls.Add(ErrorPhoneNumber);
            AddAdminPage.Controls.Add(PhoneNumberTxt);
            AddAdminPage.Controls.Add(ErrorEmail);
            AddAdminPage.Controls.Add(EmailTxt);
            AddAdminPage.Controls.Add(ErrorFullName);
            AddAdminPage.Controls.Add(FullNameTxt);
            AddAdminPage.Location = new Point(4, 4);
            AddAdminPage.Name = "AddAdminPage";
            AddAdminPage.Padding = new Padding(3);
            AddAdminPage.Size = new Size(707, 481);
            AddAdminPage.TabIndex = 5;
            AddAdminPage.Text = "AddAdmin";
            AddAdminPage.UseVisualStyleBackColor = true;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.DarkGreen;
            btnAddAdmin.Cursor = Cursors.Hand;
            btnAddAdmin.FlatAppearance.BorderSize = 0;
            btnAddAdmin.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(217, 417);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(280, 41);
            btnAddAdmin.TabIndex = 10;
            btnAddAdmin.Text = "Create";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // ErrorConfirmPassword
            // 
            ErrorConfirmPassword.AutoSize = true;
            ErrorConfirmPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorConfirmPassword.ForeColor = Color.Red;
            ErrorConfirmPassword.Location = new Point(214, 373);
            ErrorConfirmPassword.Name = "ErrorConfirmPassword";
            ErrorConfirmPassword.Size = new Size(43, 17);
            ErrorConfirmPassword.TabIndex = 9;
            ErrorConfirmPassword.Text = "label3";
            ErrorConfirmPassword.Visible = false;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(214, 328);
            ConfirmPasswordTxt.Multiline = true;
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.PasswordChar = '*';
            ConfirmPasswordTxt.PlaceholderText = "Enter Confirm Password";
            ConfirmPasswordTxt.Size = new Size(283, 32);
            ConfirmPasswordTxt.TabIndex = 8;
            ConfirmPasswordTxt.TextChanged += ConfirmPasswordTxt_TextChanged;
            // 
            // ErrorPassword
            // 
            ErrorPassword.AutoSize = true;
            ErrorPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorPassword.ForeColor = Color.Red;
            ErrorPassword.Location = new Point(214, 302);
            ErrorPassword.Name = "ErrorPassword";
            ErrorPassword.Size = new Size(43, 17);
            ErrorPassword.TabIndex = 7;
            ErrorPassword.Text = "label3";
            ErrorPassword.Visible = false;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(214, 257);
            PasswordTxt.Multiline = true;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "Enter Password";
            PasswordTxt.Size = new Size(283, 32);
            PasswordTxt.TabIndex = 6;
            PasswordTxt.TextChanged += PasswordTxt_TextChanged;
            // 
            // ErrorPhoneNumber
            // 
            ErrorPhoneNumber.AutoSize = true;
            ErrorPhoneNumber.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorPhoneNumber.ForeColor = Color.Red;
            ErrorPhoneNumber.Location = new Point(214, 228);
            ErrorPhoneNumber.Name = "ErrorPhoneNumber";
            ErrorPhoneNumber.Size = new Size(43, 17);
            ErrorPhoneNumber.TabIndex = 5;
            ErrorPhoneNumber.Text = "label2";
            ErrorPhoneNumber.Visible = false;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberTxt.Location = new Point(214, 183);
            PhoneNumberTxt.Multiline = true;
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.PlaceholderText = "Enter Phone Number";
            PhoneNumberTxt.Size = new Size(283, 32);
            PhoneNumberTxt.TabIndex = 4;
            PhoneNumberTxt.TextChanged += PhoneNumberTxt_TextChanged;
            // 
            // ErrorEmail
            // 
            ErrorEmail.AutoSize = true;
            ErrorEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorEmail.ForeColor = Color.Red;
            ErrorEmail.Location = new Point(214, 149);
            ErrorEmail.Name = "ErrorEmail";
            ErrorEmail.Size = new Size(43, 17);
            ErrorEmail.TabIndex = 3;
            ErrorEmail.Text = "label2";
            ErrorEmail.Visible = false;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmailTxt.Location = new Point(214, 104);
            EmailTxt.Multiline = true;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Enter Email";
            EmailTxt.Size = new Size(283, 32);
            EmailTxt.TabIndex = 2;
            EmailTxt.TextChanged += EmailTxt_TextChanged;
            // 
            // ErrorFullName
            // 
            ErrorFullName.AutoSize = true;
            ErrorFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorFullName.ForeColor = Color.Red;
            ErrorFullName.Location = new Point(214, 68);
            ErrorFullName.Name = "ErrorFullName";
            ErrorFullName.Size = new Size(43, 17);
            ErrorFullName.TabIndex = 1;
            ErrorFullName.Text = "label2";
            ErrorFullName.Visible = false;
            // 
            // FullNameTxt
            // 
            FullNameTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameTxt.Location = new Point(214, 23);
            FullNameTxt.Multiline = true;
            FullNameTxt.Name = "FullNameTxt";
            FullNameTxt.PlaceholderText = "Enter Full Name";
            FullNameTxt.Size = new Size(283, 32);
            FullNameTxt.TabIndex = 0;
            FullNameTxt.TextChanged += FullNameTxt_TextChanged;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 509);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).EndInit();
            AddAdminPage.ResumeLayout(false);
            AddAdminPage.PerformLayout();
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
        private Label ErrorFullName;
        private TextBox FullNameTxt;
        private Label ErrorConfirmPassword;
        private TextBox ConfirmPasswordTxt;
        private Label ErrorPassword;
        private TextBox PasswordTxt;
        private Label ErrorPhoneNumber;
        private TextBox PhoneNumberTxt;
        private Label ErrorEmail;
        private TextBox EmailTxt;
        private Button btnAddAdmin;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn FinalPrice;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Email;
    }
}