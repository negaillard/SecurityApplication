namespace Contracts
{
	public interface IUserModel
	{
		string Id { get; }
		string Login { get; }
		string Password { get; }
		bool isAdmin { get; }
		bool isBlocked { get; }
		bool isPasswordDifficult { get; }
		int PasswordMinLength { get; }
		int PasswordLifetimeMonths { get; }
		DateTime LastPasswordChange { get; }
	}
}
