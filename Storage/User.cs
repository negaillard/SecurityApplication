using Contracts;
using System.Xml.Linq;

namespace Storage
{
	public class User : IUserModel
	{
		public string Id { get; private set; } = Guid.NewGuid().ToString();
		public string Login { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public bool isAdmin { get; set; }
		public bool isBlocked { get; set; }
		public bool isPasswordDifficult { get; set; }
		public int PasswordMinLength { get; set; }
		public int PasswordLifetimeMonths { get; set; }
		public DateTime LastPasswordChange { get; set; }

		public static User? Create(UserBindingModel model)
		{
			if (model == null)
			{
				return null;
			}
			return new User()
			{
				Id = model.Id,
				Login = model.Login,
				Password = model.Password,
				isAdmin = model.isAdmin,
				isBlocked = model.isBlocked,
				isPasswordDifficult = model.isPasswordDifficult,
				PasswordMinLength = model.PasswordMinLength,
				PasswordLifetimeMonths = model.PasswordLifetimeMonths,
				LastPasswordChange = model.LastPasswordChange,
			};
		}

		public static User? Create(XElement element)
		{
			if (element == null) return null;

			return new User
			{
				Id = element.Attribute("Id")?.Value ?? Guid.NewGuid().ToString(),
				Login = element.Element("Login")?.Value ?? string.Empty,
				Password = element.Element("Password")?.Value ?? string.Empty,
				isAdmin = bool.Parse(element.Element("IsAdmin")?.Value ?? "false"),
				isBlocked = bool.Parse(element.Element("IsBlocked")?.Value ?? "false"),
				isPasswordDifficult = bool.Parse(element.Element("IsPasswordDifficult")?.Value ?? "false"),
				PasswordLifetimeMonths = int.Parse(element.Element("PasswordLifetimeMonths")?.Value ?? "0"),
				LastPasswordChange = DateTime.TryParse(element.Element("LastPasswordChange")?.Value, out var dt) ? dt : DateTime.UtcNow
			};
		}

		// преобразование в XML
		public XElement GetXElement =>
			new XElement("User",
				new XAttribute("Id", Id),
				new XElement("Login", Login),
				new XElement("Password", Password),
				new XElement("IsAdmin", isAdmin),
				new XElement("IsBlocked", isBlocked),
				new XElement("IsPasswordDifficult", isPasswordDifficult),
				new XElement("PasswordMinLength", PasswordMinLength),
				new XElement("PasswordLifetimeMonths", PasswordLifetimeMonths),
				new XElement("LastPasswordChange", LastPasswordChange.ToString("O"))
			);

		public void Update(UserBindingModel model)
		{
			if (model == null)
			{
				return;
			}
			Login = model.Login;
			Password = model.Password;
			isAdmin = model.isAdmin;
			isBlocked = model.isBlocked;
			isPasswordDifficult = model.isPasswordDifficult;
			PasswordLifetimeMonths = model.PasswordLifetimeMonths;
			LastPasswordChange = model.LastPasswordChange;
			PasswordMinLength = model.PasswordMinLength;
		}
		public UserViewModel GetViewModel => new()
		{
			Id = Id,
			Login = Login,
			Password = Password,
			isAdmin = isAdmin,
			isBlocked = isBlocked,
			isPasswordDifficult = isPasswordDifficult,
			PasswordLifetimeMonths = PasswordLifetimeMonths,
			LastPasswordChange = LastPasswordChange,
			PasswordMinLength = PasswordMinLength,
		};
	}
}
