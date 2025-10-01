using Contracts;
using Contracts.Crypto;
using System.Data;

namespace SecurityApplication
{
	public partial class AdminForm : Form
	{
		private readonly Storage.UserStorage _storage = new();
		private readonly UserViewModel _adminUser;
		private List<UserViewModel> _users = new();
		private int _currentIndex = 0;

		public AdminForm(UserViewModel adminUser)
		{
			_adminUser = adminUser;
			InitializeComponent();
			LoadUsers();
		}

		private void LoadUsers()
		{
			_users = _storage.GetFullList();
			dataGridViewUsers.DataSource = null;
			dataGridViewUsers.DataSource = _users.Select(u => new
			{
				u.Id,
				u.Login,
				u.isAdmin,
				u.isBlocked,
				u.isPasswordDifficult,
				u.PasswordLifetimeMonths
			}).ToList();

		}

		private void DataGridViewUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridViewUsers.DataBindingComplete -= DataGridViewUsers_DataBindingComplete;
			UpdateSelection();
		}

		private void UpdateSelection()
		{
			if (_users.Count == 0)
			{
				lblSelected.Text = "Пользователей нет";
				return;
			}
			if (_currentIndex < 0) _currentIndex = 0;
			if (_currentIndex >= _users.Count) _currentIndex = _users.Count - 1;
			var cur = _users[_currentIndex];
			lblSelected.Text = $"{_currentIndex + 1}/{_users.Count} - {cur.Login}";

			// highlight in grid
			if (dataGridViewUsers.Rows.Count > 0)
			{
				foreach (DataGridViewRow r in dataGridViewUsers.Rows)
				{
					if (r.Cells["Id"].Value?.ToString() == cur.Id)
					{
						r.Selected = true;
						dataGridViewUsers.FirstDisplayedScrollingRowIndex = r.Index;
						break;
					}
				}
			}
		}

		private void btnFirst_Click(object sender, EventArgs e) { _currentIndex = 0; UpdateSelection(); }
		private void btnPrev_Click(object sender, EventArgs e) { _currentIndex = Math.Max(0, _currentIndex - 1); UpdateSelection(); }
		private void btnNext_Click(object sender, EventArgs e) { _currentIndex = Math.Min(_users.Count - 1, _currentIndex + 1); UpdateSelection(); }
		private void btnLast_Click(object sender, EventArgs e) { _currentIndex = Math.Max(0, _users.Count - 1); UpdateSelection(); }

		private void btnRefresh_Click(object sender, EventArgs e) => LoadUsers();

		private void btnChangeAdminPassword_Click(object sender, EventArgs e)
		{
			var oldp = txtAdminOld.Text;
			var hashedOldp = MD4Helper.ComputeHashHex(oldp);

			var newp1 = txtAdminNew1.Text;
			var newp2 = txtAdminNew2.Text;

			if (string.IsNullOrEmpty(newp1))
			{
				MessageBox.Show("Заполните все поля");
				return;
			}

			// проверяем старый пароль
			var cur = _storage.GetElementWithPassword(new UserSearchModel { Login = _adminUser.Login, Password = hashedOldp });
			if (cur == null)
			{
				MessageBox.Show("Старый пароль неверен");
				return;
			}

			if (newp1 != newp2)
			{
				MessageBox.Show("Новые пароли не совпадают");
				return;
			}
			var hashedNewp = MD4Helper.ComputeHashHex(newp1);
			// обновляем в хранилище
			var binding = new UserBindingModel
			{
				Id = _adminUser.Id,
				Login = _adminUser.Login,
				Password = hashedNewp,
				isAdmin = true,
				isBlocked = _adminUser.isBlocked,
				isPasswordDifficult = _adminUser.isPasswordDifficult,
				PasswordMinLength = _adminUser.PasswordMinLength,
				PasswordLifetimeMonths = _adminUser.PasswordLifetimeMonths,
				LastPasswordChange = DateTime.UtcNow,
			};
			var updated = _storage.Update(binding);
			if (updated != null)
			{
				MessageBox.Show("Пароль администратора изменён");
				// обновим локальную копию
				_adminUser.Password = hashedNewp;
				_adminUser.LastPasswordChange = binding.LastPasswordChange;
			}
			else
			{
				MessageBox.Show("Ошибка обновления");
			}
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			var name = txtNewUserLogin.Text.Trim();
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("Введите логин нового пользователя");
				return;
			}

			// уникальность
			var exists = _storage.GetElement(new UserSearchModel { Login = name });
			if (exists != null)
			{
				MessageBox.Show("Такой логин уже существует");
				return;
			}
			bool isPasswdDiff = chkPasswdDiff.Checked;
			var inserted = _storage.Insert(new UserBindingModel
			{
				Login = name,
				Password = MD4Helper.ComputeHashHex(string.Empty), // пустой пароль длины 0
				isAdmin = false,
				isBlocked = false,
				isPasswordDifficult = isPasswdDiff,
				PasswordMinLength = (int)numDefaultMinLen.Value,
				PasswordLifetimeMonths =(int)numDefaultPwdDays.Value,
				LastPasswordChange = DateTime.UtcNow
			});

			if (inserted != null)
			{
				LoadUsers();
				MessageBox.Show("Пользователь добавлен (пароль пустой)");
				txtNewUserLogin.Clear();
			}
			else
			{
				MessageBox.Show("Ошибка при добавлении");
			}
		}

		private void btnBlockUnblock_Click(object sender, EventArgs e)
		{
			if (_users.Count == 0) return;
			var cur = _users[_currentIndex];
			cur.isBlocked = !cur.isBlocked;
			var bind = new UserBindingModel
			{
				Id = cur.Id,
				Login = cur.Login,
				Password = cur.Password,
				isAdmin = cur.isAdmin,
				isBlocked = cur.isBlocked,
				PasswordLifetimeMonths = cur.PasswordLifetimeMonths,
				LastPasswordChange = cur.LastPasswordChange,
			};
			var updated = _storage.Update(bind);
			if (updated != null)
			{
				LoadUsers();
			}
			else MessageBox.Show("Ошибка обновления блокировки");
		}

		private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewUsers.SelectedRows.Count == 0) return;
			var id = dataGridViewUsers.SelectedRows[0].Cells["Id"].Value?.ToString();
			var idx = _users.FindIndex(x => x.Id == id);
			if (idx >= 0)
			{
				_currentIndex = idx;
				UpdateSelection();
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if (_users.Count == 0) return;
			var cur = _users[_currentIndex];
			var confirm = MessageBox.Show($"Удалить пользователя {cur.Login}?", "Подтверждение", MessageBoxButtons.YesNo);
			if (confirm == DialogResult.Yes)
			{
				var deleted = _storage.Delete(new UserBindingModel { Id = cur.Id });
				if (deleted != null)
				{
					LoadUsers();
				}
				else MessageBox.Show("Ошибка удаления");
			}
		}
	}
}


