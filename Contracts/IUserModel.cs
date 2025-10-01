using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		int PasswordLifetimeMonths { get;  }
		DateTime LastPasswordChange { get;  }

	}
}
