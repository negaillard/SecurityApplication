using Contracts;
using Contracts.Crypto;

namespace SecurityApplication
{
	public partial class UserForm : Form
	{
		private readonly Storage.UserStorage _storage = new();
		private UserViewModel _user;
		// Здесь мы читаем политики из AdminForm если нужно - но поскольку политики у нас локальны в AdminForm,
		// мы не можем напрямую их достать. Делаю упрощение: при смене пароля пользователь учитывает локальные проверки:
		// если админ включил правило до того как юзер сменил пароль, это правило в текущей версии хранится в AdminForm.Memory.
		// Для рабочего прототипа — будем просто проверять минимальную длину 4.
		public UserForm(UserViewModel user)
		{
			_user = user;
			InitializeComponent();
			lblWelcome.Text = $"Привет, {_user.Login}";
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			var oldp = txtOld.Text;
			var hashedOldp = MD4Helper.ComputeHashHex(oldp);
			var gash = MD4Helper.ComputeHashHex(string.Empty);
			var new1 = txtNew1.Text;
			var new2 = txtNew2.Text;

			if (string.IsNullOrEmpty(new1))
			{
				MessageBox.Show("Заполните все поля");
				return;
			}

			var found = _storage.GetElementWithPassword(new UserSearchModel { Login = _user.Login, Password = hashedOldp });
			if (found == null)
			{
				MessageBox.Show("Старый пароль неверен");
				return;
			}
			if (found.isPasswordDifficult)
			{
				if (!PasswordValidator.IsValid(new1, found.PasswordMinLength))
				{
					MessageBox.Show("Пароль не соответствует требованиям политики!");
					return;
				}
			}
			if (new1 != new2)
			{
				MessageBox.Show("Новые пароли не совпадают");
				return;
			}
			var hashedNewp = MD4Helper.ComputeHashHex(new1);
			var bind = new UserBindingModel
			{
				Id = _user.Id,
				Login = _user.Login,
				Password = hashedNewp,
				isAdmin = _user.isAdmin,
				isBlocked = _user.isBlocked,
				PasswordLifetimeMonths = _user.PasswordLifetimeMonths,
				LastPasswordChange = DateTime.UtcNow,
			};
			var updated = _storage.Update(bind);
			if (updated != null)
			{
				MessageBox.Show("Пароль изменён");
				_user = updated;
			}
			else MessageBox.Show("Ошибка при смене пароля");
		}
	}
}
