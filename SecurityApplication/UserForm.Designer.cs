namespace SecurityApplication
{
	partial class UserForm
	{
		private System.ComponentModel.IContainer components = null;
		private Label lblWelcome;
		private Label lblOld, lblNew1, lblNew2;
		private TextBox txtOld, txtNew1, txtNew2;
		private Button btnChangePassword;

		private void InitializeComponent()
		{
			lblWelcome = new Label();
			lblOld = new Label();
			lblNew1 = new Label();
			lblNew2 = new Label();
			txtOld = new TextBox();
			txtNew1 = new TextBox();
			txtNew2 = new TextBox();
			btnChangePassword = new Button();
			SuspendLayout();
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Location = new Point(12, 9);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(163, 20);
			lblWelcome.TabIndex = 0;
			lblWelcome.Text = "Привет, пользователь";
			// 
			// lblOld
			// 
			lblOld.AutoSize = true;
			lblOld.Location = new Point(12, 40);
			lblOld.Name = "lblOld";
			lblOld.Size = new Size(119, 20);
			lblOld.TabIndex = 1;
			lblOld.Text = "Старый пароль:";
			// 
			// lblNew1
			// 
			lblNew1.AutoSize = true;
			lblNew1.Location = new Point(12, 75);
			lblNew1.Name = "lblNew1";
			lblNew1.Size = new Size(115, 20);
			lblNew1.TabIndex = 3;
			lblNew1.Text = "Новый пароль:";
			// 
			// lblNew2
			// 
			lblNew2.AutoSize = true;
			lblNew2.Location = new Point(12, 110);
			lblNew2.Name = "lblNew2";
			lblNew2.Size = new Size(137, 20);
			lblNew2.TabIndex = 5;
			lblNew2.Text = "Повторите новый:";
			// 
			// txtOld
			// 
			txtOld.Location = new Point(167, 40);
			txtOld.Name = "txtOld";
			txtOld.Size = new Size(200, 27);
			txtOld.TabIndex = 2;
			txtOld.UseSystemPasswordChar = true;
			// 
			// txtNew1
			// 
			txtNew1.Location = new Point(167, 75);
			txtNew1.Name = "txtNew1";
			txtNew1.Size = new Size(200, 27);
			txtNew1.TabIndex = 4;
			txtNew1.UseSystemPasswordChar = true;
			// 
			// txtNew2
			// 
			txtNew2.Location = new Point(167, 110);
			txtNew2.Name = "txtNew2";
			txtNew2.Size = new Size(200, 27);
			txtNew2.TabIndex = 6;
			txtNew2.UseSystemPasswordChar = true;
			// 
			// btnChangePassword
			// 
			btnChangePassword.Location = new Point(167, 148);
			btnChangePassword.Name = "btnChangePassword";
			btnChangePassword.Size = new Size(94, 30);
			btnChangePassword.TabIndex = 7;
			btnChangePassword.Text = "Сменить пароль";
			btnChangePassword.Click += btnChangePassword_Click;
			// 
			// UserForm
			// 
			ClientSize = new Size(417, 208);
			Controls.Add(lblWelcome);
			Controls.Add(lblOld);
			Controls.Add(txtOld);
			Controls.Add(lblNew1);
			Controls.Add(txtNew1);
			Controls.Add(lblNew2);
			Controls.Add(txtNew2);
			Controls.Add(btnChangePassword);
			Name = "UserForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Пользователь";
			ResumeLayout(false);
			PerformLayout();
		}
	}

}