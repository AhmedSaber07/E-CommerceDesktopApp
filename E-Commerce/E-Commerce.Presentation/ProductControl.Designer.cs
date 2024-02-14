namespace E_Commerce.Presentation
{
	partial class ProductControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			button1 = new Button();
			button2 = new Button();
			label6 = new Label();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(18, 58);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(263, 157);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(18, 13);
			label1.Name = "label1";
			label1.Size = new Size(78, 25);
			label1.TabIndex = 1;
			label1.Text = "p name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(18, 216);
			label2.Name = "label2";
			label2.Size = new Size(81, 20);
			label2.TabIndex = 2;
			label2.Text = "Category :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(18, 247);
			label3.Name = "label3";
			label3.Size = new Size(51, 20);
			label3.TabIndex = 3;
			label3.Text = "Price :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(168, 217);
			label4.Name = "label4";
			label4.Size = new Size(45, 19);
			label4.TabIndex = 4;
			label4.Text = "label4";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(78, 249);
			label5.Name = "label5";
			label5.Size = new Size(45, 19);
			label5.TabIndex = 5;
			label5.Text = "label5";
			// 
			// button1
			// 
			button1.Location = new Point(18, 280);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(60, 22);
			button1.TabIndex = 6;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(224, 280);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(57, 22);
			button2.TabIndex = 7;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(248, 249);
			label6.Name = "label6";
			label6.Size = new Size(19, 19);
			label6.TabIndex = 8;
			label6.Text = "N";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(168, 249);
			label7.Name = "label7";
			label7.Size = new Size(74, 19);
			label7.TabIndex = 9;
			label7.Text = "Quantity :";
			// 
			// ProductControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "ProductControl";
			Size = new Size(298, 312);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button button1;
		private Button button2;
		private Label label6;
		private Label label7;
	}
}
