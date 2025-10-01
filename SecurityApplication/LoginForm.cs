using Contracts;
using Contracts.Crypto;
using Microsoft.VisualBasic.ApplicationServices;
using Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityApplication
{
	public partial class LoginForm : Form
	{
		private readonly Storage.UserStorage _storage = new();
		private int _loginAttempts = 0;

		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var login = txtLogin.Text.Trim();
			var password = txtPassword.Text;
			var passwordHash = MD4Helper.ComputeHashHex(password);

			if (string.IsNullOrEmpty(login))
			{
				MessageBox.Show("Введите логин");
				return;
			}

			var user = _storage.GetElement(new UserSearchModel { Login = login, Password = passwordHash });
			if (user == null)
			{
				_loginAttempts++;
				MessageBox.Show("Неверный логин или пароль");
				if (_loginAttempts >= 3)
				{
					MessageBox.Show("Превышено число попыток входа. Программа завершает работу.",
						"Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					Application.Exit();
				}
				return;
			}

			if (user.PasswordLifetimeMonths > 0)
			{
				var expiryDate = user.LastPasswordChange.AddMonths(user.PasswordLifetimeMonths);
				if (DateTime.UtcNow > expiryDate)
				{
					var form = new ForcePasswordChangeForm(user);
					form.Show();
					this.Hide();
					return;
				}
			}

			if (user.isBlocked)
			{
				MessageBox.Show("Учётная запись заблокирована");
				return;
			}
			if (user.isAdmin)
			{
				var adminForm = new AdminForm(user);
				adminForm.FormClosed += (s, ea) => this.Show();
				adminForm.Show();
				this.Hide();
			}
			else
			{
				var userForm = new UserForm(user);
				userForm.FormClosed += (s, ea) => this.Show();
				userForm.Show();
				this.Hide();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var readmeForm = new ReadmeForm();
			readmeForm.FormClosed += (s, ea) => this.Show();
			readmeForm.Show();
			this.Hide();
		}
	}
}
