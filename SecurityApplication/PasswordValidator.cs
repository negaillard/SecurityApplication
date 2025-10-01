using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecurityApplication
{
	public static class PasswordValidator
	{
		public static bool IsValid(string password, int minLength)
		{
			if (string.IsNullOrEmpty(password))
				return false;

			if (password.Length < minLength)
				return false;
			// строчная буква
			if (!Regex.IsMatch(password, "[a-z]")) return false;
			// прописная буква
			if (!Regex.IsMatch(password, "[A-Z]")) return false;
			// цифра
			if (!Regex.IsMatch(password, "[0-9]")) return false;
			// арифметический знак
			if (!Regex.IsMatch(password, "[\\+\\-\\*/]")) return false;

			return true;
		}
	}
}
