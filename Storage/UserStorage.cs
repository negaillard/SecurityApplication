using Contracts;

namespace Storage
{
	public class UserStorage
	{
		private readonly DataFileSingleton source;

		public UserStorage()
		{
			source = DataFileSingleton.GetInstance();
		}
		public UserViewModel? Delete(UserBindingModel model)
		{
			var element = source.Users.FirstOrDefault(rec => rec.Id == model.Id);
			if (element != null)
			{
				source.Users.Remove(element);
				source.SaveUsers();
				return element.GetViewModel;
			}
			return null;
		}

		public UserViewModel? GetElement(UserSearchModel model)
		{
			if (string.IsNullOrEmpty(model.Login) &&
			   string.IsNullOrEmpty(model.Id))
			{
				return null;
			}
			return source.Users
			.FirstOrDefault(x => (string.IsNullOrEmpty(model.Id) || x.Id == model.Id) &&
								 (string.IsNullOrEmpty(model.Login) || x.Login == model.Login) &&
								 (string.IsNullOrEmpty(model.Password) || x.Password == model.Password))
			?.GetViewModel;
		}

		public UserViewModel? GetElementWithPassword(UserSearchModel model)
		{
			if (string.IsNullOrEmpty(model.Login) &&
			   string.IsNullOrEmpty(model.Id) ||
			   string.IsNullOrEmpty(model.Password))
			{
				return null;
			}
			return source.Users
			.FirstOrDefault(x => (string.IsNullOrEmpty(model.Id) || x.Id == model.Id) &&
								 (string.IsNullOrEmpty(model.Login) || x.Login == model.Login) &&
								 (string.IsNullOrEmpty(model.Password) || x.Password == model.Password))
			?.GetViewModel;
		}


		public List<UserViewModel> GetFilteredList(UserSearchModel model)
		{
			if (string.IsNullOrEmpty(model.Login) && string.IsNullOrEmpty(model.Password))
			{
				return new();
			}
			return source.Users
			.Where(x => (string.IsNullOrEmpty(model.Login) || x.Login.Contains(model.Login)) &&
						 (string.IsNullOrEmpty(model.Password) || x.Login.Contains(model.Password)))
		   .Select(x => x.GetViewModel)
		   .ToList();
		}

		public List<UserViewModel> GetFullList()
		{
			return source.Users
			.Select(x => x.GetViewModel)
			.ToList();
		}

		public UserViewModel? Insert(UserBindingModel model)
		{
			var newUser = User.Create(model);
			if (newUser == null)
			{
				return null;
			}
			source.Users.Add(newUser);
			source.SaveUsers();
			return newUser.GetViewModel;
		}

		public UserViewModel? Update(UserBindingModel model)
		{

			var buh = source.Users.FirstOrDefault(x => x.Id == model.Id);
			if (buh == null)
			{
				return null;
			}
			buh.Update(model);
			source.SaveUsers();
			return buh.GetViewModel;
		}
	}
}
