using Contracts.Crypto;
using System.Xml.Linq;

namespace Storage
{
	public class DataFileSingleton
	{
		private static DataFileSingleton? instance;

		private readonly string EncFile = "Users.xml.enc";
		private readonly string TmpFile = "Users.xml";

		private readonly byte[] Key = System.Text.Encoding.UTF8.GetBytes("12345678"); // 8 байт
		private readonly byte[] Iv = System.Text.Encoding.UTF8.GetBytes("87654321"); // 8 байт

		public List<User> Users { get; private set; }
		public static DataFileSingleton GetInstance()
		{
			if (instance == null)
			{
				instance = new DataFileSingleton();
			}
			return instance;
		}
		public void SaveUsers()
		{
			// сохраняем во временный XML
			SaveData(Users, TmpFile, "Users", x => x.GetXElement);

			// шифруем в EncFile
			DesOfbHelper.EncryptOFB(Key, Iv, TmpFile, EncFile);

			// удаляем открытый файл
			File.Delete(TmpFile);
		}

		private DataFileSingleton()
		{
			if (!File.Exists(EncFile))
			{
				// Создаём файл с одним админом
				Users = new List<User>
				{
					new User
					{
						Login = "admin",
						Password = MD4Helper.ComputeHashHex(string.Empty),        // пустой пароль
						isAdmin = true,
						isBlocked = false,
						isPasswordDifficult = false,
						PasswordMinLength = 0,
						PasswordLifetimeMonths = 0,
						LastPasswordChange = DateTime.UtcNow,
					}
				};
				SaveUsers();
			}
			else
			{
				// расшифровываем EncFile во временный TmpFile
				DesOfbHelper.DecryptOFB(Key, Iv, EncFile, TmpFile);

				// читаем XML
				Users = LoadData(TmpFile, "User", x => User.Create(x)!)!;

				// сразу удаляем временный файл с открытым XML
				File.Delete(TmpFile);
			}
		}

		private static List<T>? LoadData<T>(string filename, string xmlNodeName, Func<XElement, T> selectFunction)
		{
			if (File.Exists(filename))
			{
				return
			   XDocument.Load(filename)?.Root?.Elements(xmlNodeName)?.Select(selectFunction)?.ToList();
			}
			return new List<T>();
		}

		private static void SaveData<T>(List<T> data, string filename, string xmlNodeName, Func<T, XElement> selectFunction)
		{
			if (data != null)
			{
				new XDocument(new XElement(xmlNodeName, data.Select(selectFunction).ToArray())).Save(filename);
			}
		}
	}
}
