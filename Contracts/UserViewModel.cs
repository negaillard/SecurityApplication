namespace Contracts
{
	public class UserViewModel : IUserModel
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public string Login { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;

		public bool isAdmin { get; set; }

		public bool isBlocked { get; set; }
		public bool isPasswordDifficult { get; set; }
		public int PasswordMinLength { get; set; }
		public int PasswordLifetimeMonths { get; set; }
		public DateTime LastPasswordChange { get; set; }
	}
}
