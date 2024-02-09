namespace E_Commerce.Presentation
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtBoxSearch = new TextBox();
            comboxCategory = new ComboBox();
            btnHome = new Button();
            btnECommerce = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            tabControl1 = new TabControl();
            pageRegister = new TabPage();
            pageLogin = new TabPage();
            pageHome = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(txtBoxSearch);
            panel1.Controls.Add(comboxCategory);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnECommerce);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 39);
            panel1.TabIndex = 0;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(372, 0);
            txtBoxSearch.Multiline = true;
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.PlaceholderText = "Search";
            txtBoxSearch.Size = new Size(298, 39);
            txtBoxSearch.TabIndex = 1;
            // 
            // comboxCategory
            // 
            comboxCategory.BackColor = Color.White;
            comboxCategory.DropDownHeight = 150;
            comboxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxCategory.FlatStyle = FlatStyle.Popup;
            comboxCategory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            comboxCategory.ForeColor = Color.Black;
            comboxCategory.FormattingEnabled = true;
            comboxCategory.IntegralHeight = false;
            comboxCategory.Items.AddRange(new object[] { "Test", "Test2" });
            comboxCategory.Location = new Point(252, 3);
            comboxCategory.Name = "comboxCategory";
            comboxCategory.Size = new Size(93, 33);
            comboxCategory.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.HotTrack;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(124, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(93, 39);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnECommerce
            // 
            btnECommerce.BackColor = Color.SandyBrown;
            btnECommerce.FlatAppearance.BorderSize = 0;
            btnECommerce.FlatStyle = FlatStyle.Flat;
            btnECommerce.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnECommerce.ForeColor = Color.White;
            btnECommerce.Location = new Point(0, 0);
            btnECommerce.Name = "btnECommerce";
            btnECommerce.Size = new Size(124, 39);
            btnECommerce.TabIndex = 1;
            btnECommerce.Text = "E-Commerce";
            btnECommerce.UseVisualStyleBackColor = false;
            btnECommerce.Click += btnECommerce_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.HotTrack;
            btnRegister.Dock = DockStyle.Right;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(763, 0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(101, 39);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(864, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 39);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(pageRegister);
            tabControl1.Controls.Add(pageLogin);
            tabControl1.Controls.Add(pageHome);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(956, 411);
            tabControl1.TabIndex = 1;
            // 
            // pageRegister
            // 
            pageRegister.Location = new Point(4, 4);
            pageRegister.Name = "pageRegister";
            pageRegister.Padding = new Padding(3);
            pageRegister.Size = new Size(948, 383);
            pageRegister.TabIndex = 0;
            pageRegister.Text = "Register";
            pageRegister.UseVisualStyleBackColor = true;
            // 
            // pageLogin
            // 
            pageLogin.Location = new Point(4, 4);
            pageLogin.Name = "pageLogin";
            pageLogin.Padding = new Padding(3);
            pageLogin.Size = new Size(792, 383);
            pageLogin.TabIndex = 1;
            pageLogin.Text = "Login";
            pageLogin.UseVisualStyleBackColor = true;
            // 
            // pageHome
            // 
            pageHome.Location = new Point(4, 4);
            pageHome.Name = "pageHome";
            pageHome.Padding = new Padding(3);
            pageHome.Size = new Size(792, 383);
            pageHome.TabIndex = 2;
            pageHome.Text = "Home";
            pageHome.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnECommerce;
        private Button btnHome;
        private ComboBox comboxCategory;
        private TextBox txtBoxSearch;
        private TabControl tabControl1;
        private TabPage pageRegister;
        private TabPage pageLogin;
        private TabPage pageHome;
    }
}