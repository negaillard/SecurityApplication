namespace Contracts
{
	public class UserSearchModel
	{
		public string? Id { get; set; }
		public string? Login { get; set; }
		public string? Password { get; set; }
		public bool? isAdmin { get; set; }

		public bool? isBlocked { get; set; }
		public bool? isPasswordDifficult { get; set; }
		public int? PasswordMinLength { get; set; }
	}
}
