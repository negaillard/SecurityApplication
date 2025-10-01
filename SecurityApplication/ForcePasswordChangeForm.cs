using Contracts;
using Contracts.Crypto;
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
using static System.Net.Mime.MediaTypeNames;

namespace SecurityApplication
{
	public partial class ForcePasswordChangeForm : Form
	{
		private UserViewModel _user;
		private readonly Storage.UserStorage _storage = new();

		public ForcePasswordChangeForm(UserViewModel user)
		{
			_user = user;
			InitializeComponent();	
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			var new1 = txtNew1.Text;
			var new2 = txtNew2.Text;

			if (new1 != new2)
			{
				MessageBox.Show("Пароли не совпадают!");
				return;
			}

			if (_user.isPasswordDifficult)
			{
				if (!PasswordValidator.IsValid(new1, _user.PasswordMinLength))
				{
					MessageBox.Show("Пароль не соответствует требованиям политики!");
					return;
				}
			}

			var newHash = MD4Helper.ComputeHashHex(new1);

			var updated = _storage.Update(new UserBindingModel
			{
				Id = _user.Id,
				Login = _user.Login,
				Password = newHash,
				isAdmin = _user.isAdmin,
				isBlocked = _user.isBlocked,
				PasswordLifetimeMonths = _user.PasswordLifetimeMonths,
				LastPasswordChange = DateTime.UtcNow
			});

			if (updated != null)
			{
				MessageBox.Show("Пароль успешно обновлен!");

				var form = new UserForm(updated);
				form.Show();
				this.Close();
			}
		}
	}
}
