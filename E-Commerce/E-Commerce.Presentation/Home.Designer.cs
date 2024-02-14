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
			CreateCustomerbtn = new Button();
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
			pageLogin = new TabPage();
			LoginBtn = new Button();
			ErrorPassword1 = new Label();
			PasswordTxt2 = new TextBox();
			ErrorEmail1 = new Label();
			EmailTxt2 = new TextBox();
			pageHome = new TabPage();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			pageRegister.SuspendLayout();
			pageLogin.SuspendLayout();
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
			comboxCategory.Location = new Point(223, 3);
			comboxCategory.Name = "comboxCategory";
			comboxCategory.Size = new Size(122, 33);
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
			btnRegister.Location = new Point(709, 0);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(155, 39);
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
			tabControl1.Size = new Size(956, 520);
			tabControl1.TabIndex = 1;
			// 
			// pageRegister
			// 
			pageRegister.Controls.Add(CreateCustomerbtn);
			pageRegister.Controls.Add(ErrorConfirmPassword);
			pageRegister.Controls.Add(ConfirmPasswordTxt);
			pageRegister.Controls.Add(ErrorPassword);
			pageRegister.Controls.Add(PasswordTxt);
			pageRegister.Controls.Add(ErrorPhoneNumber);
			pageRegister.Controls.Add(PhoneNumberTxt);
			pageRegister.Controls.Add(ErrorEmail);
			pageRegister.Controls.Add(EmailTxt);
			pageRegister.Controls.Add(ErrorFullName);
			pageRegister.Controls.Add(FullNameTxt);
			pageRegister.Location = new Point(4, 4);
			pageRegister.Name = "pageRegister";
			pageRegister.Padding = new Padding(3);
			pageRegister.Size = new Size(948, 492);
			pageRegister.TabIndex = 0;
			pageRegister.Text = "Register";
			pageRegister.UseVisualStyleBackColor = true;
			// 
			// CreateCustomerbtn
			// 
			CreateCustomerbtn.BackColor = Color.FromArgb(0, 192, 0);
			CreateCustomerbtn.FlatAppearance.BorderSize = 0;
			CreateCustomerbtn.FlatStyle = FlatStyle.Flat;
			CreateCustomerbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			CreateCustomerbtn.ForeColor = Color.White;
			CreateCustomerbtn.Location = new Point(331, 446);
			CreateCustomerbtn.Name = "CreateCustomerbtn";
			CreateCustomerbtn.Size = new Size(292, 34);
			CreateCustomerbtn.TabIndex = 32;
			CreateCustomerbtn.Text = "Register";
			CreateCustomerbtn.UseVisualStyleBackColor = false;
			CreateCustomerbtn.Click += CreateCustomerbtn_Click;
			// 
			// ErrorConfirmPassword
			// 
			ErrorConfirmPassword.AutoSize = true;
			ErrorConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorConfirmPassword.ForeColor = Color.Red;
			ErrorConfirmPassword.Location = new Point(333, 411);
			ErrorConfirmPassword.Name = "ErrorConfirmPassword";
			ErrorConfirmPassword.Size = new Size(54, 21);
			ErrorConfirmPassword.TabIndex = 31;
			ErrorConfirmPassword.Text = "label5";
			ErrorConfirmPassword.Visible = false;
			// 
			// ConfirmPasswordTxt
			// 
			ConfirmPasswordTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			ConfirmPasswordTxt.Location = new Point(333, 360);
			ConfirmPasswordTxt.Multiline = true;
			ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
			ConfirmPasswordTxt.PasswordChar = '*';
			ConfirmPasswordTxt.PlaceholderText = "Enter Confirm Password";
			ConfirmPasswordTxt.Size = new Size(290, 39);
			ConfirmPasswordTxt.TabIndex = 30;
			ConfirmPasswordTxt.TextChanged += ConfirmPasswordTxt_TextChanged;
			// 
			// ErrorPassword
			// 
			ErrorPassword.AutoSize = true;
			ErrorPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorPassword.ForeColor = Color.Red;
			ErrorPassword.Location = new Point(333, 325);
			ErrorPassword.Name = "ErrorPassword";
			ErrorPassword.Size = new Size(54, 21);
			ErrorPassword.TabIndex = 29;
			ErrorPassword.Text = "label5";
			ErrorPassword.Visible = false;
			// 
			// PasswordTxt
			// 
			PasswordTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			PasswordTxt.Location = new Point(333, 274);
			PasswordTxt.Multiline = true;
			PasswordTxt.Name = "PasswordTxt";
			PasswordTxt.PasswordChar = '*';
			PasswordTxt.PlaceholderText = "Enter Password";
			PasswordTxt.Size = new Size(290, 39);
			PasswordTxt.TabIndex = 28;
			PasswordTxt.TextChanged += PasswordTxt_TextChanged;
			// 
			// ErrorPhoneNumber
			// 
			ErrorPhoneNumber.AutoSize = true;
			ErrorPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorPhoneNumber.ForeColor = Color.Red;
			ErrorPhoneNumber.Location = new Point(333, 239);
			ErrorPhoneNumber.Name = "ErrorPhoneNumber";
			ErrorPhoneNumber.Size = new Size(54, 21);
			ErrorPhoneNumber.TabIndex = 27;
			ErrorPhoneNumber.Text = "label5";
			ErrorPhoneNumber.Visible = false;
			// 
			// PhoneNumberTxt
			// 
			PhoneNumberTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			PhoneNumberTxt.Location = new Point(333, 188);
			PhoneNumberTxt.Multiline = true;
			PhoneNumberTxt.Name = "PhoneNumberTxt";
			PhoneNumberTxt.PlaceholderText = "Enter Phone Number";
			PhoneNumberTxt.Size = new Size(290, 39);
			PhoneNumberTxt.TabIndex = 26;
			PhoneNumberTxt.TextChanged += PhoneNumberTxt_TextChanged;
			// 
			// ErrorEmail
			// 
			ErrorEmail.AutoSize = true;
			ErrorEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorEmail.ForeColor = Color.Red;
			ErrorEmail.Location = new Point(333, 147);
			ErrorEmail.Name = "ErrorEmail";
			ErrorEmail.Size = new Size(54, 21);
			ErrorEmail.TabIndex = 25;
			ErrorEmail.Text = "label5";
			ErrorEmail.Visible = false;
			// 
			// EmailTxt
			// 
			EmailTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			EmailTxt.Location = new Point(333, 96);
			EmailTxt.Multiline = true;
			EmailTxt.Name = "EmailTxt";
			EmailTxt.PlaceholderText = "Enter Email Address";
			EmailTxt.Size = new Size(290, 39);
			EmailTxt.TabIndex = 24;
			EmailTxt.TextChanged += EmailTxt_TextChanged;
			// 
			// ErrorFullName
			// 
			ErrorFullName.AutoSize = true;
			ErrorFullName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorFullName.ForeColor = Color.Red;
			ErrorFullName.Location = new Point(333, 72);
			ErrorFullName.Name = "ErrorFullName";
			ErrorFullName.Size = new Size(54, 21);
			ErrorFullName.TabIndex = 23;
			ErrorFullName.Text = "label5";
			ErrorFullName.Visible = false;
			// 
			// FullNameTxt
			// 
			FullNameTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			FullNameTxt.Location = new Point(333, 21);
			FullNameTxt.Multiline = true;
			FullNameTxt.Name = "FullNameTxt";
			FullNameTxt.PlaceholderText = "Enter Full Name";
			FullNameTxt.Size = new Size(290, 39);
			FullNameTxt.TabIndex = 22;
			FullNameTxt.TextChanged += FullNameTxt_TextChanged;
			// 
			// pageLogin
			// 
			pageLogin.Controls.Add(LoginBtn);
			pageLogin.Controls.Add(ErrorPassword1);
			pageLogin.Controls.Add(PasswordTxt2);
			pageLogin.Controls.Add(ErrorEmail1);
			pageLogin.Controls.Add(EmailTxt2);
			pageLogin.Location = new Point(4, 4);
			pageLogin.Name = "pageLogin";
			pageLogin.Padding = new Padding(3);
			pageLogin.Size = new Size(948, 492);
			pageLogin.TabIndex = 1;
			pageLogin.Text = "Login";
			pageLogin.UseVisualStyleBackColor = true;
			// 
			// LoginBtn
			// 
			LoginBtn.BackColor = SystemColors.Highlight;
			LoginBtn.FlatAppearance.BorderSize = 0;
			LoginBtn.FlatStyle = FlatStyle.Flat;
			LoginBtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			LoginBtn.ForeColor = Color.White;
			LoginBtn.Location = new Point(349, 286);
			LoginBtn.Name = "LoginBtn";
			LoginBtn.Size = new Size(292, 34);
			LoginBtn.TabIndex = 33;
			LoginBtn.Text = "Login";
			LoginBtn.UseVisualStyleBackColor = false;
			LoginBtn.Click += LoginBtn_Click;
			// 
			// ErrorPassword1
			// 
			ErrorPassword1.AutoSize = true;
			ErrorPassword1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorPassword1.ForeColor = Color.Red;
			ErrorPassword1.Location = new Point(349, 239);
			ErrorPassword1.Name = "ErrorPassword1";
			ErrorPassword1.Size = new Size(54, 21);
			ErrorPassword1.TabIndex = 31;
			ErrorPassword1.Text = "label5";
			ErrorPassword1.Visible = false;
			// 
			// PasswordTxt2
			// 
			PasswordTxt2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			PasswordTxt2.Location = new Point(349, 188);
			PasswordTxt2.Multiline = true;
			PasswordTxt2.Name = "PasswordTxt2";
			PasswordTxt2.PasswordChar = '*';
			PasswordTxt2.PlaceholderText = "Enter Password";
			PasswordTxt2.Size = new Size(290, 39);
			PasswordTxt2.TabIndex = 30;
			PasswordTxt2.TextChanged += PasswordTxt2_TextChanged;
			// 
			// ErrorEmail1
			// 
			ErrorEmail1.AutoSize = true;
			ErrorEmail1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ErrorEmail1.ForeColor = Color.Red;
			ErrorEmail1.Location = new Point(349, 147);
			ErrorEmail1.Name = "ErrorEmail1";
			ErrorEmail1.Size = new Size(54, 21);
			ErrorEmail1.TabIndex = 27;
			ErrorEmail1.Text = "label5";
			ErrorEmail1.Visible = false;
			// 
			// EmailTxt2
			// 
			EmailTxt2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			EmailTxt2.Location = new Point(349, 96);
			EmailTxt2.Multiline = true;
			EmailTxt2.Name = "EmailTxt2";
			EmailTxt2.PlaceholderText = "Enter Email Address";
			EmailTxt2.Size = new Size(290, 39);
			EmailTxt2.TabIndex = 26;
			EmailTxt2.TextChanged += EmailTxt2_TextChanged;
			// 
			// pageHome
			// 
			pageHome.Location = new Point(4, 4);
			pageHome.Name = "pageHome";
			pageHome.Padding = new Padding(3);
			pageHome.Size = new Size(948, 492);
			pageHome.TabIndex = 2;
			pageHome.Text = "Home";
			pageHome.UseVisualStyleBackColor = true;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(956, 559);
			Controls.Add(tabControl1);
			Controls.Add(panel1);
			ForeColor = Color.White;
			Name = "Home";
			Text = "Home";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tabControl1.ResumeLayout(false);
			pageRegister.ResumeLayout(false);
			pageRegister.PerformLayout();
			pageLogin.ResumeLayout(false);
			pageLogin.PerformLayout();
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
		private Button CreateCustomerbtn;
		private Label ErrorConfirmPassword;
		private TextBox ConfirmPasswordTxt;
		private Label ErrorPassword;
		private TextBox PasswordTxt;
		private Label ErrorPhoneNumber;
		private TextBox PhoneNumberTxt;
		private Label ErrorEmail;
		private TextBox EmailTxt;
		private Label ErrorFullName;
		private TextBox FullNameTxt;
		private Label ErrorPassword1;
		private TextBox PasswordTxt2;
		private Label ErrorEmail1;
		private TextBox EmailTxt2;
		private Button LoginBtn;
	}
}