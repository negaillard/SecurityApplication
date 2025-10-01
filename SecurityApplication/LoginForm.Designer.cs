namespace SecurityApplication
{
	partial class LoginForm
	{
		private System.ComponentModel.IContainer components = null;
		private TextBox txtLogin;
		private TextBox txtPassword;
		private Button btnLogin;
		private Label label1;
		private Label label2;

		private void InitializeComponent()
		{
			txtLogin = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// txtLogin
			// 
			txtLogin.Location = new Point(110, 12);
			txtLogin.Name = "txtLogin";
			txtLogin.Size = new Size(200, 27);
			txtLogin.TabIndex = 1;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(110, 47);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(200, 27);
			txtPassword.TabIndex = 3;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(235, 104);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 32);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Войти";
			btnLogin.Click += btnLogin_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(55, 20);
			label1.TabIndex = 0;
			label1.Text = "Логин:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 50);
			label2.Name = "label2";
			label2.Size = new Size(65, 20);
			label2.TabIndex = 2;
			label2.Text = "Пароль:";
			// 
			// button1
			// 
			button1.Location = new Point(12, 107);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 5;
			button1.Text = "Справка";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// LoginForm
			// 
			ClientSize = new Size(330, 148);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(txtLogin);
			Controls.Add(label2);
			Controls.Add(txtPassword);
			Controls.Add(btnLogin);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Вход";
			ResumeLayout(false);
			PerformLayout();
		}
		private Button button1;
	}
}